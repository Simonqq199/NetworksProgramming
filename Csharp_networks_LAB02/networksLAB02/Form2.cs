using Microsoft.VisualBasic.Devices;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networksLAB02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtContent.Height = 165;
            txtContent.Multiline = true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Hiển thị hộp thoại OpenFileDialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Đọc nội dung của file được chọn và hiển thị lên TextBox
                string fileName = openFileDialog1.FileName;
                string content = File.ReadAllText(fileName);

                txtContent.Text = content;
                MessageBox.Show("Đã đọc thành công file " + fileName);
            }
        }

        // Sự kiện click của nút btnWrite
        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            // Hiển thị hộp thoại SaveFileDialog
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Mở FileStream để ghi nội dung vào file
                using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))

                // Sử dụng StreamWriter để ghi nội dung vào file, tất cả các chữ cái đều được viết hoa
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    string content = txtContent.Text.ToUpper();    // Chuyển tất cả chữ cái thành chữ in hoa
                    writer.Write(content);
                }
            }

        }
    }
}

