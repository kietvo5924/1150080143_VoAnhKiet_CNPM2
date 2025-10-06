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
    public partial class Form4 : Form
    {
        string strCon = @"Data Source=KIETVO\MSSQLSERVER01;Initial Catalog=Quanlybanhang;Integrated Security=True;Encrypt=False";
        SqlConnection sqlCon = null;

        public Form4()
        {
            InitializeComponent();
        }

        private void btnXemDSLop_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null) { sqlCon = new SqlConnection(strCon); }
                if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }

                lsvLop.Items.Clear();

                string tenKhoa = txtTenKhoa.Text.Trim();
                if (string.IsNullOrEmpty(tenKhoa))
                {
                    MessageBox.Show("Vui lòng nhập tên khoa!");
                    return;
                }

                string maKhoa = "";
                if (tenKhoa == "Công nghệ thông tin")
                {
                    maKhoa = "CNTT";
                }
                else if (tenKhoa == "Cơ khí")
                {
                    maKhoa = "CK";
                }
                else if (tenKhoa == "Điện tử")
                {
                    maKhoa = "DT";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khoa này!");
                    return;
                }

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from Lop where MaKhoa = @maKhoa";

                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", SqlDbType.Char);
                parMaKhoa.Value = maKhoa;
                sqlCmd.Parameters.Add(parMaKhoa);
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string maLop = reader.GetString(0);
                    string tenLop = reader.GetString(1);

                    ListViewItem lvi = new ListViewItem(maLop);
                    lvi.SubItems.Add(tenLop);

                    lsvLop.Items.Add(lvi);
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
