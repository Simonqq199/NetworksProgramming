using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbInput1.Text.Trim(), out int num1) || !int.TryParse(txbInput2.Text.Trim(), out int num2))
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long sum = num1 + num2;
            txbSumOutput.Text = sum.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txbInput1.Text = "";
            txbInput2.Text = "";
            txbSumOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
