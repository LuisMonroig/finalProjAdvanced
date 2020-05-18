namespace PillIdentifier
{
    partial class ModifyPillForm
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
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.drugNameTextBox = new System.Windows.Forms.TextBox();
            this.drugStrengthTextBox = new System.Windows.Forms.TextBox();
            this.creationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imprintLabel
            // 
            this.imprintLabel.AutoSize = true;
            this.imprintLabel.Location = new System.Drawing.Point(82, 39);
            this.imprintLabel.Name = "imprintLabel";
            this.imprintLabel.Size = new System.Drawing.Size(40, 13);
            this.imprintLabel.TabIndex = 0;
            this.imprintLabel.Text = "imprint:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(88, 74);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(33, 13);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "color:";
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(82, 111);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(39, 13);
            this.shapeLabel.TabIndex = 0;
            this.shapeLabel.Text = "shape:";
            // 
            // drugNameLabel
            // 
            this.drugNameLabel.AutoSize = true;
            this.drugNameLabel.Location = new System.Drawing.Point(61, 151);
            this.drugNameLabel.Name = "drugNameLabel";
            this.drugNameLabel.Size = new System.Drawing.Size(60, 13);
            this.drugNameLabel.TabIndex = 1;
            this.drugNameLabel.Text = "drug name:";
            // 
            // drugStrengthLabel
            // 
            this.drugStrengthLabel.AutoSize = true;
            this.drugStrengthLabel.Location = new System.Drawing.Point(49, 192);
            this.drugStrengthLabel.Name = "drugStrengthLabel";
            this.drugStrengthLabel.Size = new System.Drawing.Size(72, 13);
            this.drugStrengthLabel.TabIndex = 2;
            this.drugStrengthLabel.Text = "drug strength:";
            // 
            // creationTimeLabel
            // 
            this.creationTimeLabel.AutoSize = true;
            this.creationTimeLabel.Location = new System.Drawing.Point(51, 234);
            this.creationTimeLabel.Name = "creationTimeLabel";
            this.creationTimeLabel.Size = new System.Drawing.Size(70, 13);
            this.creationTimeLabel.TabIndex = 3;
            this.creationTimeLabel.Text = "creation time:";
            // 
            // imprintTextBox
            // 
            this.imprintTextBox.Location = new System.Drawing.Point(127, 39);
            this.imprintTextBox.Name = "imprintTextBox";
            this.imprintTextBox.Size = new System.Drawing.Size(100, 20);
            this.imprintTextBox.TabIndex = 4;
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(127, 74);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 5;
            // 
            // shapeComboBox
            // 
            this.shapeComboBox.FormattingEnabled = true;
            this.shapeComboBox.Location = new System.Drawing.Point(127, 111);
            this.shapeComboBox.Name = "shapeComboBox";
            this.shapeComboBox.Size = new System.Drawing.Size(121, 21);
            this.shapeComboBox.TabIndex = 6;
            // 
            // drugNameTextBox
            // 
            this.drugNameTextBox.Location = new System.Drawing.Point(127, 151);
            this.drugNameTextBox.Name = "drugNameTextBox";
            this.drugNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.drugNameTextBox.TabIndex = 7;
            // 
            // drugStrengthTextBox
            // 
            this.drugStrengthTextBox.Location = new System.Drawing.Point(127, 192);
            this.drugStrengthTextBox.Name = "drugStrengthTextBox";
            this.drugStrengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.drugStrengthTextBox.TabIndex = 8;
            // 
            // creationTimeDateTimePicker
            // 
            this.creationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.creationTimeDateTimePicker.Location = new System.Drawing.Point(127, 234);
            this.creationTimeDateTimePicker.Name = "creationTimeDateTimePicker";
            this.creationTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.creationTimeDateTimePicker.TabIndex = 9;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(286, 305);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 10;
            this.enterButton.Text = "enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // ModifyPillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 340);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.creationTimeDateTimePicker);
            this.Controls.Add(this.drugStrengthTextBox);
            this.Controls.Add(this.drugNameTextBox);
            this.Controls.Add(this.shapeComboBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.imprintTextBox);
            this.Controls.Add(this.creationTimeLabel);
            this.Controls.Add(this.drugStrengthLabel);
            this.Controls.Add(this.drugNameLabel);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.imprintLabel);
            this.Name = "ModifyPillForm";
            this.Text = "modifyPillForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.modifyPillForm_FormClosing);
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
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox shapeComboBox;
        private System.Windows.Forms.TextBox drugNameTextBox;
        private System.Windows.Forms.TextBox drugStrengthTextBox;
        private System.Windows.Forms.DateTimePicker creationTimeDateTimePicker;
        private System.Windows.Forms.Button enterButton;
    }
}