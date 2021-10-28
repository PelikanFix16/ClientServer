using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Shared;

namespace Server
{
    class Server
    {
        private readonly Socket handler;
        private readonly byte[] returnMsg = Encoding.ASCII.GetBytes("OK");


        public Server(string hostName,int port)
        {

            Socket socket = CreateSocket.Create(hostName,port);
            socket.Bind(CreateSocket.endPoint);
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
                if (data.Length > 0)
                {
                    yield return data;
                    data = null;
                    handler.Send(returnMsg);

                    
                }

            }
        }
    }
}
