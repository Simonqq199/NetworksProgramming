using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using MailKit.Search;
using MailKit.Security;

namespace NT106_Lab5
{
    public partial class MailReader : Form
    {
        public MailReader(string Email, string Pass)
        {
            InitializeComponent();
            emailTextBox.Text = Email;
            passwordTextBox.Text = Pass;
        }

        private async void RetrieveEmailsButton_Click(object sender, EventArgs ev)
        {
            var email = emailTextBox.Text;
            var password = passwordTextBox.Text;
            var server = "127.0.0.1"; // IMAP server
            var port = 143; // IMAP server's port

            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true; // ignore SSL/TLS certificate errors
                client.Connect(server, port, SecureSocketOptions.None); // disable SSL/TLS
                client.Authenticate(email, password);

                // Select the inbox folder
                var inbox = client.Inbox;
                await inbox.OpenAsync(FolderAccess.ReadOnly);

                // Retrieve the messages
                var messages = await inbox.FetchAsync(0, -1, MessageSummaryItems.Full | MessageSummaryItems.UniqueId);
                List<EmailInfo> emailInfos = new List<EmailInfo>();

                // Process the messages
                foreach (var message in messages)
                {
                    emailInfos.Add(new EmailInfo
                    {
                        Subject = message.Envelope.Subject,
                        From = message.Envelope.From.ToString(),
                        Date = message.Envelope.Date.ToString()
                    });
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Display the messages in the DataGridView
                dataGridView1.DataSource = emailInfos;

                client.Disconnect(true);
            }
        }
    }

    public class EmailInfo
    {
        public string Subject { get; set; }
        public string From { get; set; }
        public string Date { get; set; }
    }

}
