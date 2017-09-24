using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Sneaky_Chat
{
    public partial class Connect : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        //NetworkStream serverStream = default(NetworkStream);
        //string readData = null;
        
        public string name;
        
        public Connect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getUserName();
            if (txb_ip.Text == "Entrer l'adresse IP" | txb_ip.Text == "")
            {
                MessageBox.Show("L'addresse IP !!  (bottom right)");
            }
            else
            {
                this.Hide(); 
            }
        }

        public string getUserName()
        {
            name = txb_username.Text;
            return name;
        }
        public string getIpAdr()
        {
            string ip = txb_ip.Text;
            return ip;
        }

        private void txb_ip_Click(object sender, EventArgs e)
        {
            txb_ip.Text = "";
        }

          private void label1_Click(object sender, EventArgs e)
          {

          }
     }
}
