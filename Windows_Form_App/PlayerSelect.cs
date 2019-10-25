using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Cup_Data;
using World_Cup_Data.DAL;
using World_Cup_Data.Models;

namespace Windows_Form_App
{
    public partial class PlayerSelect : Form
    {
      
        private const string YELLOW_CARD_EVENT = "yellow-card";
        private const string GOAL_EVENT = "goal";
        private const string HR_CULTURE = "hr-HR";
        private const string EN_CULTURE = "en";
        private IRepoMatches repo;
        private IRepoFile fileRepo;
        private IList<Player> playerList;
        private IList<TeamEvents> eventList;
        private IList<Match> matches;
        string fifaCode;
        string country;
        Panel chosenPanel;
        PlayerFrame ChosenPlayer;
        List<PlayerFrame> chosenPlayerFrames = new List<PlayerFrame>();


        public PlayerSelect(string fifaCode, string country)
        {
            InitializeComponent();
            repo = RepoFactory.GetMatchRepo();
            fileRepo = RepoFactory.GetFileRepo();
            this.fifaCode = fifaCode;
            this.country = country;
        }

        private void PlayerSelect_Load(object sender, EventArgs e)
        {
            getCulture(fileRepo.LoadCulture());
            CheckCulture();
            DoAsync();

        }

        private void LoadContents()
        {
            foreach (var player in playerList)
            {
                fileRepo.LoadPlayerImages(country, player);

                LoadGoalsAndCards(player, eventList);
                PlayerFrame pf = new PlayerFrame((player as Player));
                pf.pnlPlayer.MouseDown += PnlPlayer_MouseDown;
                pf.ContextMenuStrip = contextMenuAdd;
                AddEventsToPlayerFrame(pf);
                flpAllPlayers.Controls.Add(pf);
            }

            SetAsFavorite(fileRepo.LoadFavoritePlayers(country, playerList));
        }

        private void AddEventsToPlayerFrame(PlayerFrame pf)
        {
            pf.pnlPlayer.Click += PnlPlayer_Click;
            pf.OnLoadOk += Pf_OnLoadOk;

            if ((pf.Parent as FlowLayoutPanel) == flpPlayerFrameControl)
                if ((pf.Parent as FlowLayoutPanel) == flpPlayerFrameControl)
                {
                    foreach (var item in pf.pnlPlayer.Controls)
                    {
                        if (item is Label)
                        {
                            (item as Label).Click += PnlPlayer_Click;
                            (item as Label).MouseDown += PnlPlayer_MouseDown;
                        }
                    }
                }
                else
                {
                    foreach (var item in pf.pnlPlayer.Controls)
                    {
                        if (item is Label)
                        {
                            (item as Label).Click += PnlPlayer_Click;
                        }
                    }
                }
        }


        private void LoadGoalsAndCards(Player player, IList<TeamEvents> events)
        {
            foreach (var thing in events)
            {
                if (thing.Player == player.Name)
                {
                    if (thing.TypeOfEvent == YELLOW_CARD_EVENT)
                    {
                        player.YellowCards++;
                    }
                    else if (thing.TypeOfEvent.StartsWith(GOAL_EVENT))
                    {
                        player.GoalsScored++;
                    }
                }
            }
        }

        private void Pf_OnLoadOk(object sender, EventArgs args)
        {
            RefreshPlayerImages();
        }

        private void RefreshPlayerImages()
        {
            foreach (var item in flpPlayerFrameControl.Controls)
            {
                (item as PlayerFrame).RefreshImage();
            }
            foreach (var item in flpAllPlayers.Controls)
            {
                (item as PlayerFrame).RefreshImage();
            }
        }

        private void PnlPlayer_Click(object sender, EventArgs e)
        {
            HighlightSelectedItem(sender);
        }

