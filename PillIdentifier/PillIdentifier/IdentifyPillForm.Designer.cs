namespace PillIdentifier
{
    partial class IdentifyPillForm
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
            this.imprintLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.drugNameLabel = new System.Windows.Forms.Label();
            this.drugStrengthLabel = new System.Windows.Forms.Label();
            this.creationTimeLabel = new System.Windows.Forms.Label();
            this.imprintTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.shapeTextBox = new System.Windows.Forms.TextBox();
            this.drugNameTextBox = new System.Windows.Forms.TextBox();
            this.drugStrengthTextBox = new System.Windows.Forms.TextBox();
            this.creationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.closeButton = new System.Windows.Forms.Button();
            this.imageLabel = new System.Windows.Forms.Label();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imprintLabel
            // 
            this.imprintLabel.AutoSize = true;
            this.imprintLabel.Location = new System.Drawing.Point(56, 26);
            this.imprintLabel.Name = "imprintLabel";
            this.imprintLabel.Size = new System.Drawing.Size(40, 13);
            this.imprintLabel.TabIndex = 0;
            this.imprintLabel.Text = "imprint:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(63, 66);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(33, 13);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "color:";
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(57, 106);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(39, 13);
            this.shapeLabel.TabIndex = 0;
            this.shapeLabel.Text = "shape:";
            // 
            // drugNameLabel
            // 
            this.drugNameLabel.AutoSize = true;
            this.drugNameLabel.Location = new System.Drawing.Point(36, 146);
            this.drugNameLabel.Name = "drugNameLabel";
            this.drugNameLabel.Size = new System.Drawing.Size(60, 13);
            this.drugNameLabel.TabIndex = 0;
            this.drugNameLabel.Text = "drug name:";
            // 
            // drugStrengthLabel
            // 
            this.drugStrengthLabel.AutoSize = true;
            this.drugStrengthLabel.Location = new System.Drawing.Point(24, 186);
            this.drugStrengthLabel.Name = "drugStrengthLabel";
            this.drugStrengthLabel.Size = new System.Drawing.Size(72, 13);
            this.drugStrengthLabel.TabIndex = 0;
            this.drugStrengthLabel.Text = "drug strength:";
            // 
            // creationTimeLabel
            // 
            this.creationTimeLabel.AutoSize = true;
            this.creationTimeLabel.Location = new System.Drawing.Point(26, 226);
            this.creationTimeLabel.Name = "creationTimeLabel";
            this.creationTimeLabel.Size = new System.Drawing.Size(70, 13);
            this.creationTimeLabel.TabIndex = 0;
            this.creationTimeLabel.Text = "creation time:";
            // 
            // imprintTextBox
            // 
            this.imprintTextBox.Location = new System.Drawing.Point(109, 26);
            this.imprintTextBox.MaxLength = 15;
            this.imprintTextBox.Name = "imprintTextBox";
            this.imprintTextBox.ReadOnly = true;
            this.imprintTextBox.Size = new System.Drawing.Size(100, 20);
            this.imprintTextBox.TabIndex = 1;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(109, 66);
            this.colorTextBox.MaxLength = 15;
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.ReadOnly = true;
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 1;
            // 
            // shapeTextBox
            // 
            this.shapeTextBox.Location = new System.Drawing.Point(109, 106);
            this.shapeTextBox.MaxLength = 15;
            this.shapeTextBox.Name = "shapeTextBox";
            this.shapeTextBox.ReadOnly = true;
            this.shapeTextBox.Size = new System.Drawing.Size(100, 20);
            this.shapeTextBox.TabIndex = 1;
            // 
            // drugNameTextBox
            // 
            this.drugNameTextBox.Location = new System.Drawing.Point(109, 146);
            this.drugNameTextBox.MaxLength = 75;
            this.drugNameTextBox.Name = "drugNameTextBox";
            this.drugNameTextBox.ReadOnly = true;
            this.drugNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.drugNameTextBox.TabIndex = 1;
            // 
            // drugStrengthTextBox
            // 
            this.drugStrengthTextBox.Location = new System.Drawing.Point(109, 186);
            this.drugStrengthTextBox.MaxLength = 75;
            this.drugStrengthTextBox.Name = "drugStrengthTextBox";
            this.drugStrengthTextBox.ReadOnly = true;
            this.drugStrengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.drugStrengthTextBox.TabIndex = 1;
            // 
            // creationTimeDateTimePicker
            // 
            this.creationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.creationTimeDateTimePicker.Location = new System.Drawing.Point(109, 226);
            this.creationTimeDateTimePicker.Name = "creationTimeDateTimePicker";
            this.creationTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.creationTimeDateTimePicker.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(341, 306);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(58, 266);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(38, 13);
            this.imageLabel.TabIndex = 0;
            this.imageLabel.Text = "image:";
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(109, 266);
            this.imageTextBox.MaxLength = 50;
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.ReadOnly = true;
            this.imageTextBox.Size = new System.Drawing.Size(226, 20);
            this.imageTextBox.TabIndex = 4;
            // 
            // IdentifyPillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 356);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.creationTimeDateTimePicker);
            this.Controls.Add(this.drugStrengthTextBox);
            this.Controls.Add(this.drugNameTextBox);
            this.Controls.Add(this.shapeTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.imprintTextBox);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.creationTimeLabel);
            this.Controls.Add(this.drugStrengthLabel);
            this.Controls.Add(this.drugNameLabel);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.imprintLabel);
            this.Name = "IdentifyPillForm";
            this.Text = "Identify Pill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imprintLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.Label drugNameLabel;
        private System.Windows.Forms.Label drugStrengthLabel;
        private System.Windows.Forms.Label creationTimeLabel;
        private System.Windows.Forms.TextBox imprintTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox shapeTextBox;
        private System.Windows.Forms.TextBox drugNameTextBox;
        private System.Windows.Forms.TextBox drugStrengthTextBox;
        private System.Windows.Forms.DateTimePicker creationTimeDateTimePicker;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.TextBox imageTextBox;
    }
}