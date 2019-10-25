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
    public partial class PlayerFrame : UserControl
    {
        private const string DEFAULT_IMAGE_PATH = "PlayerNoImage.png";
        private const string IMAGES_FILTER = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                        "All files (*.*)|*.*";

        public delegate void OnDialogLoadOk(object sender, EventArgs args);
        public Player Player { get; set; }
        public event OnDialogLoadOk OnLoadOk;
        public PictureBox box { get; set; }
        public Panel pnlPlayer
        {
            get
            {
                return pnlPlayerFrame;
            }
            set
            {
                pnlPlayerFrame = value;
            }
        }

        public PlayerFrame(Player player)
        {
            InitializeComponent();
            SetPlayerFrame(player);
            this.Player = player;
            box = imageFavorite;
        }

        private void SetPlayerFrame(Player player)
        {
            if (player.ImagePath == null)
            {
                player.ImagePath = DEFAULT_IMAGE_PATH;
            }
           
            PlayerImage.ImageLocation = player.ImagePath;
            lblPlayerName.Text = player.Name;
            lblShirtNumber.Text = player.ShirtNumber.ToString();
            lblPlayerPosition.Text = player.Position;           
            if(player.Captain == false)
            {
                lblCaptain.Hide();
            }
          

        }


        private void PlayerImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {

                Filter = IMAGES_FILTER
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                PlayerImage.ImageLocation = fileDialog.FileName;
                Player.ImagePath = PlayerImage.ImageLocation;
                OnLoadOk?.Invoke(this, null);
            }
        }

        public void RefreshImage()
        {
            PlayerImage.ImageLocation = Player.ImagePath;
        }

    }
}
