namespace _1150080143_VoAnhKiet_TH2
{
    partial class FormChonBai
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

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnBai1 = new System.Windows.Forms.Button();
            this.btnBai2 = new System.Windows.Forms.Button();
            this.btnBai3 = new System.Windows.Forms.Button();
            this.btnBai4 = new System.Windows.Forms.Button();
            this.btnBai5 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn bài thực hành để mở";

            this.btnBai1.Location = new System.Drawing.Point(60, 80);
            this.btnBai1.Name = "btnBai1";
            this.btnBai1.Size = new System.Drawing.Size(282, 40);
            this.btnBai1.TabIndex = 1;
            this.btnBai1.Text = "Bài 1: Tạo kết nối CSDL";
            this.btnBai1.UseVisualStyleBackColor = true;
            this.btnBai1.Click += new System.EventHandler(this.btnBai1_Click);

            this.btnBai2.Location = new System.Drawing.Point(60, 130);
            this.btnBai2.Name = "btnBai2";
            this.btnBai2.Size = new System.Drawing.Size(282, 40);
            this.btnBai2.TabIndex = 2;
            this.btnBai2.Text = "Bài 2: Truy vấn 1 giá trị để đếm sinh viên";
            this.btnBai2.UseVisualStyleBackColor = true;
            this.btnBai2.Click += new System.EventHandler(this.btnBai2_Click);

            this.btnBai3.Location = new System.Drawing.Point(60, 180);
            this.btnBai3.Name = "btnBai3";
            this.btnBai3.Size = new System.Drawing.Size(282, 40);
            this.btnBai3.TabIndex = 3;
            this.btnBai3.Text = "Bài 3: Truy vấn 1 dòng để tìm sinh viên";
            this.btnBai3.UseVisualStyleBackColor = true;
            this.btnBai3.Click += new System.EventHandler(this.btnBai3_Click);

            this.btnBai4.Location = new System.Drawing.Point(60, 230);
            this.btnBai4.Name = "btnBai4";
            this.btnBai4.Size = new System.Drawing.Size(282, 40);
            this.btnBai4.TabIndex = 4;
            this.btnBai4.Text = "Bài 4: Truy vấn nhiều dòng danh sách sinh viên";
            this.btnBai4.UseVisualStyleBackColor = true;
            this.btnBai4.Click += new System.EventHandler(this.btnBai4_Click);

            this.btnBai5.Location = new System.Drawing.Point(60, 280);
            this.btnBai5.Name = "btnBai5";
            this.btnBai5.Size = new System.Drawing.Size(282, 40);
            this.btnBai5.TabIndex = 5;
            this.btnBai5.Text = "Bài 5: Áp dụng lọc sinh viên theo lớp";
            this.btnBai5.UseVisualStyleBackColor = true;
            this.btnBai5.Click += new System.EventHandler(this.btnBai5_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 353);
            this.Controls.Add(this.btnBai5);
            this.Controls.Add(this.btnBai4);
            this.Controls.Add(this.btnBai3);
            this.Controls.Add(this.btnBai2);
            this.Controls.Add(this.btnBai1);
            this.Controls.Add(this.label1);
            this.Name = "FormChonBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Chọn Bài";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBai1;
        private System.Windows.Forms.Button btnBai2;
        private System.Windows.Forms.Button btnBai3;
        private System.Windows.Forms.Button btnBai4;
        private System.Windows.Forms.Button btnBai5;
    }
}