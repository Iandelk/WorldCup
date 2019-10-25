namespace Windows_Form_App
{
    partial class PlayerFrame
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerFrame));
            this.PlayerImage = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblShirtNumber = new System.Windows.Forms.Label();
            this.lblPlayerPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.fdPlayerFrame = new System.Windows.Forms.OpenFileDialog();
            this.pnlPlayerFrame = new System.Windows.Forms.Panel();
            this.imageFavorite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImage)).BeginInit();
            this.pnlPlayerFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerImage
            // 
            resources.ApplyResources(this.PlayerImage, "PlayerImage");
            this.PlayerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerImage.Name = "PlayerImage";
            this.PlayerImage.TabStop = false;
            this.PlayerImage.Click += new System.EventHandler(this.PlayerImage_Click);
            // 
            // lblPlayerName
            // 
            resources.ApplyResources(this.lblPlayerName, "lblPlayerName");
            this.lblPlayerName.Name = "lblPlayerName";
            // 
            // lblShirtNumber
            // 
            resources.ApplyResources(this.lblShirtNumber, "lblShirtNumber");
            this.lblShirtNumber.Name = "lblShirtNumber";
            // 
            // lblPlayerPosition
            // 
            resources.ApplyResources(this.lblPlayerPosition, "lblPlayerPosition");
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            // 
            // lblCaptain
            // 
            resources.ApplyResources(this.lblCaptain, "lblCaptain");
            this.lblCaptain.Name = "lblCaptain";
            // 
            // fdPlayerFrame
            // 
            this.fdPlayerFrame.FileName = "openFileDialog1";
            resources.ApplyResources(this.fdPlayerFrame, "fdPlayerFrame");
            // 
            // pnlPlayerFrame
            // 
            resources.ApplyResources(this.pnlPlayerFrame, "pnlPlayerFrame");
            this.pnlPlayerFrame.Controls.Add(this.imageFavorite);
            this.pnlPlayerFrame.Controls.Add(this.PlayerImage);
            this.pnlPlayerFrame.Controls.Add(this.lblCaptain);
            this.pnlPlayerFrame.Controls.Add(this.lblPlayerName);
            this.pnlPlayerFrame.Controls.Add(this.lblPlayerPosition);
            this.pnlPlayerFrame.Controls.Add(this.lblShirtNumber);
            this.pnlPlayerFrame.Name = "pnlPlayerFrame";
            // 
            // imageFavorite
            // 
            resources.ApplyResources(this.imageFavorite, "imageFavorite");
            this.imageFavorite.Image = global::Windows_Form_App.Properties.Resources.favorite;
            this.imageFavorite.Name = "imageFavorite";
            this.imageFavorite.TabStop = false;
            // 
            // PlayerFrame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPlayerFrame);
            this.Name = "PlayerFrame";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImage)).EndInit();
            this.pnlPlayerFrame.ResumeLayout(false);
            this.pnlPlayerFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageFavorite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerImage;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblShirtNumber;
        private System.Windows.Forms.Label lblPlayerPosition;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.OpenFileDialog fdPlayerFrame;
        private System.Windows.Forms.Panel pnlPlayerFrame;
        private System.Windows.Forms.PictureBox imageFavorite;
    }
}
