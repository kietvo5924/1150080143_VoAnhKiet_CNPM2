namespace _1150080143_VoAnhKiet
{
    partial class Form1
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
            // Khai báo 2 nút bấm
            this.btnMoKetNoi = new System.Windows.Forms.Button();
            this.btnDongKetNoi = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnMoKetNoi (Nút Mở Kết Nối)
            // 
            this.btnMoKetNoi.Location = new System.Drawing.Point(50, 50);
            this.btnMoKetNoi.Name = "btnMoKetNoi";
            this.btnMoKetNoi.Size = new System.Drawing.Size(150, 40);
            this.btnMoKetNoi.TabIndex = 0;
            this.btnMoKetNoi.Text = "Mở Kết Nối";
            this.btnMoKetNoi.UseVisualStyleBackColor = true;
            this.btnMoKetNoi.Click += new System.EventHandler(this.btnMoKetNoi_Click);


            // 
            // btnDongKetNoi (Nút Đóng Kết Nối)
            // 
            this.btnDongKetNoi.Location = new System.Drawing.Point(220, 50);
            this.btnDongKetNoi.Name = "btnDongKetNoi";
            this.btnDongKetNoi.Size = new System.Drawing.Size(150, 40);
            this.btnDongKetNoi.TabIndex = 1;
            this.btnDongKetNoi.Text = "Đóng Kết Nối";
            this.btnDongKetNoi.UseVisualStyleBackColor = true;
            this.btnDongKetNoi.Click += new System.EventHandler(this.btnDongKetNoi_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 150); // Chỉnh lại kích thước cửa sổ cho phù hợp

            // Thêm 2 nút bấm vào Form
            this.Controls.Add(this.btnDongKetNoi);
            this.Controls.Add(this.btnMoKetNoi);

            this.Name = "Form1";
            this.Text = "Chương trình kết nối CSDL"; // Đặt lại tiêu đề cho cửa sổ
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnMoKetNoi;
        private System.Windows.Forms.Button btnDongKetNoi;
    }
}