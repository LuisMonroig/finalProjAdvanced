namespace PillIdentifier
{
    partial class searchPillForm
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
            this.pillImprintLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pillImprintTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pillImprintLabel
            // 
            this.pillImprintLabel.AutoSize = true;
            this.pillImprintLabel.Location = new System.Drawing.Point(8, 26);
            this.pillImprintLabel.Name = "pillImprintLabel";
            this.pillImprintLabel.Size = new System.Drawing.Size(57, 13);
            this.pillImprintLabel.TabIndex = 0;
            this.pillImprintLabel.Text = "Pill Imprint:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pillImprintTextBox
            // 
            this.pillImprintTextBox.Location = new System.Drawing.Point(71, 23);
            this.pillImprintTextBox.Name = "pillImprintTextBox";
            this.pillImprintTextBox.Size = new System.Drawing.Size(252, 20);
            this.pillImprintTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(248, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchPillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 94);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pillImprintTextBox);
            this.Controls.Add(this.pillImprintLabel);
            this.Name = "searchPillForm";
            this.Text = "searchPillForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pillImprintLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox pillImprintTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}