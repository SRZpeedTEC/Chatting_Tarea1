using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Windows.Forms;

namespace Chatting
{
    class User
    {
        public int portUser { get; set; }
        TcpListener userLog;

        public event Action<string> MessageReceived;

        public User(int portLog)
        {
            portUser = portLog;
        }
        public async void connectionChat()
        {
            userLog = new TcpListener(IPAddress.Any, portUser);
            userLog.Server.ExclusiveAddressUse = false;
            userLog.Start();

            while (true)
            {

                TcpClient contact = await userLog.AcceptTcpClientAsync();
                _ = recentChat(contact);

            }

        }
        public async Task recentChat(TcpClient contact)
        {
            using (NetworkStream stream = contact.GetStream())
            {
                byte[] buffer = new byte[1024];
                int bytesRead;


                while (true)
                {
                    bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    MessageReceived?.Invoke(message);
                }
            }
            contact.Close();
        }

        public async Task SendMessage(string message, string ipAddr, int port, int portUser)
        {
            try
            {
                string informativePort = $"desde {portUser}: {message}";
                byte[] data = Encoding.UTF8.GetBytes(informativePort);

                using (TcpClient contact = new TcpClient(ipAddr, port))
                using (NetworkStream stream = contact.GetStream())

                {
                    await stream.WriteAsync(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}