using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string IPserver = "10.1.116.239";//loop back address and this is teacher computer in classRoom
            //string serverTest="127.0.0.1";//testServer
            
            int servPort=5000;

            string message = "5808575 Wongsatron";
            
            byte[] sendPacket=Encoding.ASCII.GetBytes(message);

            UdpClient client = new UdpClient();

            try
            {
                client.Send(sendPacket,sendPacket.Length,IPserver,servPort);
            }
            catch(SocketException e)
            {
                Console.WriteLine(e.ErrorCode+" "+e.Message);
            }
        }
    }
}
