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
using System.Windows.Shapes;
using World_Cup_Data;

namespace WPF_App
{
    /// <summary>
    /// Interaction logic for playerStats.xaml
    /// </summary>
    public partial class playerStats : Window
    {
        Player player;

        public playerStats(Player player)
        {
            InitializeComponent();
            this.player = player;
            SetUpPlayerSelected();
        }

        private void SetUpPlayerSelected()
        {

            lblName.Content = player.Name;
            lblShirtNumber.Content = player.ShirtNumber;
            lblPosition.Content = player.Position;
            if (!player.Captain)
                lblcaptain.Visibility = Visibility.Collapsed;
            else
                lblcaptain.Content = "Captain";
            imagePortrait.Source = new BitmapImage(new Uri(player.ImagePath));
            lblGoalsScored.Content = $"Goals Scored: {player.GoalsScored}";
            lblYellowCards.Content = $"Yellow Cards: {player.YellowCards}";
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            foreach (Window w in Application.Current.Windows)
            {
                if (w.Tag.ToString() == "playerStats")
                {
                    w.Close();
                }
            }
        }
    }
}
