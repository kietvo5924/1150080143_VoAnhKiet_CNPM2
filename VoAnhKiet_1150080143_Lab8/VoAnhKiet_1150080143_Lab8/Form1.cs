using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;  // Dòng này sẽ hết lỗi sau khi làm Bước 1
using Microsoft.SqlServer.Types;       // Dòng này sẽ hết lỗi sau khi làm Bước 1

namespace VoAnhKiet_1150080143_Lab8
{
    public partial class Form1 : Form
    {
        // Sử dụng đường dẫn CSDL chính xác từ project Lab8 của bạn
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Downloads\Phương Pháp Phát Triển Phần Mềm\Buoi10\1150080143_VoAnhKiet_CNPM2\VoAnhKiet_1150080143_Lab8\VoAnhKiet_1150080143_Lab8\QuanLySinhVien.mdf"";Integrated Security=True";

        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();

            // Dòng này sẽ hết lỗi sau khi làm Bước 1
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void MoKetNoi()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();
                string query = "select * from SinhVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "SinhVien");

                this.reportViewer1.LocalReport.DataSources.Clear();

                this.reportViewer1.LocalReport.ReportEmbeddedResource =
                    "VoAnhKiet_1150080143_Lab8.rptSinhVien.rdlc";

                // Dòng này sẽ hết lỗi sau khi làm Bước 1
                ReportDataSource rds = new ReportDataSource();

                rds.Name = "ds1"; // Tên này phải trùng với tên DataSet trong file .rdlc

                rds.Value = ds.Tables["SinhVien"];

                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}