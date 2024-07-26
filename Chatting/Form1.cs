using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatting
{
    public partial class Form1 : Form
    {
        private User user;
        public Form1()
        {
            InitializeComponent();
            user = new User(1234);
            user.MessageReceived += User_MessageReceived;
            user.recentMessage();
        }

        private void User_MessageReceived(string message)
        {
            chat.AppendText("Recibido: " + message + Environment.NewLine);
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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
