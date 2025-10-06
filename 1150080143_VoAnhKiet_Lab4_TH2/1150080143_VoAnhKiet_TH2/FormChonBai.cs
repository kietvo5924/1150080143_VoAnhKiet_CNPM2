using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1150080143_VoAnhKiet_TH2
{
    public partial class FormChonBai : Form
    {
        public FormChonBai()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.Show();
        }
    }
}
