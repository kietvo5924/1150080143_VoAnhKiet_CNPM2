using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1150080143_VoAnhKiet_Lab3_TH1
{
    public partial class Form1 : Form
    {
        private DataTable orderTable;
        private const string ImageUrl = "https://anhquanbakery.com/uploads/product/full_v2ah7y94-1274-hamburger-thit-nuong.jpg";

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            InitializeOrderTable();

            for (int i = 1; i <= 10; i++)
            {
                cboChonBan.Items.Add("Bàn " + i);
            }

            await LoadImageFromUrlAsync(ImageUrl);
        }

        private void InitializeOrderTable()
        {
            orderTable = new DataTable();
            orderTable.Columns.Add("Món ăn", typeof(string));
            orderTable.Columns.Add("Số lượng", typeof(int));

            dgvOrder.DataSource = orderTable;

            dgvOrder.Columns["Món ăn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrder.Columns["Số lượng"].Width = 100;
        }

        private async Task LoadImageFromUrlAsync(string url)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageBytes = await webClient.DownloadDataTaskAsync(url);

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image downloadedImage = Image.FromStream(ms);
                        picLogo.Image = downloadedImage;
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Không thể tải hình ảnh từ URL. Vui lòng kiểm tra kết nối internet hoặc URL.\n" + ex.Message,
                                "Lỗi tải ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xử lý hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MonAn_Click(object sender, EventArgs e)
        {
            if (cboChonBan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi order!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Button selectedButton = sender as Button;
            string tenMonAn = selectedButton.Text;

            DataRow[] foundRows = orderTable.Select($"[Món ăn] = '{tenMonAn}'");

            if (foundRows.Length > 0)
            {
                DataRow row = foundRows[0];
                row["Số lượng"] = (int)row["Số lượng"] + 1;
            }
            else
            {
                orderTable.Rows.Add(tenMonAn, 1);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvOrder.SelectedRows[0].Index;
                orderTable.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cboChonBan.SelectedItem == null || orderTable.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn và gọi món trước khi order.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Lưu thông tin Order";
            saveFileDialog.FileName = $"Order_{cboChonBan.Text}_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder fileContent = new StringBuilder();
                    fileContent.AppendLine("HÓA ĐƠN QUÁN ĂN NHANH VÕ ANH KIỆT");
                    fileContent.AppendLine("------------------------------------");
                    fileContent.AppendLine($"Bàn số: {cboChonBan.SelectedItem}");
                    fileContent.AppendLine($"Thời gian: {DateTime.Now}");
                    fileContent.AppendLine("------------------------------------");
                    fileContent.AppendLine("Danh sách món ăn:");

                    foreach (DataRow row in orderTable.Rows)
                    {
                        fileContent.AppendLine($"- {row["Món ăn"]}: {row["Số lượng"]}");
                    }

                    File.WriteAllText(saveFileDialog.FileName, fileContent.ToString());

                    MessageBox.Show("Order đã được ghi vào file thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    orderTable.Clear();
                    cboChonBan.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}