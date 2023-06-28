using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace NT106_Lab5
{
    public partial class MailSender : Form
    {
        public MailSender(string Email, string Pass)
        {
            InitializeComponent();
            txbFrom.Text = Email;
            txbPass.Text = Pass;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string fromAddText = txbFrom.Text.ToString().Trim();
                string toAddText = txbTo.Text.ToString().Trim();
                string password = txbPass.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(fromAddText, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(fromAddText);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = tbSubj.Text.ToString().Trim();
                    // Set IsBodyHtml to true means you can send HTML email.
                    message.IsBodyHtml = true;
                    message.Body = rtbCnt.Text.ToString();
                    message.To.Add(toAddText);
                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Successful");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void MailSender_Load(object sender, EventArgs e)
        {

        }
    }
}
