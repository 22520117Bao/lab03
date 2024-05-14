using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Collections;

namespace lab3_bai3
{
    public class StatusChangedEventArgs : EventArgs
    {
        // Đối số chúng ta quan tâm là một thông báo mô tả sự kiện
        private string EventMsg;
        // Thuộc tính để truy xuất và thiết lập thông báo sự kiện
        public string EventMessage
        {
            get
            {
                return EventMsg;
            }
            set
            {
                EventMsg = value;
            }
        }
        // Trình xây dựng để thiết lập thông báo sự kiện
        public StatusChangedEventArgs(string strEventMsg)
        {
            EventMsg = strEventMsg;
        }
    }

    // Cần có đại biểu này để chỉ định các tham số chúng tôi sẽ chuyển với sự kiện của mình
    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);

    class ChatServer
    {
        // Bảng băm này lưu trữ người dùng và kết nối (người dùng có thể duyệt được)
        public static Hashtable htUsers = new Hashtable(30); 
    
        public static Hashtable htConnections = new Hashtable(30); 
       
        private IPAddress ipAddress;
        private TcpClient tcpClient;
        // Sự kiện và đối số của nó sẽ thông báo cho biểu mẫu khi người dùng đã kết nối, ngắt kết nối, gửi tin nhắn, v.v.
        public static event StatusChangedEventHandler StatusChanged;
        private static StatusChangedEventArgs e;

        // Hàm tạo đặt địa chỉ IP thành địa chỉ được truy xuất bởi đối tượng khởi tạo
        public ChatServer(IPAddress address)
        {
            ipAddress = address;
        }

        // The thread sẽ giữ trình nghe kết nối
        private Thread thrListener;

        // Đối tượng TCP lắng nghe các kết nối
        private TcpListener tlsClient;

        // Sẽ báo cho vòng lặp while tiếp tục theo dõi các kết nối
        bool ServRunning = false;

      
        public static void AddUser(TcpClient tcpUser, string strUsername)
        {
            string a = strUsername;
            a = "127.0.0.1";
            
            ChatServer.htUsers.Add(a, tcpUser);
            ChatServer.htConnections.Add(tcpUser, a);

            // Thông báo về kết nối mới cho tất cả người dùng khác và biểu mẫu máy chủ
            SendAdminMessage(htConnections[tcpUser] + " đã đăng nhập!");
        }

        
        public static void RemoveUser(TcpClient tcpUser)
        {
            // If the user is there
            if (htConnections[tcpUser] != null)
            {
                // Đầu tiên hiển thị thông tin và thông báo cho những người dùng khác về việc ngắt kết nối
                SendAdminMessage(htConnections[tcpUser] + " đã đăng xuất!");

              
                ChatServer.htUsers.Remove(ChatServer.htConnections[tcpUser]);
                ChatServer.htConnections.Remove(tcpUser);
            }
        }

        // Điều này được gọi khi chúng ta muốn nâng cao sự kiện StatusChanged
        public static void OnStatusChanged(StatusChangedEventArgs e)
        {
            StatusChangedEventHandler statusHandler = StatusChanged;
            if (statusHandler != null)
            {
                
                statusHandler(null, e);
            }
        }

        // Send administrative messages
        public static void SendAdminMessage(string Message)
        {
            StreamWriter swSenderSender;

            // admin thông báo có client kết nối
            e = new StatusChangedEventArgs("Administrator: " + Message);
            OnStatusChanged(e);

          
            TcpClient[] tcpClients = new TcpClient[ChatServer.htUsers.Count];
          
            ChatServer.htUsers.Values.CopyTo(tcpClients, 0);
        
            for (int i = 0; i < tcpClients.Length; i++)
            {
                // gửi các mess 
                try
                {
                    // nếu không có mess thì bỏ qua 
                    if (Message.Trim() == "" || tcpClients[i] == null)
                    {
                        continue;
                    }
                   
                    swSenderSender = new StreamWriter(tcpClients[i].GetStream());
                    swSenderSender.WriteLine("Administrator: " + Message);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch 
                {
                    RemoveUser(tcpClients[i]);
                }
            }
        }

        // phàn gửi tin nhắn 
        public static void SendMessage(string From, string Message)
        {
            StreamWriter swSenderSender;
            string a = "127.0.0.1";
          
            e = new StatusChangedEventArgs(a + " gửi: " + Message);
            OnStatusChanged(e);

  
            TcpClient[] tcpClients = new TcpClient[ChatServer.htUsers.Count];
          
            ChatServer.htUsers.Values.CopyTo(tcpClients, 0);
           
            for (int i = 0; i < tcpClients.Length; i++)
            {
               
                try
                {
                   
                    if (Message.Trim() == "" || tcpClients[i] == null)
                    {
                        continue;
                    }
                   
                    From = a;
                    swSenderSender = new StreamWriter(tcpClients[i].GetStream());
                    swSenderSender.WriteLine(From + Message);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch 
                {
                    RemoveUser(tcpClients[i]);
                }
            }
        }

        public void StartListening()
        {

            IPAddress ipaLocal = ipAddress;

            tlsClient = new TcpListener(ipaLocal, 1986);

            tlsClient.Start();

            ServRunning = true;

            thrListener = new Thread(KeepListening);
            thrListener.Start();
        }

        private void KeepListening()
        {
            while (ServRunning == true)
            {
                tcpClient = tlsClient.AcceptTcpClient();
                Connection newConnection = new Connection(tcpClient);
            }
        }
    }

    class Connection
    {
        TcpClient tcpClient;
        private Thread thrSender;
        private StreamReader srReceiver;
        private StreamWriter swSender;
        private string currUser;
        private string strResponse;

        public Connection(TcpClient tcpCon)
        {
            tcpClient = tcpCon;
            thrSender = new Thread(AcceptClient);
            thrSender.Start();
        }
        // đóng kết nối 
        private void CloseConnection()
        {
            try
            {
                while ((strResponse = srReceiver.ReadLine()) != "")
                {
                    if (strResponse == null)
                    {
                        ChatServer.RemoveUser(tcpClient);
                    }
                    else
                    {
                        ChatServer.SendMessage(currUser, strResponse);
                    }
                }
            }
            catch
            {
                ChatServer.RemoveUser(tcpClient);
            }
            tcpClient.Close();
            srReceiver.Close();
            swSender.Close();
        }

        // chấp nhận kết nối 
        private void AcceptClient()
        {
            srReceiver = new System.IO.StreamReader(tcpClient.GetStream());
            swSender = new System.IO.StreamWriter(tcpClient.GetStream());

            currUser = srReceiver.ReadLine();

            if (currUser != "")
            {
                if (ChatServer.htUsers.Contains(currUser) == true)
                {
                    swSender.WriteLine("0|This username already exists.");
                    swSender.Flush();
                    CloseConnection();
                    return;
                }
                else if (currUser == "Administrator")
                {
                    swSender.WriteLine("0|This username is reserved.");
                    swSender.Flush();
                    CloseConnection();
                    return;
                }
                else
                {
                    swSender.WriteLine("1");
                    swSender.Flush();

                    ChatServer.AddUser(tcpClient, currUser);
                }
            }
            else
            {
                CloseConnection();
                return;
            }

            try
            {
                while ((strResponse = srReceiver.ReadLine()) != "")
                {
                    if (strResponse == null)
                    {
                        ChatServer.RemoveUser(tcpClient);
                    }
                    else
                    {
                        ChatServer.SendMessage(currUser, strResponse);
                    }
                }
            }
            catch
            {
                ChatServer.RemoveUser(tcpClient);
            }
        }
    }
}
