using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Xuất_hóa_đơn : Form
    {
        public Xuất_hóa_đơn()
        {
            InitializeComponent();
        }
        string[] s = new string[100];
        public void funData (TextBox a, TextBox b, Label c, TextBox tienhang, NumericUpDown discount, TextBox tongtien)
        {
            s[0] = a.Text + "₫";
            s[1] = b.Text;
            s[2] = c.Text;
            s[3] = tienhang.Text;
            s[4] = discount.Value.ToString() + "%";
            s[5] = tongtien.Text;
        }
        private void Xuất_hóa_đơn_Load(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=DESKTOP-L5O39OU;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionSTR);
            SqlDataAdapter da = new SqlDataAdapter("Select * from viewbill where TableName = N'"+s[2]+"'", con);
            PrintBill2 ds = new PrintBill2();
            da.Fill(ds, "Bill");

            ReportDataSource datasource = new ReportDataSource("DataSet3", ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pCash",s[0]),
                new Microsoft.Reporting.WinForms.ReportParameter("pChange",s[1]),
                new Microsoft.Reporting.WinForms.ReportParameter("pTienHang",s[3]),
                new Microsoft.Reporting.WinForms.ReportParameter("pDiscount", s[4]),
                new Microsoft.Reporting.WinForms.ReportParameter("pFinalPrice", s[5])
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //string connectionSTR = "Data Source=DESKTOP-L5O39OU;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        //    //SqlConnection con = new SqlConnection(connectionSTR);
        //    //SqlDataAdapter da = new SqlDataAdapter("Select * from viewbill where TableName = N'Bàn " + txbIdTable.Text + "'", con);
        //    //PrintBill2 ds = new PrintBill2();
        //    //da.Fill(ds, "Bill");

        //    //ReportDataSource datasource = new ReportDataSource("DataSet3", ds.Tables[0]);

        //    //this.reportViewer1.LocalReport.DataSources.Clear();
        //    //this.reportViewer1.LocalReport.DataSources.Add(datasource);
        //    //this.reportViewer1.RefreshReport();
        //    //Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
        //    //{
        //    //    new Microsoft.Reporting.WinForms.ReportParameter("pCash",s[0]),
        //    //    new Microsoft.Reporting.WinForms.ReportParameter("pChange",s[1])
        //    //};
        //    //this.reportViewer1.LocalReport.SetParameters(para);
        //    //this.reportViewer1.RefreshReport();
        //}
    }
}
