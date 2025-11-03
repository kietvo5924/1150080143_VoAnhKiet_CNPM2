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

namespace VoAnhKiet_1150080143_BTtuan10
{
    public partial class Form1 : Form
    {

        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Downloads\Phương Pháp Phát Triển Phần Mềm\Buoi10\1150080143_VoAnhKiet_CNPM2\VoAnhKiet_1150080143_BTtuan10\VoAnhKiet_1150080143_BTtuan10\QuanLyBanSach.mdf"";Integrated Security=True";

        // Doi tuong ket noi
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        // 2. Hàm mở kết nối
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

        // 3. Hàm đóng kết nối
        private void DongKetNoi()
        {
            // Lưu ý: Code gốc trong file bị lỗi 'fifi', đã sửa thành '&&'
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        // 4. Sự kiện click của Button
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                string sql = "select * from NhaXuatBan";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblNhaXuatBan");

                dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                DongKetNoi(); // Đảm bảo kết nối luôn được đóng
            }
        }
    }
}