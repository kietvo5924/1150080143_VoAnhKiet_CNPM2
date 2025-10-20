using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VoAnhKiet_1150080143_BTtuan8
{
    public partial class ThucHanh3 : Form
    {
        public ThucHanh3()
        {
            InitializeComponent();
        }

        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Downloads\Phương Pháp Phát Triển Phần Mềm\Buoi8\1150080143_VoAnhKiet_CNPM2\VoAnhKiet_1150080143_BTtuan8\VoAnhKiet_1150080143_BTtuan8\QuanLyBanSach.mdf"";Integrated Security=True";

        SqlConnection sqlCon = null;

        #region "Connection & Display Methods"
        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open) sqlCon.Close();
        }

        private void HienThiDanhSachNXB()
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand("HienThiNXB", sqlCon) { CommandType = CommandType.StoredProcedure };

                SqlDataReader reader = sqlCmd.ExecuteReader();
                lsvDanhSach.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetString(0));
                    lvi.SubItems.Add(reader.GetString(1));
                    lvi.SubItems.Add(reader.GetString(2));
                    lsvDanhSach.Items.Add(lvi);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
        #endregion

        #region "Form Events"
        private void ThucHanh3_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNXB();
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            txtMaNXB.Text = lvi.SubItems[0].Text;
            txtTenNXB.Text = lvi.SubItems[1].Text;
            txtDiaChi.Text = lvi.SubItems[2].Text;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNXB.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhà xuất bản để cập nhật.", "Thông báo");
                return;
            }

            try
            {
                MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand("CapNhatThongTin", sqlCon) { CommandType = CommandType.StoredProcedure };

                sqlCmd.Parameters.Add(new SqlParameter("@maNXB", txtMaNXB.Text.Trim()));
                sqlCmd.Parameters.Add(new SqlParameter("@tenNXB", txtTenNXB.Text.Trim()));
                sqlCmd.Parameters.Add(new SqlParameter("@diaChi", txtDiaChi.Text.Trim()));

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
                    HienThiDanhSachNXB();
                    txtMaNXB.Text = txtTenNXB.Text = txtDiaChi.Text = "";
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
        #endregion
    }
}