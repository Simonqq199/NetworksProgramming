using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NT106_Lab5
{
    public partial class EmailCenter : Form
    {
        public EmailCenter()
        {
            InitializeComponent();
        }

        private void btnMailSender_Click(object sender, EventArgs e)
        {
            MailSender f = new MailSender(txbEmail.Text, txbPass.Text);
            f.Show();
        }

        private void btnMailReader_Click(object sender, EventArgs e)
        {
            MailReader f = new MailReader(txbEmail.Text, txbPass.Text);
            f.Show();
        }
    }
}
