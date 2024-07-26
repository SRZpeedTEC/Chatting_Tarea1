using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Chatting
{
    class User 
    {   
        public int portUser { get; set; }
        TcpListener user;

        public event Action<string> MessageReceived;

        public User(int port)
        {
            portUser = port;
        }   
        
        public async void recentMessage()
        {
            user = new TcpListener(IPAddress.Any, portUser);
            user.Start();

            while (true) { 

                TcpClient contact = await user.AcceptTcpClientAsync();
                OpenChats(contact);
            
            }

        }
        private async void OpenChats(TcpClient contact)
        {
            NetworkStream stream = contact.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                {
                    break;
                }
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                MessageReceived?.Invoke(message);
            }
            contact.Close();
        }
    }
}
