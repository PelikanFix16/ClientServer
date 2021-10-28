using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Server
    {
        private readonly Socket handler;




        
        public Server(string hostName,int port)
        {
            IPHostEntry host = Dns.GetHostEntry(hostName);
            IPAddress address = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(address, port);
            Socket socket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(localEndPoint);
            socket.Listen(10);
            handler = socket.Accept();

        }

        public IEnumerable<string> Receive()
        {
            string data = null;
            byte[] bytes = null;

            while (true)
            {
                bytes = new byte[1024];
                int bytesRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.IndexOf("<EOF>") > -1)
                {
                    yield return data;

                }

            }
        }
    }
}
