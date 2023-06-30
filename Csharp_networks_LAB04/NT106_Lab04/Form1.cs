using System;
using System.Windows.Forms;

namespace NT106_Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Lab04_Bai01 b1 = new Lab04_Bai01();
            b1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab04_Bai02 b2 = new Lab04_Bai02();
            b2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab04_Bai03 form = new Lab04_Bai03();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab04_Bai04 bai4 = new Lab04_Bai04();
            bai4.ShowDialog();
        }
    }
}