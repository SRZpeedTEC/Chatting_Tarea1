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
    public partial class StartupForm : Form
    {
        public int userPort { get; private set; }
        public StartupForm()
        {
            InitializeComponent();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUserPort.Text, out int port) && port >= 1024 && port <= 65535)
            {
                userPort = port;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de puerto válido (entre 1024 y 65535).", "Puerto inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
