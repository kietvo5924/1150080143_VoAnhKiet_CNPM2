using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VoAnhKiet_1150080143_BTtuan8
{
    // SỬA LỖI 1: Đổi tên class thành ThucHanh1
    public partial class ThucHanh1 : Form
    {
        public ThucHanh1()
        {
            InitializeComponent();
        }

        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Downloads\Phương Pháp Phát Triển Phần Mềm\Buoi8\1150080143_VoAnhKiet_CNPM2\VoAnhKiet_1150080143_BTtuan8\VoAnhKiet_1150080143_BTtuan8\QuanLyBanSach.mdf"";Integrated Security=True";
        SqlConnection sqlCon = null;

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

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        private void ThucHanh1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNXB();
        }

        private void HienThiDanhSachNXB()
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "HienThiNXB";
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();
                lsvDanhSach.Items.Clear();
                while (reader.Read())
                {
                    string maNXB = reader.GetString(0);
                    string tenNXB = reader.GetString(1);
                    string diaChi = reader.GetString(2);

                    ListViewItem lvi = new ListViewItem(maNXB);
                    lvi.SubItems.Add(tenNXB);
                    lvi.SubItems.Add(diaChi);

                    lsvDanhSach.Items.Add(lvi);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            string maNXB = lvi.SubItems[0].Text;
            HienThiThongTinNXBTheoMa(maNXB);
        }

        private void HienThiThongTinNXBTheoMa(string maNXB)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "HienThiChiTietNXB";
                sqlCmd.Connection = sqlCon;

                SqlParameter parMaNXB = new SqlParameter("@maNXB", SqlDbType.Char);
                parMaNXB.Value = maNXB;
                sqlCmd.Parameters.Add(parMaNXB);

                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMaNXB.Text = reader.GetString(0);
                    txtTenNXB.Text = reader.GetString(1);
                    txtDiaChi.Text = reader.GetString(2);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị chi tiết: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
    }
}