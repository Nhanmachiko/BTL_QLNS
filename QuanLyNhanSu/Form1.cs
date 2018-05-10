using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        private bool qldm = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyThongTinNhanVien qlhs = new QuanLyThongTinNhanVien();
            this.Hide();
            qlhs.Show();
        }

        private void btn_QLDM_Click(object sender, EventArgs e)
        {
            if (qldm)
            {
                pnQLDM.Height = 0;
                btnQLTTNhanVien.Top = btn_QLDM.Top + 58;
                btnThongKe.Top = btnQLTTNhanVien.Top + 58;
            }
            else
            {
                pnQLDM.Height = 75;
                btnQLTTNhanVien.Top = btn_QLDM.Top + pnQLDM.Height + 58;
                btnThongKe.Top = btnQLTTNhanVien.Top + 58;
            }
            qldm = !qldm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnQLDM.Height = 0;
            btnQLTTNhanVien.Top = btn_QLDM.Top + 58;
            btnThongKe.Top = btnQLTTNhanVien.Top + 58;
        }
    }
}
