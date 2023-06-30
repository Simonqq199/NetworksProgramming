using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    class Program
    {
        static List<TcpClient> clients = new List<TcpClient>();
        static List<StreamWriter> writers = new List<StreamWriter>();

        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(IPAddress.Any, 6468);
            server.Start();

            Console.WriteLine("Server initialized. Waiting for connections from clients...");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Client connected.");

                // Thêm client mới vào danh sách client
                clients.Add(client);

                // Bắt đầu một luồng mới để xử lý client
                Thread clientThread = new Thread(ClientInteract);
                clientThread.Start(client);
            }
        }

        static void ClientInteract(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream);
            writers.Add(writer);

            StreamReader reader = new StreamReader(stream);

            try
            {
                while (true)
                {
                    string data = reader.ReadLine();

                    // Broadcast dữ liệu nhận được đến tất cả client đã kết nối
                    BroadcastData(data);
                }
            }
            catch (IOException)
            {
                // Xảy ra lỗi khi đọc dữ liệu từ client
                // Xử lý lỗi hoặc đóng kết nối client
                client.Close();
                writers.Remove(writer);
                clients.Remove(client);
                Console.WriteLine("Client disconnected.");
            }
        }

        static void BroadcastData(string data)
        {
            // Gửi dữ liệu đến tất cả client đã kết nối
            foreach (StreamWriter writer in writers)
            {
                writer.WriteLine(data);
                writer.Flush();
            }
        }
    }
}
