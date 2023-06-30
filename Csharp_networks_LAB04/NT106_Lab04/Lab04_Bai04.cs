using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NT106_Lab04
{
    public partial class Lab04_Bai04 : Form
    {
        public WebBrowser webBrowser1;
        public Lab04_Bai04()
        {
            InitializeComponent();

            // Create a new WebBrowser control
            webBrowser1 = new WebBrowser();
            this.Controls.Add(webBrowser1);
            // Set the control's properties as desired
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private string getSource(string URL)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument content = new HtmlAgilityPack.HtmlDocument();
                content = web.Load(URL);
                string s = content.Text;
                return s;
            }
            catch
            {
                return "URL không tồn tại!";
            }
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Lab4_btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Lab4_txtURL.Text);
            // Stop script errors
            webBrowser1.ScriptErrorsSuppressed = true;
        }
        private void Lab4_txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Lab4_btnSearch.PerformClick();
        }

        private async void Lab4_btnDownload_Click(object sender, EventArgs e)
        {
            if (getSource(Lab4_txtURL.Text) == "URL không tồn tại!") { }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "HTML|*.html", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteLineAsync(getSource(Lab4_txtURL.Text));
                            MessageBox.Show("Tải source thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void Lab4_btnSource_Click(object sender, EventArgs e)
        {
            if (getSource(Lab4_txtURL.Text) == "URL không tồn tại!") { }
            else
            {
                SourceHTML source = new SourceHTML(getSource(Lab4_txtURL.Text));
                source.Show();
            }
        }

        private void Lab4_txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab04_Bai04_Load(object sender, EventArgs e)
        {

        }
    }
}
