using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB01
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void btnDo_Click(object sender, EventArgs e)
        {
            // Gán giá trị Input vào biến cho dễ dàng sử dụng
            string inputValue = txbInput.Text;

            // chỉnh lại dạng thống nhất (hexadecimal)
            string inputFormat = cbbSource.Text.ToLower();
            int inputNumber;
            switch (inputFormat)
            {
                case "decimal":
                    if (!int.TryParse(inputValue, out inputNumber))
                    {
                        // Lỗi khi nhập không khớp binary
                        MessageBox.Show("Invalid decimal input (|input| < 2,147,483,647).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "binary":
                    if (!Regex.IsMatch(inputValue, "^[01]+$"))
                    {
                        // Lỗi khi nhập không khớp binary
                        MessageBox.Show("Invalid binary input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    inputNumber = Convert.ToInt32(inputValue, 2);
                    break;
                case "hexadecimal":
                    if (!Regex.IsMatch(inputValue, "^[0-9A-Fa-f]+$"))
                    {
                        // Lỗi khi nhập không khớp hexadecimal
                        MessageBox.Show("Invalid hexadecimal input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    inputNumber = Convert.ToInt32(inputValue, 16);
                    break;
                case "octal":
                    if (!Regex.IsMatch(inputValue, "^[0-7]+$"))
                    {
                        // Lỗi khi nhập input không khớp octal
                        MessageBox.Show("Invalid octal input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    inputNumber = Convert.ToInt32(inputValue, 8);
                    break;
                default:
                    // default 
                    MessageBox.Show("Lỗi, vui lòng nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Quá trình chuyển đổi

            string outputValue = "";
            string outputFormat = cbbDestination.Text.ToLower();

            switch (inputFormat)
            {
                // Các trường hợp từ decimal

                case "decimal":
                    switch (outputFormat)
                    {
                        case "binary":
                            outputValue = Convert.ToString(inputNumber, 2);
                            break;
                        case "hexadecimal":
                            outputValue = Convert.ToString(inputNumber, 16);
                            break;
                        case "octal":
                            outputValue = Convert.ToString(inputNumber, 8);
                            break;
                    }
                    break;
                // Các trường hợp từ binary

                case "binary":
                    switch (outputFormat)
                    {
                        case "decimal":
                            outputValue = Convert.ToString(inputNumber, 10);
                            break;
                        case "hexadecimal":
                            outputValue = Convert.ToString(inputNumber, 16);
                            break;
                        case "octal":
                            outputValue = Convert.ToString(inputNumber, 8);
                            break;
                    }
                    break;
                // Các trường hợp từ hexadecimal

                case "hexadecimal":
                    switch (outputFormat)
                    {
                        case "decimal":
                            outputValue = inputNumber.ToString();
                            break;
                        case "binary":
                            outputValue = Convert.ToString(inputNumber, 2);
                            break;
                        case "octal":
                            outputValue = Convert.ToString(inputNumber, 8);
                            break;
                    }
                    break;
                // Các trường hợp từ Octal

                case "octal":
                    switch (outputFormat)
                    {
                        case "decimal":
                            outputValue = inputNumber.ToString();
                            break;
                        case "binary":
                            outputValue = Convert.ToString(inputNumber, 2);
                            break;
                        case "hexadecimal":
                            outputValue = Convert.ToString(inputNumber, 16);
                            break;
                    }
                    break;
            }

            // Gán kết quả vào Output textBox
            txbOutput.Text = outputValue;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            txbInput.Text = "";
            txbOutput.Text = "";
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
