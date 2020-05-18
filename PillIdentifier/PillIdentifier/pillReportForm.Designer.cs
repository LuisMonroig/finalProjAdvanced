namespace PillIdentifier
{
    partial class PillReportForm
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
            this.pillDataGridView = new System.Windows.Forms.DataGridView();
            this.imprintColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugStrengthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pillPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pillDataGridView
            // 
            this.pillDataGridView.AllowUserToDeleteRows = false;
            this.pillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pillDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imprintColumn,
            this.colorColumn,
            this.shapeColumn,
            this.drugNameColumn,
            this.drugStrengthColumn,
            this.pillPhoto,
            this.creationTimeColumn});
            this.pillDataGridView.Location = new System.Drawing.Point(13, 13);
            this.pillDataGridView.Name = "pillDataGridView";
            this.pillDataGridView.ReadOnly = true;
            this.pillDataGridView.Size = new System.Drawing.Size(744, 382);
            this.pillDataGridView.TabIndex = 0;
            // 
            // imprintColumn
            // 
            this.imprintColumn.HeaderText = "Imprint";
            this.imprintColumn.Name = "imprintColumn";
            this.imprintColumn.ReadOnly = true;
            // 
            // colorColumn
            // 
            this.colorColumn.HeaderText = "Color";
            this.colorColumn.Name = "colorColumn";
            this.colorColumn.ReadOnly = true;
            // 
            // shapeColumn
            // 
            this.shapeColumn.HeaderText = "Shape";
            this.shapeColumn.Name = "shapeColumn";
            this.shapeColumn.ReadOnly = true;
            // 
            // drugNameColumn
            // 
            this.drugNameColumn.HeaderText = "Drug Name";
            this.drugNameColumn.Name = "drugNameColumn";
            this.drugNameColumn.ReadOnly = true;
            // 
            // drugStrengthColumn
            // 
            this.drugStrengthColumn.HeaderText = "Drug Strength";
            this.drugStrengthColumn.Name = "drugStrengthColumn";
            this.drugStrengthColumn.ReadOnly = true;
            // 
            // pillPhoto
            // 
            this.pillPhoto.HeaderText = "Photo";
            this.pillPhoto.Name = "pillPhoto";
            this.pillPhoto.ReadOnly = true;
            // 
            // creationTimeColumn
            // 
            this.creationTimeColumn.HeaderText = "Creation Time";
            this.creationTimeColumn.Name = "creationTimeColumn";
            this.creationTimeColumn.ReadOnly = true;
            // 
            // PillReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 407);
            this.Controls.Add(this.pillDataGridView);
            this.Name = "PillReportForm";
            this.Text = "pillReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pillReportForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pillDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pillDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn imprintColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugStrengthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pillPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationTimeColumn;
    }
}