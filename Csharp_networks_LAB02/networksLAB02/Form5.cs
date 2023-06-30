using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace networksLAB02
{
    [Serializable]
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public class Student
        {
            public string mssv;
            public string hoTen;
            public string dienThoai;
            public float diemToan;
            public float diemVan;
            public float dtb;

            public float tinhdtb()
            {
                this.dtb = (this.diemToan + this.diemVan) / 2;
                return this.dtb;
            }
            public string getData()
            {
                return "Mssv: " + mssv + "\n" + "Họ và tên: " + hoTen + "\n" + "Điện thoại: " + dienThoai + "\n" + "Điểm toán: " + diemToan + "\n" + "Điểm văn: " + diemVan + "\n" + "DTB: " + tinhdtb();
            }
        }

        public Student data = new Student();
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            var bFormatter = new BinaryFormatter();
            data = (Student)bFormatter.Deserialize(fs);
            richTextBox1.Text = data.getData();
            fs.Close();
        }


        private void btnWrite_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(data.getData());
            }
            fs.Close();
        }
    }
}
