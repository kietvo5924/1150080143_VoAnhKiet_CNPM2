using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Thêm thư viện này
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoAnhKiet_1150080143_BTtuan10
{
    public partial class Form3 : Form
    {
        // Khai báo biến
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Downloads\Phương Pháp Phát Triển Phần Mềm\Buoi10\1150080143_VoAnhKiet_CNPM2\VoAnhKiet_1150080143_BTtuan10\VoAnhKiet_1150080143_BTtuan10\QuanLyBanSach.mdf"";Integrated Security=True";

        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        int vt = -1;

        public Form3()
        {
            InitializeComponent();
        }

        // Hàm mở kết nối
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

        // Hàm đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        // Hàm xóa dữ liệu trên các control
        private void XoaDuLieuForm()
        {
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtMaNXB.Focus();
            vt = -1;
        }

        // Hàm hiển thị dữ liệu lên DataGridView
        private void HienThiDuLieu()
        {
            try
            {
                MoKetNoi();

                string query = "select * from NhaXuatBan";

                adapter = new SqlDataAdapter(query, sqlCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                adapter.Fill(ds, "tblNhaXuatBan");

                dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        // Sự kiện Form_Load
        private void Form3_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            XoaDuLieuForm();
        }

        // Sự kiện CellClick trên DataGridView
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;

            if (vt == -1) return;

            // Lấy dòng dữ liệu đang chọn
            DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];

            txtMaNXB.Text = row["MaNXB"].ToString().Trim();
            txtTenNXB.Text = row["TenNXB"].ToString().Trim();
            txtDiaChi.Text = row["DiaChi"].ToString().Trim();
        }

        // 8. Sự kiện Click của nút Chỉnh sửa
        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để chỉnh sửa!");
                return;
            }

            try
            {
                DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];

                row.BeginEdit();
                row["MaNXB"] = txtMaNXB.Text.Trim();
                row["TenNXB"] = txtTenNXB.Text.Trim();
                row["DiaChi"] = txtDiaChi.Text.Trim();

                row.EndEdit();
                int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);

                if (kq > 0)
                {
                    MessageBox.Show("Chỉnh sửa dữ liệu thành công!");
                    HienThiDuLieu(); 
                    XoaDuLieuForm();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa dữ liệu không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                HienThiDuLieu();
            }
        }
    }
}