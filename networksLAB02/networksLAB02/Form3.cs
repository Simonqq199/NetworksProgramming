using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace networksLAB02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            txtContent.Height = 260;
            txtContent.Multiline = true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string fileName = openFileDialog.FileName;
                string fileContent = File.ReadAllText(fileName);
                txtContent.Text = fileContent;
                MessageBox.Show("Đã đọc thành công file " + fileName);

                int numberOfChars = fileContent.Length;
                fileContent = fileContent.Replace("\r\n", "\n");
                int numberOfLines = txtContent.Lines.Count();
                fileContent = fileContent.Replace('\r', ' ');

                //biểu thức chính quy `\W+` để tách văn bản thành danh sách các từ và loại bỏ bất kỳ ký tự không phải từ nào
                string[] words = Regex.Split(fileContent, @"\W+");
                int numberOfWords = words.Length;

                txbName.Text = Path.GetFileName(fileName);
                txbURL.Text = Path.GetDirectoryName(fileName);
                txbLine.Text = numberOfLines.ToString();
                txbWord.Text = numberOfWords.ToString();
                txbChar.Text = numberOfChars.ToString();
            }
        }

    }
}
