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
    public partial class Form5 : Form
    {
        string strCon = @"Data Source=KIETVO\MSSQLSERVER01;Initial Catalog=Quanlybanhang;Integrated Security=True;Encrypt=False";
        SqlConnection sqlCon = null;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClassList();
        }

        private void LoadClassList()
        {
            try
            {
                if (sqlCon == null) { sqlCon = new SqlConnection(strCon); }
                if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }

                SqlCommand sqlCmd = new SqlCommand("select * from Lop", sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();

                List<Lop> dsLop = new List<Lop>();
                while (reader.Read())
                {
                    Lop lop = new Lop
                    {
                        MaLop = reader.GetString(0),
                        TenLop = reader.GetString(1)
                    };
                    dsLop.Add(lop);
                }
                reader.Close();
                sqlCon.Close();

                lbDSLop.DataSource = dsLop;
                lbDSLop.DisplayMember = "TenLop";
                lbDSLop.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
            }
        }

        private void lbDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDSLop.SelectedItem == null) return;

            string maLopDuocChon = lbDSLop.SelectedValue.ToString();
            LoadStudentList(maLopDuocChon);
        }

        private void LoadStudentList(string maLop)
        {
            try
            {
                if (sqlCon == null) { sqlCon = new SqlConnection(strCon); }
                if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }

                SqlCommand sqlCmd = new SqlCommand("select * from SinhVien where MaLop = @maLop", sqlCon);
                sqlCmd.Parameters.AddWithValue("@maLop", maLop);

                SqlDataReader reader = sqlCmd.ExecuteReader();
                lsvDSSV.Items.Clear();
                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string hoTen = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    string queQuan = reader.GetString(4);

                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(hoTen);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(ngaySinh);
                    lvi.SubItems.Add(queQuan);
                    lsvDSSV.Items.Add(lvi);
                }
                reader.Close();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sinh viên: " + ex.Message);
            }
        }
    }

    public class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
    }
}

