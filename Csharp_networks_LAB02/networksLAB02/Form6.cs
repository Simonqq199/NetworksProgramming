using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace networksLAB02
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = browseForFolder();
            if (!string.IsNullOrEmpty(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] files = di.GetFiles();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Tên file");
                dataTable.Columns.Add("Kích thước");
                dataTable.Columns.Add("Đuôi mở rộng");
                dataTable.Columns.Add("Ngày chỉnh cuối");

                foreach (FileInfo file in files)
                {
                    DataRow row = dataTable.NewRow();
                    row["Tên file"] = file.Name;
                    row["Kích thước"] = file.Length;
                    row["Đuôi mở rộng"] = file.Extension;
                    row["Ngày chỉnh cuối"] = file.LastWriteTime;
                    dataTable.Rows.Add(row);
                }

                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns["Tên file"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private string browseForFolder()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.SelectedPath;
                }
            }

            return string.Empty;
        }
    }
}
