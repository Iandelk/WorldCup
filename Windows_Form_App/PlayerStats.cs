using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Cup_Data;

namespace Windows_Form_App
{

    public partial class PlayerStats : UserControl
    {

        Player Player;
        private const string DEFAULT_IMAGE_PATH = "PlayerNoImage.png";

        public PlayerStats(Player player)
        {
                InitializeComponent();
                SetPlayerStats(player);
                this.Player = player;  
        }

        private void SetPlayerStats(Player player)
        {

            if (player.ImagePath == null)
            {
                PlayerImage.ImageLocation = DEFAULT_IMAGE_PATH;
            }
            else
            {
                PlayerImage.ImageLocation = player.ImagePath;
            }
            lblPlayerName.Text = player.Name;
            lblGoalsScored.Text = $"{Resources.Resources.GoalsString} {player.GoalsScored.ToString()}";
            lblYellowCards.Text = $"{Resources.Resources.YellowCardsString} {player.YellowCards.ToString()}";

        }
             
    }
}
