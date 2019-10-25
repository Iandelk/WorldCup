using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WPF_App
{
    /// <summary>
    /// Interaction logic for playerOnField.xaml
    /// </summary>
    public partial class playerOnField : UserControl
    {
        MainWindow mw;
        Player player;
        int  PLAYER_STATS_WIDTH = 500;
        int PLAYER_STATS_HEIGHT = 194;

        private const string DEFAULT_IMAGE_PATH = @"C:\Users\Phyrexian\source\repos\WorldCup_Projekt\LoadFrom\PlayerNoImage.png";

        public playerOnField(Player player, MainWindow mw)
        {
            InitializeComponent();
            this.player = player;
            this.mw = mw;
            SetUpPlayerOnField();
        }

        private void SetUpPlayerOnField()
        {
            if (player.ImagePath == null)
            {
                player.ImagePath = DEFAULT_IMAGE_PATH;
            }

            lblName.Content = player.Name;
            lblShirtNumber.Content = player.ShirtNumber;
            imagePortrait.Source = new BitmapImage(new Uri(player.ImagePath));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            closeWindow();
            playerStats ps = new playerStats(player);
            Point relativePoint = this.TransformToAncestor(mw).Transform(new Point(0, 0));
            Point location = new Point(0,0);

            if (relativePoint.X < mw.ActualWidth/2 && relativePoint.Y < mw.ActualHeight/2)
            {
                location = this.PointToScreen(new Point(0, 0));              
            }

            else if (relativePoint.X > mw.ActualWidth / 2 && relativePoint.Y < mw.ActualHeight / 2)
            {
                location = this.PointToScreen(new Point(this.ActualWidth - PLAYER_STATS_WIDTH, 0));        
            }
            else if (relativePoint.X < mw.ActualWidth / 2 && relativePoint.Y > mw.ActualHeight / 2)
            {
                location = this.PointToScreen(new Point(0, this.ActualHeight - PLAYER_STATS_HEIGHT));
            }
            else if (relativePoint.X > mw.ActualWidth / 2 && relativePoint.Y > mw.ActualHeight / 2)
            {
                location = this.PointToScreen(new Point(this.ActualWidth - PLAYER_STATS_WIDTH, this.ActualHeight - PLAYER_STATS_HEIGHT));
            }
            else
            {
                location = this.PointToScreen(new Point(PLAYER_STATS_WIDTH/2, PLAYER_STATS_HEIGHT/2));
            }

 
            ps.Left = location.X;
            ps.Top = location.Y;
            ps.Show();
        }

        private void closeWindow()
        {
            foreach (Window w in Application.Current.Windows)
            {
                if(w.Tag.ToString() == "playerStats")
                {
                    w.Close();
                }
                
            }
        }

    }
}