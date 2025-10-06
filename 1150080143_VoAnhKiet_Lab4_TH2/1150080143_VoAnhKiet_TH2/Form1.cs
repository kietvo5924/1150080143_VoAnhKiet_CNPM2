using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thư viện để làm việc với SQL Server

namespace _1150080143_VoAnhKiet_TH2
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=KIETVO\MSSQLSERVER01;Initial Catalog=Quanlybanhang;Integrated Security=True;Encrypt=False";
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDemSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select COUNT(*) from SinhVien";
                sqlCmd.Connection = sqlCon;

                int soLuongSV = (int)sqlCmd.ExecuteScalar();
                MessageBox.Show("Tổng số sinh viên hiện có là: " + soLuongSV);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}