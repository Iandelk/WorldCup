using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Cup_Data;
using World_Cup_Data.DAL;
using World_Cup_Data.Models;

namespace Windows_Form_App
{
    public partial class Statistics : Form
    {
        private IList<Player> players;
        private IList<Match> matches;

        public Statistics(IList<Player> players, IList<Match> matches)
        {
            InitializeComponent();
            this.matches = matches;
            this.players = players;
        }

        private void Statistics_Load(object sender, EventArgs e)
        {


            RefreshPlayerList();
            RefreshMatchList();

        }

        private void btn_sortPlayersPerGoals_Click(object sender, EventArgs e)
        {

            players =  players.OrderByDescending(player => player.GoalsScored).ToList();
            RefreshPlayerList();
        }

        private void btn_SortPlayersByYellowCards_Click(object sender, EventArgs e)
        {
          players =  players.OrderByDescending(player => player.YellowCards).ToList();
            RefreshPlayerList();
        }

        private void RefreshPlayerList()
        {

            flpAllPlayersStatistics.Controls.Clear();
            foreach (var player in players)
            {

                PlayerStats ps = new PlayerStats((player as Player));


                flpAllPlayersStatistics.Controls.Add(ps);
            }
        }

        private void RefreshMatchList()
        {

            matches = matches.OrderByDescending(match => match.Attendance).ToList();

            flpMatchStatistics.Controls.Clear();
            foreach (var match in matches)
            {

               MatchStats ms = new MatchStats((match as Match));


                flpMatchStatistics.Controls.Add(ms);
            }
        }

        private void btnPrintPlayer_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();

        }

        private void btnPrintMatches_Click(object sender, EventArgs e)
        {
            printPreviewDialogMatch.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int i = 0;
            int itemHeight=0;
            int itemWidth = 300;
            Point startingPoint;

            foreach (var item in flpAllPlayersStatistics.Controls)
            {
                if(i == 12)
                {
                    itemHeight = 0;
                }

                if (i < 12)
                {

                    startingPoint = new Point
                    {
                        X = e.MarginBounds.Left,
                        Y = e.MarginBounds.Top + itemHeight
                    };
                    itemHeight = itemHeight + 85;

                }
                else
                {
                    startingPoint = new Point
                    {
                        X = e.MarginBounds.Left + itemWidth,
                        Y = e.MarginBounds.Top + itemHeight
                    };
                    itemHeight = itemHeight + 85;
                }

                PlayerStats statFrame = item as PlayerStats;

                var bmp = new Bitmap(statFrame.Size.Width, statFrame.Size.Height);
                statFrame.DrawToBitmap(bmp, new Rectangle
                {
                    X = 0,
                    Y = 0,
                    Width = statFrame.ClientSize.Width,
                    Height = statFrame.ClientSize.Height
                });


                e.Graphics.DrawImage(bmp, startingPoint);
                i++;
            }

           

        }

        private void printDocument_EndPrint(object sender, PrintEventArgs e)
        {
            if(e.PrintAction == PrintAction.PrintToPreview)
            {
                MessageBox.Show(Resources.Resources.Print_Finished);
            }
        }

        private void printDocumentMatch_PrintPage(object sender, PrintPageEventArgs e)
        {
            int i = 0;
            int itemHeight = 0;
            Point startingPoint;

            foreach (var item in flpMatchStatistics.Controls)
            {
          
             

                    startingPoint = new Point
                    {
                        X = e.MarginBounds.Left,
                        Y = e.MarginBounds.Top + itemHeight
                    };
                    itemHeight = itemHeight + 110;

                
              

                MatchStats statFrame = item as MatchStats;

                var bmp = new Bitmap(statFrame.Size.Width, statFrame.Size.Height);
                statFrame.DrawToBitmap(bmp, new Rectangle
                {
                    X = 0,
                    Y = 0,
                    Width = statFrame.ClientSize.Width,
                    Height = statFrame.ClientSize.Height
                });


                e.Graphics.DrawImage(bmp, startingPoint);
                i++;
            }



        }

        private void printDocumentMatch_EndPrint(object sender, PrintEventArgs e)
        {
            if (e.PrintAction == PrintAction.PrintToPreview)
            {
                MessageBox.Show(Resources.Resources.Print_Finished);
            }
        }
    }
}
