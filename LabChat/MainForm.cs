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
using System.Runtime.InteropServices;
using System.Collections;
using System.DirectoryServices;
using System.Net;
using ComponentFactory.Krypton.Toolkit;



namespace Sneaky_Chat
{
    public partial class MainForm : KryptonForm
    {
        TcpClient clientSocket = new TcpClient();
        public string username;

        public MainForm()
        {
            InitializeComponent();
        } 

        private void MainForm_Load(object sender, EventArgs e)
        {
               //We retrieve the data that the user entered in the field 'username'
               Connect infoUser = new Connect();
            infoUser.ShowDialog();               
            username = infoUser.getUserName();
            string serverIP = infoUser.getIpAdr();

               //The user is automatically assigned the name 'User' if he has not entered the 'username' text box
               if (username == "")
            {
                username = "User";
            }

               //Header message, displays the name of the user and the IP address on which it is connoted.
               string ConnectedNotif = "You are now connected as [ " + username + " ] on the local network \n \n IP : [ " +  serverIP + " ]";
            lbl_user.Text = ConnectedNotif;

               //Connection with server
               msg("Connected.");           
            clientSocket.Connect(serverIP, 8888);

               //Send the username
               NetworkStream serverStream = clientSocket.GetStream();
            byte[] outTextStream = Encoding.ASCII.GetBytes(" >> " + username + "$");
            serverStream.Write(outTextStream, 0, outTextStream.Length);
            serverStream.Flush();
            txb_user.Focus();

            //Reception message
            byte[] inStream = new byte[10025];
            //serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            serverStream.Read(inStream, 0, inStream.Length);
            string returndata = Encoding.ASCII.GetString(inStream);

            msg(returndata);
            timer1.Enabled = true;
        }
   
        public void msg(string mesag)
        {
            lbox_maindisplay.Items.Add(mesag);  
        }

        
        private void btn_send_Click(object sender, EventArgs e)
        {
            string message = txb_user.Text;

            //Envoi Message
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outTextStream = Encoding.ASCII.GetBytes(message + "$");
            serverStream.Write(outTextStream, 0, outTextStream.Length);
            serverStream.Flush();

            txb_user.Focus();
            txb_user.Clear();
        }

        public void receiveMessage()
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] inStream = new byte[10025];
            if (serverStream.DataAvailable == true)
            {
                //serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                serverStream.Read(inStream, 0, inStream.Length);
                string returndata = Encoding.ASCII.GetString(inStream);
                msg(returndata);
                txb_user.Focus();
            }
        }

          //With the timer, the program analyzes the data flow to see if there is an incoming data flow.
          private void timer1_Tick(object sender, EventArgs e)
        {
            receiveMessage();
        }

        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            clientSocket.Client.Shutdown(SocketShutdown.Both);
        }
    }
}