        private void HighlightSelectedItem(object sender)
        {


            if (sender is Label)
                chosenPanel = ((sender as Label).Parent) as Panel;
            else
                chosenPanel = sender as Panel;

            ChosenPlayer = (chosenPanel.Parent) as PlayerFrame;

            if (Control.ModifierKeys == Keys.Control)
            {
                chosenPlayerFrames.Add(ChosenPlayer);
            }
            else
            {
                if (chosenPlayerFrames.Count > 0)
                {
                    chosenPlayerFrames.RemoveRange(0, chosenPlayerFrames.Count);
                }
                chosenPlayerFrames.Add(ChosenPlayer);
            }



            if (chosenPlayerFrames.Count > 3)
            {
                chosenPlayerFrames.RemoveAt(0);
            }

            foreach (var item in flpAllPlayers.Controls)
            {
                if (chosenPlayerFrames.Contains(item as PlayerFrame))
                {
                    (item as PlayerFrame).BackColor = Color.LightBlue;
                }
                else
                {
                    (item as PlayerFrame).BackColor = Color.Transparent;
                }
            }

            foreach (var item in flpPlayerFrameControl.Controls)
            {
                if (chosenPlayerFrames.Contains(item as PlayerFrame))
                {
                    (item as PlayerFrame).BackColor = Color.LightBlue;
                }
                else
                {
                    (item as PlayerFrame).BackColor = Color.Transparent;
                }
            }
        }

   

        private void SetAsFavorite(IList<Player> favoritePlayers)
        {
            foreach (var player in favoritePlayers)
            {
                foreach (var allFrame in flpAllPlayers.Controls)
                {
                    PlayerFrame allPlayerFrame = (allFrame as PlayerFrame);
                    if (player.ShirtNumber == allPlayerFrame.Player.ShirtNumber)
                    {
                        chosenPlayerFrames.Add(allPlayerFrame);
                    }


                }

            }

            SetAsFavorite();

        }

        private void SetAsFavorite()
        {
            foreach (var playerframe in chosenPlayerFrames)
            {


                if (!CheckIfMax())
                {

                    if (!CheckIfAlreadyFavorite(playerframe.Player))
                    {
                        playerframe.box.Show();
                        PlayerFrame pf = new PlayerFrame((playerframe.Player as Player));
                        AddEventsToPlayerFrame(pf);
                        pf.ContextMenuStrip = contextMenuRemove;
                        flpPlayerFrameControl.Controls.Add(pf);
                    }
                    else
                    {
                        MessageBox.Show(Resources.Resources.ALREADY_FAVORITE);
                    }
                }
                else
                {
                    MessageBox.Show(Resources.Resources.MAX_REACHED);

                }
            }
        }

        private void PlayerSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            fileRepo.SaveFavoritePlayers(country, convertFavoriteFramesToList());
            fileRepo.SavePlayerImages(country, playerList);
            Environment.Exit(0);
        }

        private bool CheckIfAlreadyFavorite(Player player)
        {
            foreach (var control in flpPlayerFrameControl.Controls)
            {
                if ((control as PlayerFrame).Player.ShirtNumber == player.ShirtNumber)
                {
                    return true;
                }


            }

            return false;
        }


        private bool CheckIfMax()
        {
            int counter = 0;

            foreach (var control in flpPlayerFrameControl.Controls)
            {
                counter++;
            }

            if (counter < 3)
            {
                return false;
            }

            return true;
        }

        private IList<Player> convertFavoriteFramesToList()
        {
            List<Player> favoritePlayers = new List<Player>();
            PlayerFrame frame;

            foreach (var control in flpPlayerFrameControl.Controls)
            {
                frame = control as PlayerFrame;

                favoritePlayers.Add(new Player
                {
                    Name = frame.Player.Name,
                    ShirtNumber = frame.Player.ShirtNumber,
                    Position = frame.Player.Position
                });
            }

            return favoritePlayers;
        }

        private void lblTeamStats_Click(object sender, EventArgs e)
        {
            Statistics TeamStatsForm = new Statistics(playerList, matches);

            TeamStatsForm.Show();
        }

