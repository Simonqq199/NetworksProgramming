using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace networksLAB03
{
    public partial class Form4 : Form
    {
        private delegate void InfoMessageDel(String info);
        public Form4()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void serverThread()
        {
            try
            {
                UdpClient udpClient = new UdpClient(int.Parse(ServerPortB1.Text));
                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    string mess = RemoteIpEndPoint.Address.ToString() + ": " +
                        returnData.ToString();
                    InfoMessage(mess);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void InfoMessage(String info)
        {
            if (messagelist1.InvokeRequired)
            {
                InfoMessageDel method = new InfoMessageDel(InfoMessage);
                messagelist1.Invoke(method, new object[] { info });
                return;
            }
            messagelist1.Items.Add(info);
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
