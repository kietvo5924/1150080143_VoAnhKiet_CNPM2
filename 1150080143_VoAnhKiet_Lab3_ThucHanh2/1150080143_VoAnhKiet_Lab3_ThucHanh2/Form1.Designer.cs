namespace _1150080143_VoAnhKiet_Lab3_ThucHanh2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxThongTin.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(289, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(402, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH MỤC SINH VIÊN";
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.dtpNgaySinh);
            this.groupBoxThongTin.Controls.Add(this.txtDiaChi);
            this.groupBoxThongTin.Controls.Add(this.txtLop);
            this.groupBoxThongTin.Controls.Add(this.txtHoTen);
            this.groupBoxThongTin.Controls.Add(this.lblDiaChi);
            this.groupBoxThongTin.Controls.Add(this.lblLop);
            this.groupBoxThongTin.Controls.Add(this.lblNgaySinh);
            this.groupBoxThongTin.Controls.Add(this.lblHoTen);
            this.groupBoxThongTin.Location = new System.Drawing.Point(33, 84);
            this.groupBoxThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxThongTin.Size = new System.Drawing.Size(996, 155);
            this.groupBoxThongTin.TabIndex = 1;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông tin sinh viên:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(117, 95);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(345, 22);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(615, 95);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(345, 22);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(615, 43);
            this.txtLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(345, 22);
            this.txtLop.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(117, 43);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(345, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(539, 98);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(539, 47);
            this.lblLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(33, 16);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(31, 98);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 1;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(31, 47);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.btnThoat);
            this.groupBoxChucNang.Controls.Add(this.btnXoa);
            this.groupBoxChucNang.Controls.Add(this.btnSua);
            this.groupBoxChucNang.Controls.Add(this.btnThem);
            this.groupBoxChucNang.Location = new System.Drawing.Point(33, 257);
            this.groupBoxChucNang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxChucNang.Size = new System.Drawing.Size(996, 89);
            this.groupBoxChucNang.TabIndex = 2;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Chức năng:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(777, 36);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 34);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(556, 36);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 34);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(335, 36);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(127, 34);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(113, 36);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 34);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.lvSinhVien);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(33, 367);
            this.groupBoxDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSach.Size = new System.Drawing.Size(996, 294);
            this.groupBoxDanhSach.TabIndex = 3;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Thông tin chung sinh viên:";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHoTen,
            this.colNgaySinh,
            this.colLop,
            this.colDiaChi});
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(21, 36);
            this.lvSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvSinhVien.MultiSelect = false;
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(952, 238);
            this.lvSinhVien.TabIndex = 9;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 200;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 120;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 120;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 270;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 690);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.groupBoxChucNang.ResumeLayout(false);
            this.groupBoxDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colDiaChi;
    }
}