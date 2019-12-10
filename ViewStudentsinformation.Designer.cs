namespace SEPCW2
{
    partial class ViewStudentsinformation
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
            this.dgvViewStudentsInformation = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbReportInformation = new System.Windows.Forms.ComboBox();
            this.lblReportInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudentsInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewStudentsInformation
            // 
            this.dgvViewStudentsInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudentsInformation.Location = new System.Drawing.Point(54, 131);
            this.dgvViewStudentsInformation.Name = "dgvViewStudentsInformation";
            this.dgvViewStudentsInformation.RowTemplate.Height = 23;
            this.dgvViewStudentsInformation.Size = new System.Drawing.Size(577, 354);
            this.dgvViewStudentsInformation.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(54, 546);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(556, 546);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // cmbReportInformation
            // 
            this.cmbReportInformation.AutoCompleteCustomSource.AddRange(new string[] {
            "All Report send from your children"});
            this.cmbReportInformation.FormattingEnabled = true;
            this.cmbReportInformation.Items.AddRange(new object[] {
            "All information send form my children"});
            this.cmbReportInformation.Location = new System.Drawing.Point(243, 64);
            this.cmbReportInformation.Name = "cmbReportInformation";
            this.cmbReportInformation.Size = new System.Drawing.Size(388, 20);
            this.cmbReportInformation.TabIndex = 3;
            this.cmbReportInformation.TextChanged += new System.EventHandler(this.CmbReportInformation_TextChanged);
            // 
            // lblReportInformation
            // 
            this.lblReportInformation.AutoSize = true;
            this.lblReportInformation.Location = new System.Drawing.Point(52, 64);
            this.lblReportInformation.Name = "lblReportInformation";
            this.lblReportInformation.Size = new System.Drawing.Size(113, 12);
            this.lblReportInformation.TabIndex = 4;
            this.lblReportInformation.Text = "Report Information";
            // 
            // ViewStudentsinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 605);
            this.Controls.Add(this.lblReportInformation);
            this.Controls.Add(this.cmbReportInformation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvViewStudentsInformation);
            this.Name = "ViewStudentsinformation";
            this.Text = "ViewStudentsinformation";
            this.Load += new System.EventHandler(this.ViewStudentsinformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudentsInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewStudentsInformation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbReportInformation;
        private System.Windows.Forms.Label lblReportInformation;
    }
}