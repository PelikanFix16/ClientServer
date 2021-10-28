using Configurations;
using Shared;
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

            Config config = ConfigCreate.Create();
            
            Client client = new Client(config.Address, config.Port);
            IMessageRepository messageRepository = new MessageFileRepository();


            while (true)
            {
                Console.Write("Send: ");
                string text = Console.ReadLine();
                client.Send(text);
                Console.Write("Received: ");
                string received = client.Receive();
                Console.WriteLine(received);
                messageRepository.Add(received);



            }



        }
    }
}
