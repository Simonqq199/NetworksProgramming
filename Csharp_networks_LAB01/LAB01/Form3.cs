namespace LAB01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txbInput1.Text = "";
            txbInput2.Text = "";
            txbInput3.Text = "";
            txtMinOutput.Text = "";
            txbMaxOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txbInput1.Text.Trim(), out double num1) || !double.TryParse(txbInput2.Text.Trim(), out double num2) || !double.TryParse(txbInput3.Text.Trim(), out double num3))
            {
                MessageBox.Show("Vui lòng chỉ nhập số thực.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double min = Math.Min(Math.Min(num1, num2), num3);
            double max = Math.Max(Math.Max(num1, num2), num3);

            txtMinOutput.Text = min.ToString();
            txbMaxOutput.Text = max.ToString();
        }
    }
}