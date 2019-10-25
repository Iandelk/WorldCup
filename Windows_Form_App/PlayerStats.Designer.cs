namespace Windows_Form_App
{
    partial class PlayerStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerStats));
            this.PlayerImage = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblYellowCards = new System.Windows.Forms.Label();
            this.lblGoalsScored = new System.Windows.Forms.Label();
            this.pnlPlayerFrame = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImage)).BeginInit();
            this.pnlPlayerFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerImage
            // 
            this.PlayerImage.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.PlayerImage, "PlayerImage");
            this.PlayerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerImage.Name = "PlayerImage";
            this.PlayerImage.TabStop = false;
            // 
            // lblPlayerName
            // 
            resources.ApplyResources(this.lblPlayerName, "lblPlayerName");
            this.lblPlayerName.BackColor = System.Drawing.SystemColors.Control;
            this.lblPlayerName.Name = "lblPlayerName";
            // 
            // lblYellowCards
            // 
            resources.ApplyResources(this.lblYellowCards, "lblYellowCards");
            this.lblYellowCards.BackColor = System.Drawing.SystemColors.Control;
            this.lblYellowCards.Name = "lblYellowCards";
            // 
            // lblGoalsScored
            // 
            resources.ApplyResources(this.lblGoalsScored, "lblGoalsScored");
            this.lblGoalsScored.BackColor = System.Drawing.SystemColors.Control;
            this.lblGoalsScored.Name = "lblGoalsScored";
            // 
            // pnlPlayerFrame
            // 
            this.pnlPlayerFrame.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPlayerFrame.Controls.Add(this.PlayerImage);
            this.pnlPlayerFrame.Controls.Add(this.lblPlayerName);
            this.pnlPlayerFrame.Controls.Add(this.lblYellowCards);
            this.pnlPlayerFrame.Controls.Add(this.lblGoalsScored);
            resources.ApplyResources(this.pnlPlayerFrame, "pnlPlayerFrame");
            this.pnlPlayerFrame.Name = "pnlPlayerFrame";
            // 
            // PlayerStats
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPlayerFrame);
            this.Name = "PlayerStats";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImage)).EndInit();
            this.pnlPlayerFrame.ResumeLayout(false);
            this.pnlPlayerFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PlayerImage;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblYellowCards;
        private System.Windows.Forms.Label lblGoalsScored;
        private System.Windows.Forms.Panel pnlPlayerFrame;
    }
}
