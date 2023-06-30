using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networksLAB02
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            txtContent.Multiline = true;
            txtContent.Height = 165;
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = new List<string>();

                StreamReader reader = new StreamReader(openFileDialog.FileName);
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    lines.Add(line);
                }
                reader.Close();
                string fileName = openFileDialog.FileName;
                MessageBox.Show("Đã đọc thành công file " + fileName);
                List<string> results = new List<string>();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');

                    float num1 = float.Parse(parts[0]);
                    float num2 = float.Parse(parts[2]);
                    string op = parts[1];

                    float result = 0;

                    switch (op)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                    }

                    string resultLine = $"{num1} {op} {num2} = {result} \n";
                    results.Add(resultLine);
                }

                // Hiển thị kết quả lên TextBox
                txtContent.Lines = results.ToArray();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);

                foreach (string result in txtContent.Lines)
                {
                    writer.WriteLine(result);
                }

                writer.Close();
            }
        }

    }
}
