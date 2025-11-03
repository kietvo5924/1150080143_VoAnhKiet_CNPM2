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

namespace VoAnhKiet_1150080143_Phan4
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Downloads\Phương Pháp Phát Triển Phần Mềm\Buoi10\1150080143_VoAnhKiet_CNPM2\VoAnhKiet_1150080143_Phan4\VoAnhKiet_1150080143_Phan4\QLBanHang.mdf"";Integrated Security=True";

            LoadDuLieu("Select * from tblMatHang");
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            HienChiTiet(false);
        }

        private void LoadDuLieu(String sql)
        {
            try
            {
                ds = new DataSet();
                dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvKetQua.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message + "\n" + con.ConnectionString);
            }
        }

        private void HienChiTiet(Boolean hien)
        {
            txtMaSP.Enabled = hien;
            txtTenSP.Enabled = hien;
            dtpNgayHH.Enabled = hien;
            dtpNgaySX.Enabled = hien;
            txtDonVi.Enabled = hien;
            txtDonGia.Enabled = hien;
            txtGhiChu.Enabled = hien;
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }

        private void XoaTrangChiTiet()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            dtpNgaySX.Value = DateTime.Now;
            dtpNgayHH.Value = DateTime.Now;
            txtDonVi.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";
            txtMaSP.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "TÌM KIẾM MẶT HÀNG";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            String sql = "SELECT * FROM tblMatHang";
            String dk = "";
            if (txtTKMaSP.Text.Trim() != "")
            {
                dk += " MaSP like '%" + txtTKMaSP.Text + "%'";
            }
            if (txtTKTenSP.Text.Trim() != "" && dk != "")
            {
                dk += " AND TenSP like N'%" + txtTKTenSP.Text + "%'";
            }
            if (txtTKTenSP.Text.Trim() != "" && dk == "")
            {
                dk += " TenSP like N'%" + txtTKTenSP.Text + "%'";
            }
            if (dk != "")
            {
                sql += " WHERE" + dk;
            }
            LoadDuLieu(sql);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "THÊM MẶT HÀNG";
            XoaTrangChiTiet();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            HienChiTiet(true);
        }

        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            try
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    txtMaSP.Text = dgvKetQua[0, rowIndex].Value.ToString();
                    txtTenSP.Text = dgvKetQua[1, rowIndex].Value.ToString();
                    dtpNgaySX.Value = (DateTime)dgvKetQua[2, rowIndex].Value;
                    dtpNgayHH.Value = (DateTime)dgvKetQua[3, rowIndex].Value;
                    txtDonVi.Text = dgvKetQua[4, rowIndex].Value.ToString();
                    txtDonGia.Text = dgvKetQua[5, rowIndex].Value.ToString();
                    txtGhiChu.Text = dgvKetQua[6, rowIndex].Value.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "CẬP NHẬT MẶT HÀNG";
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            HienChiTiet(true);
            txtMaSP.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa mã mặt hàng " + txtMaSP.Text + " không? Nếu có ấn nút Lưu, không thì ấn nút Hủy", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblTieuDe.Text = "XÓA MẶT HÀNG";
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                HienChiTiet(true);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                if (txtTenSP.Text.Trim() == "")
                {
                    errChiTiet.SetError(txtTenSP, "Bạn không để trống tên sản phẩm!");
                    return;
                }
                else
                {
                    errChiTiet.Clear();
                }

                if (dtpNgaySX.Value > DateTime.Now)
                {
                    errChiTiet.SetError(dtpNgaySX, "Ngày sản xuất không hợp lệ!");
                    return;
                }
                else
                {
                    errChiTiet.Clear();
                }

                if (dtpNgayHH.Value < dtpNgaySX.Value)
                {
                    errChiTiet.SetError(dtpNgayHH, "Ngay hết hạn nhỏ hơn ngày sản xuất!");
                    return;
                }
                else
                {
                    errChiTiet.Clear();
                }

                if (txtDonVi.Text.Trim() == "")
                {
                    errChiTiet.SetError(txtDonVi, "Bạn không để trống đơn vi!");
                    return;
                }
                else
                {
                    errChiTiet.Clear();
                }

                float donGia = 0;
                if (txtDonGia.Text.Trim() == "")
                {
                    errChiTiet.SetError(txtDonGia, "Bạn không để trống đơn giá!");
                    return;
                }
                else if (!float.TryParse(txtDonGia.Text.Trim(), out donGia))
                {
                    errChiTiet.SetError(txtDonGia, "Đơn giá phải là một con số!");
                    return;
                }
                else
                {
                    errChiTiet.Clear();
                }

                cmd = new SqlCommand();
                cmd.Connection = con;

                if (btnThem.Enabled == true)
                {
                    if (txtMaSP.Text.Trim() == "")
                    {
                        errChiTiet.SetError(txtMaSP, "Bạn không để trống mã sản phẩm trường này!");
                        return;
                    }
                    else
                    {
                        sql = "Select Count(*) From tblMatHang Where MaSP = @MaSP";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());
                        int val = (int)cmd.ExecuteScalar();
                        if (val > 0)
                        {
                            errChiTiet.SetError(txtMaSP, "Mã sản phẩm trùng trong cơ sở dữ liệu");
                            return;
                        }
                        errChiTiet.Clear();
                    }

                    sql = "INSERT INTO tblMatHang(MaSP,TenSP,NgaySX,NgayHH,DonVi,DonGia,GhiChu) VALUES (@MaSP, @TenSP, @NgaySX, @NgayHH, @DonVi, @DonGia, @GhiChu)";
                    cmd.CommandText = sql;
                }

                if (btnSua.Enabled == true)
                {
                    sql = "UPDATE tblMatHang SET TenSP = @TenSP, NgaySX = @NgaySX, NgayHH = @NgayHH, DonVi = @DonVi, DonGia = @DonGia, GhiChu = @GhiChu WHERE MaSP = @MaSP";
                    cmd.CommandText = sql;
                }

                if (btnXoa.Enabled == true)
                {
                    sql = "DELETE FROM tblMatHang WHERE MaSP = @MaSP";
                    cmd.CommandText = sql;
                }

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());

                if (btnThem.Enabled == true || btnSua.Enabled == true)
                {
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgaySX", dtpNgaySX.Value.Date);
                    cmd.Parameters.AddWithValue("@NgayHH", dtpNgayHH.Value.Date);
                    cmd.Parameters.AddWithValue("@DonVi", txtDonVi.Text.Trim());
                    cmd.Parameters.AddWithValue("@DonGia", donGia);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());
                }

                cmd.ExecuteNonQuery();

                sql = "Select * from tblMatHang";
                LoadDuLieu(sql);

                HienChiTiet(false);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            XoaTrangChiTiet();
            HienChiTiet(false);
            errChiTiet.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}