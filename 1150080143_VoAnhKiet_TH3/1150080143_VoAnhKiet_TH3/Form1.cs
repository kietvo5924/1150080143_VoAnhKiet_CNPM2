using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1150080143_VoAnhKiet_TH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLySinhVien_TH3.mdf;Integrated Security=True";
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

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLop();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
        }

        private void HienThiDanhSachLop()
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Lop", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            cbMaLop.Items.Clear();
            while (reader.Read())
            {
                cbMaLop.Items.Add(reader.GetString(0) + " - " + reader.GetString(1));
            }
            reader.Close();
            DongKetNoi();
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLop.SelectedIndex == -1) return;

            string selected = cbMaLop.SelectedItem.ToString();
            string[] arr = selected.Split('-');
            string maLop = arr[0].Trim();

            HienThiSinhVienTheoLop(maLop);
        }

        private void HienThiSinhVienTheoLop(string maLop)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM SinhVien WHERE MaLop = @maLop", sqlCon);
            sqlCmd.Parameters.AddWithValue("@maLop", maLop);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0)); 
                lvi.SubItems.Add(reader.GetString(1)); 
                lvi.SubItems.Add(reader.GetString(2)); 
                lvi.SubItems.Add(reader.GetDateTime(3).ToString("dd/MM/yyyy")); 
                lvi.SubItems.Add(reader.GetString(4)); 
                lvi.SubItems.Add(reader.GetString(5)); 
                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();
            DongKetNoi();
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            txtMaSV.Text = lvi.SubItems[0].Text;
            txtTenSV.Text = lvi.SubItems[1].Text;
            cbGioiTinh.Text = lvi.SubItems[2].Text;

            dtpNgaySinh.Value = DateTime.ParseExact(lvi.SubItems[3].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            txtQueQuan.Text = lvi.SubItems[4].Text;
            txtMaLop.Text = lvi.SubItems[5].Text;

            txtMaSV.ReadOnly = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.", "Thông báo");
                return;
            }

            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandText = @"UPDATE SinhVien 
                                   SET TenSV=@ten, GioiTinh=@gt, NgaySinh=@ns, QueQuan=@qq, MaLop=@malop 
                                   WHERE MaSV=@ma";

            sqlCmd.Parameters.AddWithValue("@ten", txtTenSV.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@gt", cbGioiTinh.SelectedItem.ToString());
            sqlCmd.Parameters.AddWithValue("@ns", dtpNgaySinh.Value);
            sqlCmd.Parameters.AddWithValue("@qq", txtQueQuan.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@malop", txtMaLop.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@ma", txtMaSV.Text.Trim());

            int kq = sqlCmd.ExecuteNonQuery();

            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
                HienThiSinhVienTheoLop(txtMaLop.Text.Trim());
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            DongKetNoi();
        }
    }
}
