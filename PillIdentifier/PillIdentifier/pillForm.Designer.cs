namespace PillIdentifier
{
    partial class PillForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdentifyPillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pillReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPillToolStripMenuItem,
            this.modifyPillToolStripMenuItem,
            this.IdentifyPillToolStripMenuItem,
            this.pillReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addPillToolStripMenuItem
            // 
            this.addPillToolStripMenuItem.Name = "addPillToolStripMenuItem";
            this.addPillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPillToolStripMenuItem.Text = "Add Pill";
            this.addPillToolStripMenuItem.Click += new System.EventHandler(this.addPillToolStripMenuItem_Click);
            // 
            // modifyPillToolStripMenuItem
            // 
            this.modifyPillToolStripMenuItem.Name = "modifyPillToolStripMenuItem";
            this.modifyPillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyPillToolStripMenuItem.Text = "Modify Pill";
            this.modifyPillToolStripMenuItem.Click += new System.EventHandler(this.modifyPillToolStripMenuItem_Click);
            // 
            // IdentifyPillToolStripMenuItem
            // 
            this.IdentifyPillToolStripMenuItem.Name = "IdentifyPillToolStripMenuItem";
            this.IdentifyPillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.IdentifyPillToolStripMenuItem.Text = "Pill Identifier";
            this.IdentifyPillToolStripMenuItem.Click += new System.EventHandler(this.IdentifyPillToolStripMenuItem_Click);
            // 
            // pillReportToolStripMenuItem
            // 
            this.pillReportToolStripMenuItem.Name = "pillReportToolStripMenuItem";
            this.pillReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pillReportToolStripMenuItem.Text = "Pill Report";
            this.pillReportToolStripMenuItem.Click += new System.EventHandler(this.pillReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpContentsToolStripMenuItem
            // 
            this.helpContentsToolStripMenuItem.Name = "helpContentsToolStripMenuItem";
            this.helpContentsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.helpContentsToolStripMenuItem.Text = "Help Contents";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PillForm";
            this.Text = "pillForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PillForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IdentifyPillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pillReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}