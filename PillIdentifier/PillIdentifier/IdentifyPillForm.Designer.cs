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
            this.SuspendLayout();
            // 
            // imprintLabel
            // 
            this.imprintLabel.AutoSize = true;
            this.imprintLabel.Location = new System.Drawing.Point(59, 35);
            this.imprintLabel.Name = "imprintLabel";
            this.imprintLabel.Size = new System.Drawing.Size(40, 13);
            this.imprintLabel.TabIndex = 0;
            this.imprintLabel.Text = "imprint:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(59, 71);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(33, 13);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "color:";
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(59, 110);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(39, 13);
            this.shapeLabel.TabIndex = 0;
            this.shapeLabel.Text = "shape:";
            // 
            // drugNameLabel
            // 
            this.drugNameLabel.AutoSize = true;
            this.drugNameLabel.Location = new System.Drawing.Point(53, 149);
            this.drugNameLabel.Name = "drugNameLabel";
            this.drugNameLabel.Size = new System.Drawing.Size(60, 13);
            this.drugNameLabel.TabIndex = 0;
            this.drugNameLabel.Text = "drug name:";
            // 
            // drugStrengthLabel
            // 
            this.drugStrengthLabel.AutoSize = true;
            this.drugStrengthLabel.Location = new System.Drawing.Point(53, 187);
            this.drugStrengthLabel.Name = "drugStrengthLabel";
            this.drugStrengthLabel.Size = new System.Drawing.Size(72, 13);
            this.drugStrengthLabel.TabIndex = 0;
            this.drugStrengthLabel.Text = "drug strength:";
            // 
            // creationTimeLabel
            // 
            this.creationTimeLabel.AutoSize = true;
            this.creationTimeLabel.Location = new System.Drawing.Point(53, 227);
            this.creationTimeLabel.Name = "creationTimeLabel";
            this.creationTimeLabel.Size = new System.Drawing.Size(70, 13);
            this.creationTimeLabel.TabIndex = 0;
            this.creationTimeLabel.Text = "creation time:";
            // 
            // imprintTextBox
            // 
            this.imprintTextBox.Location = new System.Drawing.Point(181, 32);
            this.imprintTextBox.Name = "imprintTextBox";
            this.imprintTextBox.ReadOnly = true;
            this.imprintTextBox.Size = new System.Drawing.Size(100, 20);
            this.imprintTextBox.TabIndex = 1;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(181, 68);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.ReadOnly = true;
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 1;
            // 
            // shapeTextBox
            // 
            this.shapeTextBox.Location = new System.Drawing.Point(181, 103);
            this.shapeTextBox.Name = "shapeTextBox";
            this.shapeTextBox.ReadOnly = true;
            this.shapeTextBox.Size = new System.Drawing.Size(100, 20);
            this.shapeTextBox.TabIndex = 1;
            // 
            // drugNameTextBox
            // 
            this.drugNameTextBox.Location = new System.Drawing.Point(181, 146);
            this.drugNameTextBox.Name = "drugNameTextBox";
            this.drugNameTextBox.ReadOnly = true;
            this.drugNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.drugNameTextBox.TabIndex = 1;
            // 
            // drugStrengthTextBox
            // 
            this.drugStrengthTextBox.Location = new System.Drawing.Point(181, 184);
            this.drugStrengthTextBox.Name = "drugStrengthTextBox";
            this.drugStrengthTextBox.ReadOnly = true;
            this.drugStrengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.drugStrengthTextBox.TabIndex = 1;
            // 
            // creationTimeDateTimePicker
            // 
            this.creationTimeDateTimePicker.Location = new System.Drawing.Point(181, 219);
            this.creationTimeDateTimePicker.Name = "creationTimeDateTimePicker";
            this.creationTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.creationTimeDateTimePicker.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(306, 298);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // IdentifyPillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 333);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.creationTimeDateTimePicker);
            this.Controls.Add(this.drugStrengthTextBox);
            this.Controls.Add(this.drugNameTextBox);
            this.Controls.Add(this.shapeTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.imprintTextBox);
            this.Controls.Add(this.creationTimeLabel);
            this.Controls.Add(this.drugStrengthLabel);
            this.Controls.Add(this.drugNameLabel);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.imprintLabel);
            this.Name = "IdentifyPillForm";
            this.Text = "IdentifyPillForm";
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
    }
}