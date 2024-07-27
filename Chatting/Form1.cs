using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Chatting
{
    public partial class Form1 : Form
    {
        private User userMain;
        public const int userPort = 5562;
        public Form1()
        {
            InitializeComponent();
            userMain = new User(userPort);
            userMain.MessageReceived += User_MessageReceived;
            userMain.connectionChat();
            dataLog(userPort);
            portText.KeyPress += new KeyPressEventHandler(portText_KeyPress);
        }

        private void User_MessageReceived(string message)
        {
            this.Invoke((MethodInvoker)delegate
            {
                chatBox.AppendText($"Recibido {message}{Environment.NewLine}");
            });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string message = messageText.Text;
            int port = int.Parse(portText.Text);
            string ipAddr = "127.0.0.1";
            string portTextValue = portText.Text;

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Por favor, ingrese un mensaje.", "Mensaje vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(portTextValue, out port) || port < 1024 || port > 65535)
            {
                MessageBox.Show("Por favor, ingrese un número de puerto válido (entre 1024 y 65535).", "Puerto inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (port == userPort)
            {
                MessageBox.Show("Por favor, ingrese un puerto diferente al suyo.", "Puerto inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await userMain.SendMessage(message, ipAddr, port, userPort);

            chatBox.AppendText($"Enviado: {message}{Environment.NewLine}");
            messageText.Clear();

        }

        private void portText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }

        }
        private void dataLog(int portInfo)
        {
            portUser.AppendText($"Su puerto es: {userPort}");
            
        }  
 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
    
        private void chat_TextChanged(object sender, EventArgs e)
        {

        }

        private void portUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void portText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
