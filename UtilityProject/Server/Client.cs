using System;
using System.Text;
using System.Net.Sockets;

namespace UtilityProject.Server
{
    public class Client
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // Framework code

        public static void ConnectToServer(string ip, int port)
        {
            LoopConnect(ip, port);
            Console.ReadLine();
        }

        public static void SendPacket(string message)
        {
            SendLoop(message);
        }

        // Client code

        private static void SendLoop(string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            _clientSocket.Send(buffer);

            byte[] receivedBuf = new byte[1024];
            int rec = _clientSocket.Receive(receivedBuf);
            byte[] data = new byte[rec];
            Array.Copy(receivedBuf, data, rec);
            Console.WriteLine("Received: " + Encoding.ASCII.GetString(data));      
        }

        private static void LoopConnect(string ip, int port)
        {
            int attempts = 0;

            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(ip, port);
                }
                catch (SocketException)
                {
                    Console.WriteLine("Connection attempts: " + attempts.ToString());
                }
            }

            Console.Clear();
            Console.WriteLine("Connected");
        }
    }
}
