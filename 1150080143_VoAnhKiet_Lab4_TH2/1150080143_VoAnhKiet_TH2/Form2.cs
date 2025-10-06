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

namespace _1150080143_VoAnhKiet_TH2
{
    public partial class Form2 : Form
    {
        string strCon = @"Data Source=KIETVO\MSSQLSERVER01;Initial Catalog=Quanlybanhang;Integrated Security=True;Encrypt=False";
        SqlConnection sqlCon = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
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

                string maSV = txtNhapMaSV.Text.Trim();
                if (string.IsNullOrEmpty(maSV))
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên!");
                    return;
                }

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandText = "select * from SinhVien where MaSV='" + maSV + "'";
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();

                if (reader.Read())
                {
                    txtTenSV.Text = reader.GetString(1);
                    txtGioiTinh.Text = reader.GetString(2); 
                    txtNgaySinh.Text = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    txtQueQuan.Text = reader.GetString(4);
                    txtMaLop.Text = reader.GetString(5);  
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã: " + maSV);
                    txtTenSV.Text = "";
                    txtGioiTinh.Text = "";
                    txtNgaySinh.Text = "";
                    txtQueQuan.Text = "";
                    txtMaLop.Text = "";
                }

                reader.Close();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
