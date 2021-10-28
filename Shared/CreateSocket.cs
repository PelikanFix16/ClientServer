using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Shared
{
    public static class CreateSocket
    {
        public static IPEndPoint endPoint { get; private set; }

        public static Socket Create(string hostName, int port)
        {
            IPHostEntry host = Dns.GetHostEntry(hostName);
            IPAddress address = host.AddressList[0];
            endPoint = new IPEndPoint(address, port);
            Socket socket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            return socket;

        }

       
    }
}
