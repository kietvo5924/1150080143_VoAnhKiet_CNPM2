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
    public partial class Form2 : Form
    {
        // Khai báo biến
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Downloads\Phương Pháp Phát Triển Phần Mềm\Buoi10\1150080143_VoAnhKiet_CNPM2\VoAnhKiet_1150080143_BTtuan10\VoAnhKiet_1150080143_BTtuan10\QuanLyBanSach.mdf"";Integrated Security=True";

        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        public Form2()
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

        // Sự kiện Form_Load (Chạy khi Form được tải lên)
        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            XoaDuLieuForm();
        }

        // Sự kiện Click của nút Thêm
        private void btnThemDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNXB.Text))
            {
                MessageBox.Show("Mã NXB không được để trống!");
                return;
            }

            try
            {
                DataRow row = ds.Tables["tblNhaXuatBan"].NewRow();

                row["MaNXB"] = txtMaNXB.Text.Trim();
                row["TenNXB"] = txtTenNXB.Text.Trim();
                row["DiaChi"] = txtDiaChi.Text.Trim();

                ds.Tables["tblNhaXuatBan"].Rows.Add(row);

                int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);

                if (kq > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    HienThiDuLieu();
                    XoaDuLieuForm();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
                HienThiDuLieu();
            }
        }
    }
}