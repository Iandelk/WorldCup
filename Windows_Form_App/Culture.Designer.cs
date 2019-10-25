namespace Windows_Form_App
{
    partial class Culture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Culture));
            this.lblChooseLanguage = new System.Windows.Forms.Label();
            this.btnPickLanguage = new System.Windows.Forms.Button();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblChooseLanguage
            // 
            resources.ApplyResources(this.lblChooseLanguage, "lblChooseLanguage");
            this.lblChooseLanguage.Name = "lblChooseLanguage";
            // 
            // btnPickLanguage
            // 
            resources.ApplyResources(this.btnPickLanguage, "btnPickLanguage");
            this.btnPickLanguage.Name = "btnPickLanguage";
            this.btnPickLanguage.UseVisualStyleBackColor = true;
            this.btnPickLanguage.Click += new System.EventHandler(this.btnPickLanguage_Click);
            // 
            // cbLanguage
            // 
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Name = "cbLanguage";
            // 
            // Culture
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChooseLanguage);
            this.Controls.Add(this.btnPickLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Culture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Culture_FormClosed);
            this.Load += new System.EventHandler(this.Culture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseLanguage;
        private System.Windows.Forms.Button btnPickLanguage;
        private System.Windows.Forms.ComboBox cbLanguage;
    }
}