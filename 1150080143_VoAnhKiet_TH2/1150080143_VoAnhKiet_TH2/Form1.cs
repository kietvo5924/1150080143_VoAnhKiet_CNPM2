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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Chuoi ket noi
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLySinhVien.mdf;Integrated Security=True";

        // Doi tuong ket noi
        SqlConnection sqlCon = null;

        // Ham mo ket noi
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

        // Ham dong ket noi
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        // Ham hien thi danh sach sinh vien
        private void HienThiDanhSach()
        {
            MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from SinhVien";
            sqlCmd.Connection = sqlCon;

            lsvDanhSach.Items.Clear();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string maSv = reader.GetString(0);
                string tenSV = reader.GetString(1);
                string gioiTinh = reader.GetString(2);
                string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                string queQuan = reader.GetString(4);
                string maLop = reader.GetString(5);

                ListViewItem lvi = new ListViewItem(maSv);
                lvi.SubItems.Add(tenSV);
                lvi.SubItems.Add(gioiTinh);
                lvi.SubItems.Add(ngaySinh);
                lvi.SubItems.Add(queQuan);
                lvi.SubItems.Add(maLop);
                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();
        }

        // Ham them sinh vien
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoKetNoi();
            try
            {
                string maSV = txtMaSV.Text.Trim();
                string tenSV = txtTenSV.Text.Trim();
                string gioiTinh = cbGioiTinh.SelectedItem.ToString();
                string ngaySinh = dtpNgaySinh.Value.ToString("MM/dd/yyyy");
                string queQuan = txtQueQuan.Text.Trim();
                string maLop = txtMaLop.Text.Trim();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "insert into SinhVien values ('" + maSV +
                "' , N'" + tenSV + "', N'" + gioiTinh + "', '" + ngaySinh + "', N'"
                + queQuan + "' , '" + maLop + "')";

                sqlCmd.Connection = sqlCon;

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm sinh viên thành công!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu bị lỗi! " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            HienThiDanhSach();
        }
    }
}