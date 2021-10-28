using Configurations;
using Microsoft.Extensions.Configuration;
using System;
using Server;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {

            Server server = new Server("localhost",9000);

            foreach(string data in server.Receive())
            {
                Console.WriteLine(data);

            }





          //  Config conf = ConfigCreate.Create();

         //   Console.WriteLine(conf.DefaultDB);




        }
    }
}
