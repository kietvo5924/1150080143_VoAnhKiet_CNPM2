using System;
using System.Windows.Forms;

namespace _1150080143_VoAnhKiet_Lab3_ThucHanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút "Thêm"
        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra họ tên có rỗng không
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên sinh viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus(); // Di chuyển con trỏ vào ô họ tên
                return; // Dừng lại không làm gì cả
            }

            // 2. Tạo một dòng mới (ListViewItem)
            ListViewItem item = new ListViewItem(txtHoTen.Text); // Cột đầu tiên

            // 3. Thêm các cột phụ (SubItems)
            item.SubItems.Add(dtpNgaySinh.Text); // Cột ngày sinh
            item.SubItems.Add(txtLop.Text);      // Cột lớp
            item.SubItems.Add(txtDiaChi.Text);   // Cột địa chỉ

            // 4. Thêm dòng mới này vào ListView
            lvSinhVien.Items.Add(item);

            // 5. Xóa trắng các ô nhập liệu để chuẩn bị cho lần nhập tiếp theo
            ClearInputFields();
        }

        // Sự kiện khi nhấn nút "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                // Nếu đã chọn, thì xóa dòng đó đi
                lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
                ClearInputFields(); // Xóa trắng các ô nhập liệu
            }
            else
            {
                // Nếu chưa chọn, thông báo cho người dùng
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sự kiện khi nhấn nút "Sửa"
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                // Lấy ra dòng đang được chọn
                ListViewItem selectedItem = lvSinhVien.SelectedItems[0];

                // Cập nhật lại thông tin cho dòng đó từ các ô nhập liệu
                selectedItem.SubItems[0].Text = txtHoTen.Text;
                selectedItem.SubItems[1].Text = dtpNgaySinh.Text;
                selectedItem.SubItems[2].Text = txtLop.Text;
                selectedItem.SubItems[3].Text = txtDiaChi.Text;

                ClearInputFields(); // Xóa trắng các ô nhập liệu
            }
            else
            {
                // Nếu chưa chọn, thông báo cho người dùng
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sự kiện khi nhấn nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng có chắc chắn muốn thoát không
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form
            }
        }

        // Sự kiện xảy ra khi chọn một dòng khác trên ListView
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                // Lấy ra dòng đang được chọn
                ListViewItem selectedItem = lvSinhVien.SelectedItems[0];

                // Hiển thị thông tin của dòng đó lên các ô nhập liệu
                txtHoTen.Text = selectedItem.SubItems[0].Text;
                // Chuyển đổi ngày tháng từ chuỗi về DateTime cho DateTimePicker
                dtpNgaySinh.Value = DateTime.Parse(selectedItem.SubItems[1].Text);
                txtLop.Text = selectedItem.SubItems[2].Text;
                txtDiaChi.Text = selectedItem.SubItems[3].Text;
            }
        }

        // Hàm tiện ích để xóa trắng các ô nhập liệu
        private void ClearInputFields()
        {
            txtHoTen.Text = "";
            txtLop.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now; // Đặt lại ngày về ngày hiện tại
            txtHoTen.Focus();
        }
    }
}