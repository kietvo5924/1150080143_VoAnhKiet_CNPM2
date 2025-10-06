namespace _1150080143_VoAnhKiet_TH2
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.btnXemDSLop = new System.Windows.Forms.Button();
            this.lsvLop = new System.Windows.Forms.ListView();
            this.colMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvLop);
            this.groupBox1.Controls.Add(this.btnXemDSLop);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xem danh sách lớp theo khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên khoa:";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(126, 39);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(242, 22);
            this.txtTenKhoa.TabIndex = 1;
            // 
            // btnXemDSLop
            // 
            this.btnXemDSLop.Location = new System.Drawing.Point(384, 35);
            this.btnXemDSLop.Name = "btnXemDSLop";
            this.btnXemDSLop.Size = new System.Drawing.Size(124, 30);
            this.btnXemDSLop.TabIndex = 2;
            this.btnXemDSLop.Text = "Xem danh sách";
            this.btnXemDSLop.UseVisualStyleBackColor = true;
            this.btnXemDSLop.Click += new System.EventHandler(this.btnXemDSLop_Click);
            // 
            // lsvLop
            // 
            this.lsvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaLop,
            this.colTenLop});
            this.lsvLop.FullRowSelect = true;
            this.lsvLop.GridLines = true;
            this.lsvLop.HideSelection = false;
            this.lsvLop.Location = new System.Drawing.Point(28, 86);
            this.lsvLop.Name = "lsvLop";
            this.lsvLop.Size = new System.Drawing.Size(480, 218);
            this.lsvLop.TabIndex = 3;
            this.lsvLop.UseCompatibleStateImageBehavior = false;
            this.lsvLop.View = System.Windows.Forms.View.Details;
            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã Lớp";
            this.colMaLop.Width = 120;
            // 
            // colTenLop
            // 
            this.colTenLop.Text = "Tên Lớp";
            this.colTenLop.Width = 350;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 373);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sử dụng Parameter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvLop;
        private System.Windows.Forms.Button btnXemDSLop;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colMaLop;
        private System.Windows.Forms.ColumnHeader colTenLop;
    }
}
