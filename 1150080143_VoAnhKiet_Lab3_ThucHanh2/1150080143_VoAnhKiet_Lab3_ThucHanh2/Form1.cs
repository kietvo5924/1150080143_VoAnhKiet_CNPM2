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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên sinh viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus(); 
                return; 
            }


            ListViewItem item = new ListViewItem(txtHoTen.Text);

            item.SubItems.Add(dtpNgaySinh.Text);
            item.SubItems.Add(txtLop.Text);   
            item.SubItems.Add(txtDiaChi.Text); 

            lvSinhVien.Items.Add(item);

            ClearInputFields();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvSinhVien.SelectedItems[0];

                selectedItem.SubItems[0].Text = txtHoTen.Text;
                selectedItem.SubItems[1].Text = dtpNgaySinh.Text;
                selectedItem.SubItems[2].Text = txtLop.Text;
                selectedItem.SubItems[3].Text = txtDiaChi.Text;

                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvSinhVien.SelectedItems[0];
                txtHoTen.Text = selectedItem.SubItems[0].Text;
                dtpNgaySinh.Value = DateTime.Parse(selectedItem.SubItems[1].Text);
                txtLop.Text = selectedItem.SubItems[2].Text;
                txtDiaChi.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void ClearInputFields()
        {
            txtHoTen.Text = "";
            txtLop.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtHoTen.Focus();
        }
    }
}