using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace networksLAB03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void HostIP_Click(object sender, EventArgs e)
        {
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(textHostIP.Text, int.Parse(textPort.Text));
            Byte[] senddata = Encoding.ASCII.GetBytes(textMessage.Text);
            udpClient.Send(senddata, senddata.Length);
            udpClient.Close();
        }

        private void textHostIP_TextChanged(object sender, EventArgs e)
        {
        }

        private void textPort_TextChanged(object sender, EventArgs e)
        {
        }

        private void textMessage_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
