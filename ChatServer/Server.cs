using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Net;

namespace Chat_Server
{
    class Program
    {
        public static Hashtable clientsList = new Hashtable();
        public static TcpListener serverSocket;
        public static TcpClient clientSocket;
        public static HandleClient client;

        
        static string getMyIP()
        {
            string myHost = Dns.GetHostName();
            string myIP = null;
            for (int i = 0; i <= Dns.GetHostEntry(myHost).AddressList.Length - 1; i++)
            {
                if (Dns.GetHostEntry(myHost).AddressList[i].IsIPv6LinkLocal == false)
                {
                    myIP = Dns.GetHostEntry(myHost).AddressList[i].ToString();
                }
            }
            return myIP;
        }




        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(IPAddress.Any,8888);
            //TcpClient clientSocket = default(TcpClient);
            int counter = 0;
            
            serverSocket.Start();
            Console.WriteLine("Sneaky Chat Server Started...  \n Copyright 2014 - 2020 Welsen \n10 users max.\nClient users must connect to this IP address  - > [ " + getMyIP() + " ]");
            getMyIP();

            counter = 0;
            while (true)
            {
                counter += 1;

                    //Create a new client connection
                    clientSocket = serverSocket.AcceptTcpClient();

                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;

                    //Read the data sent by the customer
                    NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                //networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                dataFromClient = dataFromClient.Trim('\0');

                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                
                clientsList.Add(dataFromClient, clientSocket);

                broadcast(dataFromClient + " joined the discussion", dataFromClient, false);

                Console.WriteLine(dataFromClient + " joined the chat room");

                client = new HandleClient();
                client.startClient(clientSocket, dataFromClient, clientsList);

                if (clientSocket.Available < 1 && counter > 10)
                {
                    disconnectClient(clientSocket);
                }           
            }         
        }

        public static void broadcast(string msg, string uName, bool flag)
        {
            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null;
                
                if (flag == true)
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(uName + ": " + msg);
                }
                else
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(msg);
                }
                
                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
            }
        }  //end broadcast function


        public static void disconnectClient(TcpClient clientToDisconnect)
        {
               //We stop the connection with the client who disconnected
               clientToDisconnect.Close();
            clientToDisconnect.Client.Dispose();

               //It is removed from the client dictionary
               foreach (DictionaryEntry Item in clientsList)
            {
                if (Item.Value == clientToDisconnect)
                    clientsList.Remove(clientToDisconnect);
            }
        }
    }//end Main class
}//end namespace