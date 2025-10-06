namespace _1150080143_VoAnhKiet_TH2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvDanhSachSV = new System.Windows.Forms.ListView();
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQueQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXemDanhSach = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvDanhSachSV);
            this.groupBox2.Controls.Add(this.btnXemDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(23, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 321);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem danh sách sinh viên";
            // 
            // lsvDanhSachSV
            // 
            this.lsvDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colQueQuan,
            this.colMaLop});
            this.lsvDanhSachSV.FullRowSelect = true;
            this.lsvDanhSachSV.GridLines = true;
            this.lsvDanhSachSV.HideSelection = false;
            this.lsvDanhSachSV.Location = new System.Drawing.Point(24, 78);
            this.lsvDanhSachSV.Name = "lsvDanhSachSV";
            this.lsvDanhSachSV.Size = new System.Drawing.Size(706, 224);
            this.lsvDanhSachSV.TabIndex = 1;
            this.lsvDanhSachSV.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachSV.View = System.Windows.Forms.View.Details;
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã SV";
            this.colMaSV.Width = 100;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 150;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới Tính";
            this.colGioiTinh.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày Sinh";
            this.colNgaySinh.Width = 100;
            // 
            // colQueQuan
            // 
            this.colQueQuan.Text = "Quê Quán";
            this.colQueQuan.Width = 150;
            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã Lớp";
            this.colMaLop.Width = 100;
            // 
            // btnXemDanhSach
            // 
            this.btnXemDanhSach.Location = new System.Drawing.Point(24, 32);
            this.btnXemDanhSach.Name = "btnXemDanhSach";
            this.btnXemDanhSach.Size = new System.Drawing.Size(222, 30);
            this.btnXemDanhSach.TabIndex = 0;
            this.btnXemDanhSach.Text = "Xem toàn bộ danh sách";
            this.btnXemDanhSach.UseVisualStyleBackColor = true;
            this.btnXemDanhSach.Click += new System.EventHandler(this.btnXemDanhSach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 367);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Danh sách Sinh viên";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvDanhSachSV;
        private System.Windows.Forms.Button btnXemDanhSach;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
        private System.Windows.Forms.ColumnHeader colMaLop;
    }
}