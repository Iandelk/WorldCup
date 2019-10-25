namespace Windows_Form_App
{
    partial class TeamSelect
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamSelect));
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.btnPickTeam = new System.Windows.Forms.Button();
            this.lblChooseCountry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            resources.ApplyResources(this.cbTeams, "cbTeams");
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Name = "cbTeams";
            // 
            // btnPickTeam
            // 
            resources.ApplyResources(this.btnPickTeam, "btnPickTeam");
            this.btnPickTeam.Name = "btnPickTeam";
            this.btnPickTeam.UseVisualStyleBackColor = true;
            this.btnPickTeam.Click += new System.EventHandler(this.btnPickTeam_Click);
            // 
            // lblChooseCountry
            // 
            resources.ApplyResources(this.lblChooseCountry, "lblChooseCountry");
            this.lblChooseCountry.Name = "lblChooseCountry";
            // 
            // TeamSelect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChooseCountry);
            this.Controls.Add(this.btnPickTeam);
            this.Controls.Add(this.cbTeams);
            this.Name = "TeamSelect";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeamSelect_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.Button btnPickTeam;
        private System.Windows.Forms.Label lblChooseCountry;
    }
}

