using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public class DataClient
    {
        private TcpListener listener;
        private const int BufferSize = 4096;

        public DataClient(int port)
        {
            listener = new TcpListener(IPAddress.Any, port);
        }

        public void Start()
        {
            Task.Run(() => RunServer());
        }

        private void RunServer()
        {
            listener.Start();
            Console.WriteLine("Client-as-Server started. Waiting for connections...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Task.Run(() => HandleClient(client));
            }
        }

        private void HandleClient(TcpClient client)
        {
            Console.WriteLine($"Client connected: {((IPEndPoint)client.Client.RemoteEndPoint).Address}");

            NetworkStream stream = client.GetStream();
            SendFile("output5.txt", stream);
            ReceiveFile("output5.txt", stream);
            // Close connection
            stream.Close();
            client.Close();
        }

        private void SendFile(string filepath, NetworkStream stream)
        {

            byte[] fileBytes = File.ReadAllBytes(filepath);
            stream.Write(fileBytes, 0, fileBytes.Length);
        }

        private void ReceiveFile(string filepath, NetworkStream stream)
        {

            byte[] fileSizeBuffer = new byte[4];
            stream.Read(fileSizeBuffer, 0, 4);
            int fileSize = BitConverter.ToInt32(fileSizeBuffer, 0);
            if (fileSize == 0)
            {
                return;
            }
            byte[] buffer = new byte[fileSize];
            int bytesRead = 0;
            while (bytesRead < fileSize)
            {
                int bytesToRead = Math.Min(fileSize - bytesRead, BufferSize);
                int received = stream.Read(buffer, bytesRead, bytesToRead);
                bytesRead += received;
            }

            File.WriteAllBytes(filepath, buffer);
        }
    }
}
