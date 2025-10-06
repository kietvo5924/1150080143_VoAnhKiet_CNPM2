namespace _1150080143_VoAnhKiet_TH2
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbDSLop = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvDSSV = new System.Windows.Forms.ListView();
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQueQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách lớp:";
            // 
            // lbDSLop
            // 
            this.lbDSLop.FormattingEnabled = true;
            this.lbDSLop.ItemHeight = 16;
            this.lbDSLop.Location = new System.Drawing.Point(25, 49);
            this.lbDSLop.Name = "lbDSLop";
            this.lbDSLop.Size = new System.Drawing.Size(220, 388);
            this.lbDSLop.TabIndex = 1;
            this.lbDSLop.SelectedIndexChanged += new System.EventHandler(this.lbDSLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách sinh viên:";
            // 
            // lsvDSSV
            // 
            this.lsvDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colQueQuan});
            this.lsvDSSV.FullRowSelect = true;
            this.lsvDSSV.GridLines = true;
            this.lsvDSSV.HideSelection = false;
            this.lsvDSSV.Location = new System.Drawing.Point(270, 49);
            this.lsvDSSV.Name = "lsvDSSV";
            this.lsvDSSV.Size = new System.Drawing.Size(630, 388);
            this.lsvDSSV.TabIndex = 3;
            this.lsvDSSV.UseCompatibleStateImageBehavior = false;
            this.lsvDSSV.View = System.Windows.Forms.View.Details;
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
            this.colGioiTinh.Width = 80;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày Sinh";
            this.colNgaySinh.Width = 100;
            // 
            // colQueQuan
            // 
            this.colQueQuan.Text = "Quê Quán";
            this.colQueQuan.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 458);
            this.Controls.Add(this.lsvDSSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDSLop);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Áp dụng: Hiển thị SV theo Lớp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDSLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvDSSV;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
    }
}