using Shared;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Client
    {
        private readonly Socket socket;
        private byte[] bytes = new byte[1024];

        public Client(string hostName, int port)
        {
            
            socket = CreateSocket.Create(hostName, port);
            socket.Connect(CreateSocket.endPoint);


        }
        public void Send(string message)
        {
            byte[] msg = Encoding.ASCII.GetBytes(message);
            int bytesSend = socket.Send(msg);


        }

        public string Receive()
        {
            int bytesRec = socket.Receive(bytes);
            return Encoding.ASCII.GetString(bytes,0,bytesRec);

        }
    }
}
