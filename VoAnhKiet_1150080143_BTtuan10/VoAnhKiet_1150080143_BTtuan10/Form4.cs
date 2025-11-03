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
    public partial class Form4 : Form
    {
        // Khai báo biến
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Downloads\Phương Pháp Phát Triển Phần Mềm\Buoi10\1150080143_VoAnhKiet_CNPM2\VoAnhKiet_1150080143_BTtuan10\VoAnhKiet_1150080143_BTtuan10\QuanLyBanSach.mdf"";Integrated Security=True";

        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        int vt = -1;

        public Form4()
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

        // Hàm thực thi Xóa dữ liệu
        private void XoaDuLieu()
        {
            try
            {
                DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];

                row.Delete();

                int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                HienThiDuLieu();
            }
        }

        // Sự kiện Form_Load
        private void Form4_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        // Sự kiện CellClick trên DataGridView
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
        }

        // Sự kiện Click của nút Xóa
        private void btnXoaDuLieu_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa hay không?",
                                                  "Cảnh báo",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                XoaDuLieu();
                HienThiDuLieu();
                vt = -1;
            }
        }
    }
}