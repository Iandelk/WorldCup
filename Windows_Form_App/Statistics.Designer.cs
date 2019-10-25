namespace Windows_Form_App
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.flpAllPlayersStatistics = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMatchStatistics = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sortPlayersPerGoals = new System.Windows.Forms.Button();
            this.btn_SortPlayersByYellowCards = new System.Windows.Forms.Button();
            this.lblPlayerStatisticsTitle = new System.Windows.Forms.Label();
            this.lblMatchStatisticsTitle = new System.Windows.Forms.Label();
            this.btnPrintPlayer = new System.Windows.Forms.Button();
            this.btnPrintMatches = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentMatch = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogMatch = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // flpAllPlayersStatistics
            // 
            resources.ApplyResources(this.flpAllPlayersStatistics, "flpAllPlayersStatistics");
            this.flpAllPlayersStatistics.Name = "flpAllPlayersStatistics";
            // 
            // flpMatchStatistics
            // 
            resources.ApplyResources(this.flpMatchStatistics, "flpMatchStatistics");
            this.flpMatchStatistics.Name = "flpMatchStatistics";
            // 
            // btn_sortPlayersPerGoals
            // 
            resources.ApplyResources(this.btn_sortPlayersPerGoals, "btn_sortPlayersPerGoals");
            this.btn_sortPlayersPerGoals.Name = "btn_sortPlayersPerGoals";
            this.btn_sortPlayersPerGoals.UseVisualStyleBackColor = true;
            this.btn_sortPlayersPerGoals.Click += new System.EventHandler(this.btn_sortPlayersPerGoals_Click);
            // 
            // btn_SortPlayersByYellowCards
            // 
            resources.ApplyResources(this.btn_SortPlayersByYellowCards, "btn_SortPlayersByYellowCards");
            this.btn_SortPlayersByYellowCards.Name = "btn_SortPlayersByYellowCards";
            this.btn_SortPlayersByYellowCards.UseVisualStyleBackColor = true;
            this.btn_SortPlayersByYellowCards.Click += new System.EventHandler(this.btn_SortPlayersByYellowCards_Click);
            // 
            // lblPlayerStatisticsTitle
            // 
            resources.ApplyResources(this.lblPlayerStatisticsTitle, "lblPlayerStatisticsTitle");
            this.lblPlayerStatisticsTitle.Name = "lblPlayerStatisticsTitle";
            // 
            // lblMatchStatisticsTitle
            // 
            resources.ApplyResources(this.lblMatchStatisticsTitle, "lblMatchStatisticsTitle");
            this.lblMatchStatisticsTitle.Name = "lblMatchStatisticsTitle";
            // 
            // btnPrintPlayer
            // 
            resources.ApplyResources(this.btnPrintPlayer, "btnPrintPlayer");
            this.btnPrintPlayer.Name = "btnPrintPlayer";
            this.btnPrintPlayer.UseVisualStyleBackColor = true;
            this.btnPrintPlayer.Click += new System.EventHandler(this.btnPrintPlayer_Click);
            // 
            // btnPrintMatches
            // 
            resources.ApplyResources(this.btnPrintMatches, "btnPrintMatches");
            this.btnPrintMatches.Name = "btnPrintMatches";
            this.btnPrintMatches.UseVisualStyleBackColor = true;
            this.btnPrintMatches.Click += new System.EventHandler(this.btnPrintMatches_Click);
            // 
            // printDocument
            // 
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            resources.ApplyResources(this.printPreviewDialog, "printPreviewDialog");
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Name = "printPreviewDialog";
            // 
            // printDocumentMatch
            // 
            this.printDocumentMatch.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocumentMatch_EndPrint);
            this.printDocumentMatch.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentMatch_PrintPage);
            // 
            // printPreviewDialogMatch
            // 
            resources.ApplyResources(this.printPreviewDialogMatch, "printPreviewDialogMatch");
            this.printPreviewDialogMatch.Document = this.printDocumentMatch;
            this.printPreviewDialogMatch.Name = "printPreviewDialogMatch";
            // 
            // Statistics
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrintMatches);
            this.Controls.Add(this.btnPrintPlayer);
            this.Controls.Add(this.lblMatchStatisticsTitle);
            this.Controls.Add(this.lblPlayerStatisticsTitle);
            this.Controls.Add(this.btn_SortPlayersByYellowCards);
            this.Controls.Add(this.btn_sortPlayersPerGoals);
            this.Controls.Add(this.flpMatchStatistics);
            this.Controls.Add(this.flpAllPlayersStatistics);
            this.Name = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAllPlayersStatistics;
        private System.Windows.Forms.FlowLayoutPanel flpMatchStatistics;
        private System.Windows.Forms.Button btn_sortPlayersPerGoals;
        private System.Windows.Forms.Button btn_SortPlayersByYellowCards;
        private System.Windows.Forms.Label lblPlayerStatisticsTitle;
        private System.Windows.Forms.Label lblMatchStatisticsTitle;
        private System.Windows.Forms.Button btnPrintPlayer;
        private System.Windows.Forms.Button btnPrintMatches;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocumentMatch;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogMatch;
    }
}