using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using World_Cup_Data;
using World_Cup_Data.DAL;
using World_Cup_Data.Models;
using WPFCustomMessageBox;

namespace WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string YELLOW_CARD_EVENT = "yellow-card";
        private const string GOAL_EVENT = "goal";
        private IList<Player> playerListAway;
        private IList<Player> playerListHome;
        private IList<Player> playersGoalieHome = new List<Player>();
        private IList<Player> playersGoalieAway = new List<Player>();
        private IList<Player> playersDefenderHome = new List<Player>();
        private IList<Player> playersMidfielderHome = new List<Player>();
        private IList<Player> playersAttackerHome = new List<Player>();
        private IList<Player> playersDefenderAway = new List<Player>();
        private IList<Player> playersMidfielderAway = new List<Player>();
        private IList<Player> playersAttackerAway = new List<Player>();
        private IList<TeamEvents> eventListHome;
        private IList<TeamEvents> eventListAway;
        private IList<Match> matches;
        private IList<String> favoriteCountry;
        private IList<String> awayCountry;
        private IList<Team> teamsList;
        private IRepoMatches repo;
        private IRepoFile fileRepo;
        private IRepoTeams teamsRepo;
        string fifaCodeHome;
        string countryHome;
        string fifaCodeAway;
        string countryAway;
        string fifaId;
        private const string HR_CULTURE = "hr-HR";
        private const string EN_CULTURE = "en";
        private const string MAXIMIZED = "Maximized";
        private const string WINDOWED = "Windowed";
        bool callClose;
        bool callRefresh;

        public MainWindow()
        {
            InitializeComponent();
            callClose = true;
            callRefresh = false;
            repo = RepoFactory.GetMatchRepo();
            fileRepo = RepoFactory.GetFileRepo();
            teamsRepo = RepoFactory.GetTeamRepo();
            favoriteCountry = fileRepo.LoadFavoriteCountry();
            awayCountry = fileRepo.LoadAwayCountry();
            countryHome = favoriteCountry[0];
            fifaCodeHome = favoriteCountry[1];
            countryAway = awayCountry[0];
            fifaCodeAway = awayCountry[1];
            fifaId = awayCountry[2];
            getCulture(fileRepo.LoadCulture());
            setPrefferedSize();
            CheckCulture();


        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DoAsync();
        }

        private async void DoAsync()
        {
            
            teamsList = await GetTeamsAsync();
            matches = await GetMatchesAsync(fifaCodeHome);
            matches = await GetMatchesAsync(fifaCodeAway);
            playerListHome = GetPlayersAndEventsAsync(countryHome).Result.Item1;
            eventListHome = GetPlayersAndEventsAsync(countryHome).Result.Item2;
            playerListAway = GetPlayersAndEventsAsync(countryAway).Result.Item1;
            eventListAway = GetPlayersAndEventsAsync(countryAway).Result.Item2;

            LoadContents();
            SetUpPlayerRolesLists_Home();
            SetUpPlayerRolesLists_Away();
            SetupFieldPerPlayer();
            SetUpTeamStatistics(teamsList);
            callRefresh = true;
        }

        private void LoadContents()
        {
            foreach(Player player in playerListHome)
            {
                fileRepo.LoadPlayerImages(countryHome, player);
                LoadGoalsAndCards(player, eventListHome);
            }
            foreach(Player player in playerListAway)
            {
                fileRepo.LoadPlayerImages(countryAway, player);
                LoadGoalsAndCards(player, eventListAway);
            }
           
        }

        private void setPrefferedSize() {
            string Size = fileRepo.LoadWindowSize();

            if (Size == MAXIMIZED)
            {
                FullscreenMenuItem.IsChecked = true;
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                WindowedMenuItem.IsChecked = true;
                this.WindowState = WindowState.Normal;
            }

        }

        private void SetUpTeamStatistics(IList<Team> teams)
        {
            Team homeTeam = teamsList.First(t => t.FifaCode == fifaCodeHome);
            Team awayTeam = teamsList.First(t => t.FifaCode == fifaCodeAway);

            lblGamesPlayed_Home.Content = $"{Properties.Resources.GamesPlayed}{homeTeam.GamesPlayed}";
            lblGamesWon_Home.Content =  $"  {Properties.Resources.GamesWon}{homeTeam.Wins}";
            lblGamesLost_Home.Content = $"  {Properties.Resources.GamesLost}{homeTeam.Losses}";
            lblGamesDrawn_Home.Content = $"  {Properties.Resources.GamesDrawn}{homeTeam.Draws}";
            lblGoalsScored_Home.Content = $"{Properties.Resources.GoalsScored}{homeTeam.GoalsFor}";
            lblGoalsReceived_Home.Content = $"  {Properties.Resources.GoalsReceived}{homeTeam.GoalsAgainst}";
            lblGoalsDifferential_Home.Content = $"  {Properties.Resources.GoalsDifferential}{homeTeam.GoalDifferential}";
            lblGamesPlayed_Away.Content = $"{Properties.Resources.GamesPlayed}{homeTeam.GamesPlayed}";
            lblGamesWon_Away.Content = $"  {Properties.Resources.GamesWon}{awayTeam.Wins}";
            lblGamesLost_Away.Content = $"  {Properties.Resources.GamesLost}{awayTeam.Losses}";
            lblGamesDrawn_Away.Content = $"  {Properties.Resources.GamesDrawn}{awayTeam.Draws}";
            lblGoalsScored_Away.Content = $"{Properties.Resources.GoalsScored}{awayTeam.GoalsFor}";
            lblGoalsReceived_Away.Content = $"  {Properties.Resources.GoalsReceived}{awayTeam.GoalsAgainst}";
            lblGoalsDifferential_Away.Content = $"  {Properties.Resources.GoalsDifferential}{awayTeam.GoalDifferential}";

            lblVS.Content = $"{homeTeam.Country}({homeTeam.FifaCode}) VS {awayTeam.Country}({awayTeam.FifaCode})";
        }


        private Task<IList<Match>> GetMatchesAsync(string fifaCode)
        {
            return Task.Run(() => repo.LoadMatches(fifaCode)
                );

        }

        private Task<IList<Team>> GetTeamsAsync()
        {

            return Task.Run(() => teamsRepo.LoadTeams()
                );

        }

        private async Task<Tuple<IList<Player>, IList<TeamEvents>>> GetPlayersAndEventsAsync(String country)
        {
            var temporaryTuple = new Tuple<IList<Player>, IList<TeamEvents>>(repo.LoadPlayersAsStartingEleven(matches, country), repo.LoadSpecificTeamEvents(matches, fifaId));

            return await Task.FromResult(temporaryTuple);

        }

        private void SetupFieldPerPlayer()
        {
            setUpField(playersGoalieHome,0, Colors.Blue);
            setUpField(playersDefenderHome, 1, Colors.Blue);
            setUpField(playersMidfielderHome, 2, Colors.Blue);
            setUpField(playersAttackerHome, 3, Colors.Blue);
            setUpField(playersGoalieAway, 8, Colors.Red);
            setUpField(playersDefenderAway, 7, Colors.Red);
            setUpField(playersMidfielderAway, 6, Colors.Red);
            setUpField(playersAttackerAway, 5, Colors.Red);

        }

        private void setUpField(IList<Player> players, int column, Color color)
        { int j = 0;

            if (players.Count == 1)
            {

                playerOnField pOF = new playerOnField(players[j],this);
                pOF.VerticalAlignment = VerticalAlignment.Center;
                Grid.SetRow(pOF, 2);
                    Grid.SetColumn(pOF, column);
                    gridField.Children.Add(pOF);

                
            }

          else  if (players.Count == 2)
            {
                for (int i = 1; i < 5; i = i + 2)
                {
                    playerOnField pOF = new playerOnField(players[j], this);
                    pOF.VerticalAlignment = VerticalAlignment.Center;
                    Grid.SetRow(pOF, i);
                    Grid.SetColumn(pOF, column);
                    gridField.Children.Add(pOF);
                    j++;
                }

            }
            else if (players.Count == 3)
            {
                for (int i = 0; i < 5; i = i + 2)
                {
                    playerOnField pOF = new playerOnField(players[j], this);
                    pOF.VerticalAlignment = VerticalAlignment.Center;
                    Grid.SetRow(pOF, i);
                    Grid.SetColumn(pOF, column);
                    gridField.Children.Add(pOF);
                    j++;
                }
            }
            else if (players.Count == 4)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i < 2)
                    {
                        playerOnField pOF = new playerOnField(players[j], this);
                        pOF.VerticalAlignment = VerticalAlignment.Bottom;
                        Grid.SetRow(pOF, i);
                        Grid.SetColumn(pOF, column);
                        gridField.Children.Add(pOF);
                        j++;
                    }
                    if (i > 2)
                    {
                        playerOnField pOF = new playerOnField(players[j], this);
                        pOF.VerticalAlignment = VerticalAlignment.Top;
                        Grid.SetRow(pOF, i);
                        Grid.SetColumn(pOF, column);
                        gridField.Children.Add(pOF);
                        j++;
                    }

                }
            }
            else if (players.Count == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    playerOnField pOF = new playerOnField(players[j], this);
                    pOF.VerticalAlignment = VerticalAlignment.Center;
                    Grid.SetRow(pOF, i);
                    Grid.SetColumn(pOF, column);
                    gridField.Children.Add(pOF);
                    j++;
                }
            }


        }

        private void SetUpPlayerRolesLists_Home()
        {
            foreach (Player player in playerListHome)
            {
                if(player.Position == "Goalie")
                {
                    playersGoalieHome.Add(player);
                }
               else if (player.Position == "Defender")
                {
                    playersDefenderHome.Add(player);
                }
                else if (player.Position == "Midfield")
                {
                    playersMidfielderHome.Add(player);
                }
                else if (player.Position == "Forward")
                {
                    playersAttackerHome.Add(player);
                }
            }

        }

        private void SetUpPlayerRolesLists_Away()
        {
            foreach (Player player in playerListAway)
            {
                if (player.Position == "Goalie")
                {
                    playersGoalieAway.Add(player);
                }
                else if (player.Position == "Defender")
                {
                    playersDefenderAway.Add(player);
                }
                else if (player.Position == "Midfield")
                {
                    playersMidfielderAway.Add(player);
                }
                else if (player.Position == "Forward")
                {
                    playersAttackerAway.Add(player);
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

       

        private void newTeam_Click(object sender, RoutedEventArgs e)
        {
            callClose = false;
            CountrySelect cs = new CountrySelect();
            cs.Show();
            this.Close();
        }

        private void CroatianMenuItem_Click(object sender, RoutedEventArgs e)
        {
            string culture = HR_CULTURE;
            changeLanguageDialog(culture, (sender as System.Windows.Controls.MenuItem).Header.ToString());
            fileRepo.SaveCulture(culture);
            EnglishMenuItem.IsChecked = false;
            CroatianMenuItem.IsChecked = true;
        }

        private void EnglishMenuItem_Click(object sender, RoutedEventArgs e)
        {
            string culture = EN_CULTURE;
            changeLanguageDialog(culture, (sender as System.Windows.Controls.MenuItem).Header.ToString());
            fileRepo.SaveCulture(culture);
            EnglishMenuItem.IsChecked = true;
            CroatianMenuItem.IsChecked = false;
        }


        private void changeLanguageDialog(string culture, string language)
        {
           

            var confirmResult = CustomMessageBox.ShowOKCancel(Properties.Resources.LanguageDialogText + language + "?", Properties.Resources.LanguageDialogTitle, Properties.Resources.Yes, Properties.Resources.No);



            if (confirmResult == MessageBoxResult.OK)
            {
                getCulture(culture);
            }
        }

            private void getCulture(string culture)
            {
                var cultureInfo = new CultureInfo(culture);

                Thread.CurrentThread.CurrentUICulture = cultureInfo;

            if (callRefresh)
            {

                SetUpTeamStatistics(teamsList);
                Options.Header = Properties.Resources.Options;
                changeLanguage.Header = Properties.Resources.ChangeLanguage;
                newTeam.Header = Properties.Resources.ChooseAnewTeam;
                EnglishMenuItem.Header = Properties.Resources.English;
                CroatianMenuItem.Header = Properties.Resources.Croatian;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (callClose)
            {
                

                var confirmResult = CustomMessageBox.ShowOKCancel(Properties.Resources.ExitDialogText, Properties.Resources.ExitDialogTitle, Properties.Resources.Yes, Properties.Resources.No);

               

                if (confirmResult == MessageBoxResult.Cancel)
                    e.Cancel = true;
                if (confirmResult == MessageBoxResult.OK)
                    Environment.Exit(0);
            }
        }


        private void CheckCulture()
        {
            if (fileRepo.LoadCulture() == EN_CULTURE)
            {
                CroatianMenuItem.IsChecked = false;
                EnglishMenuItem.IsChecked = true;
            }
            else
            {
                EnglishMenuItem.IsChecked = false;
                CroatianMenuItem.IsChecked = true;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (Window w in System.Windows.Application.Current.Windows)
            {
                if (w.Tag.ToString() == "playerStats")
                {
                    w.Close();
                }

            }
        }

        private void WindowedMenuItem_Click(object sender, RoutedEventArgs e)
        {

            WindowedMenuItem.IsChecked = true;
            FullscreenMenuItem.IsChecked = false;
            this.WindowState = WindowState.Normal;
            fileRepo.SaveWindowSize(WINDOWED);


        }

        private void FullscreenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            FullscreenMenuItem.IsChecked = true;
            WindowedMenuItem.IsChecked = false;
            this.WindowState = WindowState.Maximized;         
            fileRepo.SaveWindowSize(MAXIMIZED);

        }
    }
}
