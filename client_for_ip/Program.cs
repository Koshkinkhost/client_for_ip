using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace client_for_ip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ip = "192.168.51.20";
            //IPAddress adress = IPAddress.Parse("192.168.51.203");
            //IPEndPoint ep = new IPEndPoint(adress, 8001);
            //Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //s.Connect(ep);
            //string msg = "Message from Boris!";
            //var data = Encoding.UTF8.GetBytes(msg);
            //s.Send(data);        
            //s.Close();
            string mes = "123";
            string ip = "192.168.56.1";
            string port = "8001";
            byte[] data = Encoding.Unicode.GetBytes(mes);

            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(port));
            s.SendTo(data, ep);
        }
    }
}
