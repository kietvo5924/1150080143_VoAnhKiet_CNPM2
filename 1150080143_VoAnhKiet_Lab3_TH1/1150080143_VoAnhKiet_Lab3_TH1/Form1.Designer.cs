namespace _1150080143_VoAnhKiet_Lab3_TH1
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblFoodList = new System.Windows.Forms.Label();
            this.btnComChien = new System.Windows.Forms.Button();
            this.btnBanhMy = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnOcRangMuoi = new System.Windows.Forms.Button();
            this.btnKhoaiTayChien = new System.Windows.Forms.Button();
            this.btn7Up = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnMyXao = new System.Windows.Forms.Button();
            this.btnCaVienChien = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.btnDuiGaRan = new System.Windows.Forms.Button();
            this.btnBunBoHue = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cboChonBan = new System.Windows.Forms.ComboBox();
            this.lblChonBan = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();

            this.panelHeader.BackColor = System.Drawing.Color.Green;
            this.panelHeader.Controls.Add(this.lblRestaurantName);
            this.panelHeader.Location = new System.Drawing.Point(145, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(427, 80);
            this.panelHeader.TabIndex = 0;

            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.ForeColor = System.Drawing.Color.White;
            this.lblRestaurantName.Location = new System.Drawing.Point(52, 27);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(322, 26);
            this.lblRestaurantName.TabIndex = 0;
            this.lblRestaurantName.Text = "Quán ăn nhanh Võ Anh Kiệt";

            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(127, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
 
            this.lblFoodList.AutoSize = true;
            this.lblFoodList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodList.Location = new System.Drawing.Point(12, 105);
            this.lblFoodList.Name = "lblFoodList";
            this.lblFoodList.Size = new System.Drawing.Size(142, 17);
            this.lblFoodList.TabIndex = 2;
            this.lblFoodList.Text = "Danh sách món ăn:";

            this.btnComChien.Location = new System.Drawing.Point(15, 135);
            this.btnComChien.Name = "btnComChien";
            this.btnComChien.Size = new System.Drawing.Size(124, 40);
            this.btnComChien.TabIndex = 3;
            this.btnComChien.Text = "Cơm chiên trứng";
            this.btnComChien.UseVisualStyleBackColor = true;
            this.btnComChien.Click += new System.EventHandler(this.MonAn_Click);

            this.btnBanhMy.Location = new System.Drawing.Point(145, 135);
            this.btnBanhMy.Name = "btnBanhMy";
            this.btnBanhMy.Size = new System.Drawing.Size(124, 40);
            this.btnBanhMy.TabIndex = 4;
            this.btnBanhMy.Text = "Bánh mỳ ốp la";
            this.btnBanhMy.UseVisualStyleBackColor = true;
            this.btnBanhMy.Click += new System.EventHandler(this.MonAn_Click);

            this.btnCoca.Location = new System.Drawing.Point(315, 135);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(124, 40);
            this.btnCoca.TabIndex = 5;
            this.btnCoca.Text = "Coca";
            this.btnCoca.UseVisualStyleBackColor = true;
            this.btnCoca.Click += new System.EventHandler(this.MonAn_Click);

            this.btnLipton.Location = new System.Drawing.Point(445, 135);
            this.btnLipton.Name = "btnLipton";
            this.btnLipton.Size = new System.Drawing.Size(124, 40);
            this.btnLipton.TabIndex = 6;
            this.btnLipton.Text = "Lipton";
            this.btnLipton.UseVisualStyleBackColor = true;
            this.btnLipton.Click += new System.EventHandler(this.MonAn_Click);

            this.btnOcRangMuoi.Location = new System.Drawing.Point(15, 181);
            this.btnOcRangMuoi.Name = "btnOcRangMuoi";
            this.btnOcRangMuoi.Size = new System.Drawing.Size(124, 40);
            this.btnOcRangMuoi.TabIndex = 7;
            this.btnOcRangMuoi.Text = "Ốc rang muối";
            this.btnOcRangMuoi.UseVisualStyleBackColor = true;
            this.btnOcRangMuoi.Click += new System.EventHandler(this.MonAn_Click);

            this.btnKhoaiTayChien.Location = new System.Drawing.Point(145, 181);
            this.btnKhoaiTayChien.Name = "btnKhoaiTayChien";
            this.btnKhoaiTayChien.Size = new System.Drawing.Size(124, 40);
            this.btnKhoaiTayChien.TabIndex = 8;
            this.btnKhoaiTayChien.Text = "Khoai tây chiên";
            this.btnKhoaiTayChien.UseVisualStyleBackColor = true;
            this.btnKhoaiTayChien.Click += new System.EventHandler(this.MonAn_Click);

            this.btn7Up.Location = new System.Drawing.Point(315, 181);
            this.btn7Up.Name = "btn7Up";
            this.btn7Up.Size = new System.Drawing.Size(124, 40);
            this.btn7Up.TabIndex = 9;
            this.btn7Up.Text = "7 up";
            this.btn7Up.UseVisualStyleBackColor = true;
            this.btn7Up.Click += new System.EventHandler(this.MonAn_Click);

            this.btnCam.Location = new System.Drawing.Point(445, 181);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(124, 40);
            this.btnCam.TabIndex = 10;
            this.btnCam.Text = "Cam";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.MonAn_Click);

            this.btnMyXao.Location = new System.Drawing.Point(15, 227);
            this.btnMyXao.Name = "btnMyXao";
            this.btnMyXao.Size = new System.Drawing.Size(124, 40);
            this.btnMyXao.TabIndex = 11;
            this.btnMyXao.Text = "Mỳ xào hải sản";
            this.btnMyXao.UseVisualStyleBackColor = true;
            this.btnMyXao.Click += new System.EventHandler(this.MonAn_Click);

            this.btnCaVienChien.Location = new System.Drawing.Point(145, 227);
            this.btnCaVienChien.Name = "btnCaVienChien";
            this.btnCaVienChien.Size = new System.Drawing.Size(124, 40);
            this.btnCaVienChien.TabIndex = 12;
            this.btnCaVienChien.Text = "Cá viên chiên";
            this.btnCaVienChien.UseVisualStyleBackColor = true;
            this.btnCaVienChien.Click += new System.EventHandler(this.MonAn_Click);

            this.btnPepsi.Location = new System.Drawing.Point(315, 227);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(124, 40);
            this.btnPepsi.TabIndex = 13;
            this.btnPepsi.Text = "Pepsi";
            this.btnPepsi.UseVisualStyleBackColor = true;
            this.btnPepsi.Click += new System.EventHandler(this.MonAn_Click);
 
            this.btnCafe.Location = new System.Drawing.Point(445, 227);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(124, 40);
            this.btnCafe.TabIndex = 14;
            this.btnCafe.Text = "Cafe";
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.Click += new System.EventHandler(this.MonAn_Click);

            this.btnBurger.Location = new System.Drawing.Point(15, 273);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(124, 40);
            this.btnBurger.TabIndex = 15;
            this.btnBurger.Text = "Burger bò nướng";
            this.btnBurger.UseVisualStyleBackColor = true;
            this.btnBurger.Click += new System.EventHandler(this.MonAn_Click);

            this.btnDuiGaRan.Location = new System.Drawing.Point(145, 273);
            this.btnDuiGaRan.Name = "btnDuiGaRan";
            this.btnDuiGaRan.Size = new System.Drawing.Size(124, 40);
            this.btnDuiGaRan.TabIndex = 16;
            this.btnDuiGaRan.Text = "Đùi gà rán";
            this.btnDuiGaRan.UseVisualStyleBackColor = true;
            this.btnDuiGaRan.Click += new System.EventHandler(this.MonAn_Click);

            this.btnBunBoHue.Location = new System.Drawing.Point(315, 273);
            this.btnBunBoHue.Name = "btnBunBoHue";
            this.btnBunBoHue.Size = new System.Drawing.Size(124, 40);
            this.btnBunBoHue.TabIndex = 17;
            this.btnBunBoHue.Text = "Bún bò Huế";
            this.btnBunBoHue.UseVisualStyleBackColor = true;
            this.btnBunBoHue.Click += new System.EventHandler(this.MonAn_Click);

            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControls.Controls.Add(this.btnOrder);
            this.panelControls.Controls.Add(this.cboChonBan);
            this.panelControls.Controls.Add(this.lblChonBan);
            this.panelControls.Controls.Add(this.btnXoa);
            this.panelControls.Location = new System.Drawing.Point(12, 329);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(560, 58);
            this.panelControls.TabIndex = 18;

            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(448, 9);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(95, 38);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);

            this.cboChonBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonBan.FormattingEnabled = true;
            this.cboChonBan.Location = new System.Drawing.Point(220, 19);
            this.cboChonBan.Name = "cboChonBan";
            this.cboChonBan.Size = new System.Drawing.Size(155, 21);
            this.cboChonBan.TabIndex = 2;

            this.lblChonBan.AutoSize = true;
            this.lblChonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonBan.Location = new System.Drawing.Point(139, 20);
            this.lblChonBan.Name = "lblChonBan";
            this.lblChonBan.Size = new System.Drawing.Size(75, 17);
            this.lblChonBan.TabIndex = 1;
            this.lblChonBan.Text = "Chọn bàn:";

            this.btnXoa.Location = new System.Drawing.Point(16, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 38);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(12, 393);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(560, 186);
            this.dgvOrder.TabIndex = 19;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 591);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.btnBunBoHue);
            this.Controls.Add(this.btnDuiGaRan);
            this.Controls.Add(this.btnBurger);
            this.Controls.Add(this.btnCafe);
            this.Controls.Add(this.btnPepsi);
            this.Controls.Add(this.btnCaVienChien);
            this.Controls.Add(this.btnMyXao);
            this.Controls.Add(this.btnCam);
            this.Controls.Add(this.btn7Up);
            this.Controls.Add(this.btnKhoaiTayChien);
            this.Controls.Add(this.btnOcRangMuoi);
            this.Controls.Add(this.btnLipton);
            this.Controls.Add(this.btnCoca);
            this.Controls.Add(this.btnBanhMy);
            this.Controls.Add(this.btnComChien);
            this.Controls.Add(this.lblFoodList);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblFoodList;
        private System.Windows.Forms.Button btnComChien;
        private System.Windows.Forms.Button btnBanhMy;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btnOcRangMuoi;
        private System.Windows.Forms.Button btnKhoaiTayChien;
        private System.Windows.Forms.Button btn7Up;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnMyXao;
        private System.Windows.Forms.Button btnCaVienChien;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Button btnDuiGaRan;
        private System.Windows.Forms.Button btnBunBoHue;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cboChonBan;
        private System.Windows.Forms.Label lblChonBan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvOrder;
    }
}