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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private string NumberToWords(int number)
        {
            // Xét nếu số đó là không
            if (number == 0)
                return "Không";
            // Thêm từ âm ở trước nếu số đó < 0
            if (number < 0)
                return "âm " + NumberToWords(Math.Abs(number));

            //khới tạo
            string words = "";

            if ((number / 1000) > 0)
            {
                // Trong trường hợp số đó có đơn vị hàng ngàn
                words += NumberToWords(number / 1000) + " ngàn ";
                number %= 1000;
                // Xét luôn trường hợp sau khi số đó bị cắt đi đơn vị hàng ngàn thì đơn vị hàng trăm nó có bằng 0 không
                if (number % 1000 < 100 && number != 0)
                {
                    // nếu đơn vị hàng trăm nó bằng không thì thêm "không trăm" vào
                    words += "không trăm ";
                }
                if (number < 10 && number !=0)
                {
                    // Thêm từ đệm "lẻ" khi hàng chục của số bằng 0
                    words += "lẻ ";
                }
            }

            if ((number / 100) > 0)
            {
                // Trong trường hợp số đó có đơn vị hàng trăm
                words += NumberToWords(number / 100) + " trăm ";
                number %= 100;
                if (number < 10 && number != 0)
                {
                    // Thêm từ đệm "lẻ" khi hàng chục của số bằng 0
                    words += "lẻ ";
                }
            }

            if (number > 0)
            {
                // mảng string cho giá trị của hàng đơn vị
                string[] units = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười" };
                // mảng string cho giá trị hàng chục
                string[] tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

                // Từ 0 đến 10 có từ riêng
                if (number < 11)
                    words += units[number];
                else
                {
                    // Ghép hàng chục với hàng đơn vị
                    words += tens[number / 10];
                    if ((number % 10) > 0)
                    {
                        // Đổi "một" thành "mốt" khi ghép chung với "hai mươi" đến "chín mươi"
                        if (number % 10 == 1 && number > 20)
                            words += " mốt";
                        else // còn lại tuân theo nguyên tắc ghép từ bình thường
                            words += " " + units[number % 10];
                    }
                }
            }

            return words;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txbInput.Text);

            if (number > 9999 || number < -9999)
            {
                MessageBox.Show("Vui lòng nhập lại số nguyên trong khoảng quy định.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string words = NumberToWords(number);

            txbOutput.Text = words;
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
