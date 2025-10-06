namespace _1150080143_VoAnhKiet_TH2
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
            this.btnDemSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemSV
            // 
            this.btnDemSV.Location = new System.Drawing.Point(40, 40);
            this.btnDemSV.Name = "btnDemSV";
            this.btnDemSV.Size = new System.Drawing.Size(200, 50);
            this.btnDemSV.TabIndex = 0;
            this.btnDemSV.Text = "Đếm số lượng sinh viên";
            this.btnDemSV.UseVisualStyleBackColor = true;
            this.btnDemSV.Click += new System.EventHandler(this.btnDemSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 133);
            this.Controls.Add(this.btnDemSV);
            this.Name = "Form1";
            this.Text = "Thực hành 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemSV;
    }
}