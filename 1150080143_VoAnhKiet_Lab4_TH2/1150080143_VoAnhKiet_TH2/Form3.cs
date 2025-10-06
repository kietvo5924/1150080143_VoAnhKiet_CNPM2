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
    public partial class Form3 : Form
    {
        string strCon = @"Data Source=KIETVO\MSSQLSERVER01;Initial Catalog=Quanlybanhang;Integrated Security=True;Encrypt=False";
        SqlConnection sqlCon = null;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
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
                sqlCmd.CommandText = "select * from SinhVien";
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();
                lsvDanhSachSV.Items.Clear();

                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string hoTen = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    string queQuan = reader.GetString(4);
                    string maLop = reader.GetString(5);

                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(hoTen);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(ngaySinh);
                    lvi.SubItems.Add(queQuan);
                    lvi.SubItems.Add(maLop);

                    lsvDanhSachSV.Items.Add(lvi);
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

