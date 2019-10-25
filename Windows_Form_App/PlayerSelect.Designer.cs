namespace Windows_Form_App
{
    partial class PlayerSelect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerSelect));
            this.flpAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayerFrameControl = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTeamStats = new System.Windows.Forms.Button();
            this.contextMenuAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setAsFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuRemove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.croatianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuAdd.SuspendLayout();
            this.contextMenuRemove.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpAllPlayers
            // 
            resources.ApplyResources(this.flpAllPlayers, "flpAllPlayers");
            this.flpAllPlayers.Name = "flpAllPlayers";
            // 
            // flpPlayerFrameControl
            // 
            this.flpPlayerFrameControl.AllowDrop = true;
            resources.ApplyResources(this.flpPlayerFrameControl, "flpPlayerFrameControl");
            this.flpPlayerFrameControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPlayerFrameControl.Name = "flpPlayerFrameControl";
            this.flpPlayerFrameControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpPlayerFrameControl_DragDrop);
            this.flpPlayerFrameControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpPlayerFrameControl_DragEnter);
            // 
            // lblTeamStats
            // 
            resources.ApplyResources(this.lblTeamStats, "lblTeamStats");
            this.lblTeamStats.Name = "lblTeamStats";
            this.lblTeamStats.UseVisualStyleBackColor = true;
            this.lblTeamStats.Click += new System.EventHandler(this.lblTeamStats_Click);
            // 
            // contextMenuAdd
            // 
            this.contextMenuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsFavoriteToolStripMenuItem,
            this.cancelToolStripMenuAdd});
            this.contextMenuAdd.Name = "contextMenuAdd";
            resources.ApplyResources(this.contextMenuAdd, "contextMenuAdd");
            // 
            // setAsFavoriteToolStripMenuItem
            // 
            this.setAsFavoriteToolStripMenuItem.Name = "setAsFavoriteToolStripMenuItem";
            resources.ApplyResources(this.setAsFavoriteToolStripMenuItem, "setAsFavoriteToolStripMenuItem");
            this.setAsFavoriteToolStripMenuItem.Click += new System.EventHandler(this.setAsFavoriteToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuAdd
            // 
            this.cancelToolStripMenuAdd.Name = "cancelToolStripMenuAdd";
            resources.ApplyResources(this.cancelToolStripMenuAdd, "cancelToolStripMenuAdd");
            // 
            // contextMenuRemove
            // 
            this.contextMenuRemove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromFavoritesToolStripMenuItem,
            this.cancelToolStripMenuRemove});
            this.contextMenuRemove.Name = "contextMenuRemove";
            resources.ApplyResources(this.contextMenuRemove, "contextMenuRemove");
            // 
            // removeFromFavoritesToolStripMenuItem
            // 
            this.removeFromFavoritesToolStripMenuItem.Name = "removeFromFavoritesToolStripMenuItem";
            resources.ApplyResources(this.removeFromFavoritesToolStripMenuItem, "removeFromFavoritesToolStripMenuItem");
            this.removeFromFavoritesToolStripMenuItem.Click += new System.EventHandler(this.removeFromFavoritesToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuRemove
            // 
            this.cancelToolStripMenuRemove.Name = "cancelToolStripMenuRemove";
            resources.ApplyResources(this.cancelToolStripMenuRemove, "cancelToolStripMenuRemove");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem,
            this.languageToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFavoriteToolStripMenuItem});
            resources.ApplyResources(this.countryToolStripMenuItem, "countryToolStripMenuItem");
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            // 
            // changeFavoriteToolStripMenuItem
            // 
            resources.ApplyResources(this.changeFavoriteToolStripMenuItem, "changeFavoriteToolStripMenuItem");
            this.changeFavoriteToolStripMenuItem.Name = "changeFavoriteToolStripMenuItem";
            this.changeFavoriteToolStripMenuItem.Click += new System.EventHandler(this.changeFavoriteToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.croatianToolStripMenuItem,
            this.englishToolStripMenuItem});
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // croatianToolStripMenuItem
            // 
            resources.ApplyResources(this.croatianToolStripMenuItem, "croatianToolStripMenuItem");
            this.croatianToolStripMenuItem.Name = "croatianToolStripMenuItem";
            this.croatianToolStripMenuItem.Click += new System.EventHandler(this.croatianToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // PlayerSelect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTeamStats);
            this.Controls.Add(this.flpPlayerFrameControl);
            this.Controls.Add(this.flpAllPlayers);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PlayerSelect";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerSelect_FormClosed);
            this.Load += new System.EventHandler(this.PlayerSelect_Load);
            this.contextMenuAdd.ResumeLayout(false);
            this.contextMenuRemove.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpAllPlayers;
        private System.Windows.Forms.FlowLayoutPanel flpPlayerFrameControl;
        private System.Windows.Forms.Button lblTeamStats;
        private System.Windows.Forms.ContextMenuStrip contextMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem setAsFavoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuRemove;
        private System.Windows.Forms.ToolStripMenuItem removeFromFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFavoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem croatianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}