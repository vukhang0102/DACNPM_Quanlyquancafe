namespace QuanLyQuanCafe
{
    partial class Xuất_hóa_đơn
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrintBill = new QuanLyQuanCafe.PrintBill();
            this.BillInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.FoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodBindingSource
            // 
            this.FoodBindingSource.DataMember = "Food";
            this.FoodBindingSource.DataSource = this.PrintBill;
            // 
            // PrintBill
            // 
            this.PrintBill.DataSetName = "PrintBill";
            this.PrintBill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BillInfoBindingSource
            // 
            this.BillInfoBindingSource.DataMember = "BillInfo";
            this.BillInfoBindingSource.DataSource = this.PrintBill;
            // 
            // BillBindingSource
            // 
            this.BillBindingSource.DataMember = "Bill";
            this.BillBindingSource.DataSource = this.PrintBill;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.FoodBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.BillInfoBindingSource;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.BillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCafe.Hóa đơn.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1224, 556);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Xuất_hóa_đơn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 556);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Xuất_hóa_đơn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất_hóa_đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Xuất_hóa_đơn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FoodBindingSource;
        private PrintBill PrintBill;
        private System.Windows.Forms.BindingSource BillInfoBindingSource;
        private System.Windows.Forms.BindingSource BillBindingSource;
    }
}