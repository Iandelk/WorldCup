namespace Windows_Form_App
{
    partial class MatchStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchStats));
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblhome = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.pnlPlayerFrame = new System.Windows.Forms.Panel();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblaway = new System.Windows.Forms.Label();
            this.pnlPlayerFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.lblLocation.Name = "lblLocation";
            // 
            // lblhome
            // 
            resources.ApplyResources(this.lblhome, "lblhome");
            this.lblhome.Name = "lblhome";
            // 
            // lblAttendance
            // 
            resources.ApplyResources(this.lblAttendance, "lblAttendance");
            this.lblAttendance.Name = "lblAttendance";
            // 
            // pnlPlayerFrame
            // 
            resources.ApplyResources(this.pnlPlayerFrame, "pnlPlayerFrame");
            this.pnlPlayerFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerFrame.Controls.Add(this.lblAwayTeam);
            this.pnlPlayerFrame.Controls.Add(this.lblHomeTeam);
            this.pnlPlayerFrame.Controls.Add(this.lblaway);
            this.pnlPlayerFrame.Controls.Add(this.lblLocation);
            this.pnlPlayerFrame.Controls.Add(this.lblhome);
            this.pnlPlayerFrame.Controls.Add(this.lblAttendance);
            this.pnlPlayerFrame.Name = "pnlPlayerFrame";
            // 
            // lblAwayTeam
            // 
            resources.ApplyResources(this.lblAwayTeam, "lblAwayTeam");
            this.lblAwayTeam.Name = "lblAwayTeam";
            // 
            // lblHomeTeam
            // 
            resources.ApplyResources(this.lblHomeTeam, "lblHomeTeam");
            this.lblHomeTeam.Name = "lblHomeTeam";
            // 
            // lblaway
            // 
            resources.ApplyResources(this.lblaway, "lblaway");
            this.lblaway.Name = "lblaway";
            // 
            // MatchStats
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPlayerFrame);
            this.Name = "MatchStats";
            this.pnlPlayerFrame.ResumeLayout(false);
            this.pnlPlayerFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Panel pnlPlayerFrame;
        private System.Windows.Forms.Label lblaway;
        private System.Windows.Forms.Label lblAwayTeam;
        private System.Windows.Forms.Label lblHomeTeam;
    }
}
