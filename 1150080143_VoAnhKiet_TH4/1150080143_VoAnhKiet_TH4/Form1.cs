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

namespace _1150080143_VoAnhKiet_TH4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLySinhVien_TH4.mdf;Integrated Security=True";
        SqlConnection sqlCon = null;
        private string selectedMaSV = null;

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
            HienThiDanhSachSinhVien();
        }

        private void HienThiDanhSachSinhVien()
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM SinhVien", sqlCon);
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
            if (lsvDanhSach.SelectedItems.Count > 0)
            {
                selectedMaSV = lsvDanhSach.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                selectedMaSV = null;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaSV))
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên có mã " + selectedMaSV + " không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = "DELETE FROM SinhVien WHERE MaSV = @maSV";
                sqlCmd.Parameters.AddWithValue("@maSV", selectedMaSV);

                int kq = sqlCmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Xóa sinh viên thành công!");
                    HienThiDanhSachSinhVien();
                    selectedMaSV = null;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
                DongKetNoi();
            }
        }
    }
}