        private void PnlPlayer_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                HighlightSelectedItem(sender);
                flpAllPlayers.DoDragDrop(chosenPlayerFrames, DragDropEffects.Copy);
            }

        }


        private void flpPlayerFrameControl_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void flpPlayerFrameControl_DragDrop(object sender, DragEventArgs e)
        {
            SetAsFavorite();
        }

        private void setAsFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAsFavorite();
        }

        private void removeFromFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((ChosenPlayer.Parent as FlowLayoutPanel) == flpPlayerFrameControl)
            {
                foreach (var favoritePlayer in chosenPlayerFrames)
                {

                    foreach (var player in flpAllPlayers.Controls)
                    {
                        if ((player as PlayerFrame).Player == favoritePlayer.Player)
                        {
                            (player as PlayerFrame).box.Hide();
                        }
                    }


                    favoritePlayer.Dispose();
                }
            }
        }

        private async void DoAsync()
        {
            matches = await GetMatchesAsync();
            playerList = GetPlayersAndEventsAsync().Result.Item1;
            eventList = GetPlayersAndEventsAsync().Result.Item2;
            LoadContents();
        }

        private Task<IList<Match>> GetMatchesAsync()
        {
            return Task.Run(() => repo.LoadMatches(fifaCode)
                );

        }

        private async Task <Tuple<IList<Player>, IList<TeamEvents>>> GetPlayersAndEventsAsync()
        {
            var temporaryTuple = new Tuple<IList<Player>, IList<TeamEvents>>(repo.LoadPlayers(matches, country), repo.LoadTeamEvents(matches, country));
           
             return await Task.FromResult(temporaryTuple);
          
        }

        private void changeFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileRepo.SaveFavoritePlayers(country, convertFavoriteFramesToList());
            fileRepo.SavePlayerImages(country, playerList);
            TeamSelect teamSelectForm = new TeamSelect();
            teamSelectForm.Show();
            this.Hide();
        }

        private void croatianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string culture = HR_CULTURE;
            changeLanguageDialog(culture, (sender as ToolStripMenuItem).Text);
            fileRepo.SaveCulture(culture);
            englishToolStripMenuItem.Checked = false;
            croatianToolStripMenuItem.Checked = true;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string culture = EN_CULTURE;
            changeLanguageDialog(culture, (sender as ToolStripMenuItem).Text);
            fileRepo.SaveCulture(culture);
            croatianToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.Checked = true;
        }

        private void CheckCulture()
        {
            if(fileRepo.LoadCulture() == EN_CULTURE)
            {
                croatianToolStripMenuItem.Checked = false;
                englishToolStripMenuItem.Checked = true;
            }
            else
            {
                englishToolStripMenuItem.Checked = false;
                croatianToolStripMenuItem.Checked = true;
            }
        }

        private void getCulture(string culture)
        {
            var cultureInfo = new CultureInfo(culture);

            Thread.CurrentThread.CurrentUICulture = cultureInfo;



            var resources = new ComponentResourceManager(typeof(PlayerSelect));
            


                foreach (ToolStripItem item in menuStrip.Items)
            {
                foreach (ToolStripItem dropDownItem in ((ToolStripDropDownItem)item).DropDownItems)
                {
                    resources.ApplyResources(dropDownItem, dropDownItem.Name, cultureInfo);
                }
                resources.ApplyResources(item, item.Name, cultureInfo);
            }

            foreach (Control control in this.Controls)
            {
                resources.ApplyResources(control, control.Name, cultureInfo);

                foreach (Control item in control.Controls)
                {
                    resources.ApplyResources(item, item.Name, cultureInfo);
                }

            }

        }

        private void changeLanguageDialog(string culture, string language)
        {
            var confirmResult = MessageBox.Show(Resources.Resources.LanguageString + language + "?",
                                     Resources.Resources.LanguageDialog,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                getCulture(culture);
            }
           
        }

      
    }

}
