using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {


            Client client = new Client("localhost", 9000);

            while (true)
            {
                Console.Write("Send: ");
                string text = Console.ReadLine();
                client.Send(text);
                Console.Write("Received: ");
                string received = client.Receive();
                Console.WriteLine(received);

            }



        }
    }
}
