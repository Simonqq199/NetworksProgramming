using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB01
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private int scoreCount(string[] floatArr)
        {
            int floatCount = 0;
            foreach (string word in floatArr)
            {
                float value;
                if (float.TryParse(word, out value))
                {
                    floatCount++;
                }
            }
            return floatCount;
        }
        private void addScore(int scoreCount, string[] scoreArr)
        {
            int numberOfTextBoxes = scoreCount;
            int textBoxWidth = 120;
            int textBoxHeight = 20;
            int row = 0;

            // Create and add the text boxes
            for (int i = 0; i < numberOfTextBoxes; i++)
            {
                int seqOfScore = i + 1;
                if (i % 5 == 0)
                    row++;
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Size = new Size(textBoxWidth, textBoxHeight);
                textBox.Text = "Môn " + seqOfScore + ": " + scoreArr[i];
                textBox.Location = new Point((i % 5) * textBoxWidth, row * (textBoxHeight + 10));
                panel1.Controls.Add(textBox);

            }

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string inputText = txbScore.Text;
            string[] scoreArr = inputText.Split(' ');
            for (int i = 0;i < scoreArr.Length;i++) 
            {
                if (double.Parse(scoreArr[i]) < 0 || double.Parse(scoreArr[i]) > 10)
                {
                    MessageBox.Show("Invalid score input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbScore.Text = " ";
                    return;
                }
                
            }
            addScore(scoreCount(scoreArr), scoreArr);
            printStatistic(scoreCount(scoreArr), scoreArr);

        }

        private void printStatistic(int scoreCount, string[] scoreArr)
        {
            float avg = float.Parse(avgScore(scoreCount, scoreArr));
            label4.Text = "Điểm trung bình: " + avg;
            label5.Text = "Điểm cao nhất: " + maxScore(scoreCount, scoreArr);
            label8.Text = "Điểm thấp nhất: " + minScore(scoreCount, scoreArr);
            label6.Text = "Số môn đậu: " + passSubject(scoreCount, scoreArr);
            label9.Text = "Số môn không đậu: " + failSubject(scoreCount, scoreArr);
            label7.Text = "Xếp loại học lực: " + rankProfile(scoreCount, scoreArr, avg);
        }

        private string avgScore(int scoreCount, string[] scoreArr)
        {
            float avg = 0;
            for (int i = 0; i < scoreCount; i++)
            {
                avg += float.Parse(scoreArr[i]);
            }
            return (avg / scoreCount).ToString();
        }

        private string maxScore(int scoreCount, string[] scoreArr)
        {
            float max = float.Parse(scoreArr[0]);

            for (int i = 1; i < scoreCount; i++)
            {
                if (float.Parse(scoreArr[i]) > max)
                {
                    max = float.Parse(scoreArr[i]);
                }
            }

            return max.ToString();
        }
        private string minScore(int scoreCount, string[] scoreArr)
        {
            float min = float.Parse(scoreArr[0]);

            for (int i = 1; i < scoreCount; i++)
            {
                if (float.Parse(scoreArr[i]) < min)
                {
                    min = float.Parse(scoreArr[i]);
                }
            }

            return min.ToString();
        }
        private int passSubject(int scoreCount, string[] scoreArr)
        {
            int pass = 0;

            for (int i = 0; i < scoreCount; i++)
            {
                if (float.Parse(scoreArr[i]) >= 5)
                {
                    pass++;
                }
            }

            return pass;
        }
        private int failSubject(int scoreCount, string[] scoreArr)
        {
            int fail = 0;

            for (int i = 0; i < scoreCount; i++)
            {
                if (float.Parse(scoreArr[i]) < 5)
                {
                    fail++;
                }
            }

            return fail;
        }
        private static string rankProfile(int scoreCount, string[] scoreArr, float avgScore)
        {
            bool qualified = false;
            if (avgScore >= 8)
            {
                
                for (int i = 0; i < scoreCount; i++)
                {
                    if (float.Parse(scoreArr[i]) < 6.5)
                    {
                        qualified = false;
                        break;
                    }
                }
                if (qualified)
                    return "Giỏi";
            }
            else if (avgScore >= 6.5)
            {
                
                for (int i = 0; i < scoreCount; i++)
                {
                    if (float.Parse(scoreArr[i]) < 5)
                    {
                        qualified = false;
                        break;
                    }
                }
                if (qualified)
                    return "Khá";
            }
            else if (avgScore >= 5)
            {
                
                for (int i = 0; i < scoreCount; i++)
                {
                    if (float.Parse(scoreArr[i]) < 3.5)
                    {
                        qualified = false;
                        break;
                    }
                    if (qualified)
                        return "TB";
                }
            }
            else if (avgScore >= 3.5)
            {
                
                for (int i = 0; i < scoreCount; i++)
                {
                    if (float.Parse(scoreArr[i]) < 2)
                    {
                        qualified = false;
                        break;
                    }
                    if (qualified)
                        return "Yếu";
                }
            }
            return "Kém";
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            txbScore.Text = " ";
            panel1.Controls.Clear();
            label4.Text = "Điểm trung bình: ";
            label5.Text = "Điểm cao nhất: " ;
            label8.Text = "Điểm thấp nhất: ";
            label6.Text = "Số môn đậu: ";
            label9.Text = "Số môn không đậu: ";
            label7.Text = "Xếp loại học lực: ";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }


}
