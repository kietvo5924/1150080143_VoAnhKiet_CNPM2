using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VoAnhKiet_1150080143_BTtuan8
{
    public partial class ThucHanh4 : Form
    {
        public ThucHanh4()
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
        private void ThucHanh4_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNXB();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần xóa.", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà xuất bản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                MoKetNoi();
                string maNXB = lsvDanhSach.SelectedItems[0].SubItems[0].Text;

                SqlCommand sqlCmd = new SqlCommand("XoaNXB", sqlCon) { CommandType = CommandType.StoredProcedure };
                sqlCmd.Parameters.Add(new SqlParameter("@maNXB", maNXB));

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo");
                    HienThiDanhSachNXB();
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
        #endregion
    }
}