using Configurations;
using Microsoft.Extensions.Configuration;
using System;
using Server;
using Shared;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {

            Config conf = ConfigCreate.Create();
            IMessageRepository messageRepository = new MessageDatabaseRepository();


            Server server = new Server("localhost",9000);
            try
            {
                foreach (string data in server.Receive())
                {
                    messageRepository.Add(data);
                    Console.WriteLine(String.Format("Saved {0} to database", data));


                }
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());

            }




            

          //  Config conf = ConfigCreate.Create();

         //   Console.WriteLine(conf.DefaultDB);




        }
    }
}
