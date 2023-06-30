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
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NT106_Lab06
{
    public partial class Client : Form
    {
        public Point end = new Point();
        public Point start = new Point();
        public Pen p;
        bool draw = false;
        string color;
        Graphics graphics;
        Bitmap bmp;
        TcpClient client;
        NetworkStream stream;
        StreamWriter writer;
        StreamReader reader;
        Thread receiveThread;

        public Client()
        {
            InitializeComponent();
            Initialize();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        void Initialize()
        {
            graphics = pictureBox1.CreateGraphics();
            comboBox1.Text = "8";
            color = "#000000";
            textBox1.Text = color;
            Canvas();

            // Kết nối đến server
            client = new TcpClient();
            client.Connect("127.0.0.1", 6468);
            // Thiết lập luồng mạng và các object đọc/ghi
            stream = client.GetStream();
            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);

            // Bắt đầu một luồng mới để liên tục nhận dữ liệu vẽ từ server
            receiveThread = new Thread(ReceiveDrawingData);
            receiveThread.Start();
        }

        void Canvas()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bmp);
            pictureBox1.BackgroundImage = bmp;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;

            start = e.Location;

            int size;

            if (comboBox1.Text == "")
            {
                size = 8;
            }
            else
            {
                size = Convert.ToInt32(comboBox1.Text);
            }

            Color newColor = ColorTranslator.FromHtml(color);
            p = new Pen(newColor, size);
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            // Gửi event bấm chuột đến server
            writer.WriteLine($"MOUSE_DOWN|{start.X}|{start.Y}");
            writer.Flush();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                if (e.Button == MouseButtons.Left)
                {
                    end = e.Location;
                    graphics.DrawLine(p, start, end);
                    start = end;
                    pictureBox1.Invalidate();

                    // Gửi event di chuột đến server
                    writer.WriteLine($"MOUSE_MOVE|{end.X}|{end.Y}");
                    writer.Flush();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;

            // Gửi event thả chuột đến server
            writer.WriteLine("MOUSE_UP");
            writer.Flush();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas();

            // Gửi event xóa bảng vẽ đến server
            writer.WriteLine("CLEAR_CANVAS");
            writer.Flush();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                color = "#" + (cd.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                textBox1.Text = color;

                // Gửi event thay đổi màu đến server
                writer.WriteLine($"COLOR_CHANGE|{color}");
                writer.Flush();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files| *.png|jpeg files| *.jpg|bitmaps | *.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ngắt kết nối với server và đóng ứng dụng
            DisconnectFromServer();
            Application.Exit();
        }

        private void ReceiveDrawingData()
        {
            while (client.Connected)
            {
                try
                {
                    string data = reader.ReadLine();

                    // Phân tích dữ liệu nhận được và cập nhật bảng vẽ local tương ứng
                    string[] tokens = data.Split('|');
                    string eventType = tokens[0];

                    if (eventType == "MOUSE_DOWN")
                    {
                        int x = int.Parse(tokens[1]);
                        int y = int.Parse(tokens[2]);
                        start = new Point(x, y);
                    }
                    else if (eventType == "MOUSE_MOVE")
                    {
                        int x = int.Parse(tokens[1]);
                        int y = int.Parse(tokens[2]);
                        end = new Point(x, y);
                        graphics.DrawLine(p, start, end);
                        start = end;
                        pictureBox1.Invalidate();
                    }
                    else if (eventType == "MOUSE_UP")
                    {
                        draw = false;
                    }
                    else if (eventType == "CLEAR_CANVAS")
                    {
                        Canvas();
                    }
                    else if (eventType == "COLOR_CHANGE")
                    {
                        color = tokens[1];
                        textBox1.Text = color;
                    }
                }
                catch (IOException)
                {
                    // Xảy ra lỗi khi đọc dữ liệu từ luồng
                    break;
                }
            }
        }

        private void DisconnectFromServer()
        {
            // Đóng tất cả các tài nguyên mạng
            writer.Close();
            reader.Close();
            stream.Close();
            client.Close();

            // Kết thúc luồng nhận (đợi nó kết thúc) trước khi đóng form
            receiveThread.Join();
        }
        
    }

}