using System;
using Microsoft.Extensions.Configuration;


namespace Configurations
{
    public static class ConfigCreate
    {
        private static IConfiguration config;
        private static Config configObject;

       static ConfigCreate()
        {
            config = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json")
               .Build();
            configObject = new Config();


        }

        public static Config Create()
        {

            config.Bind("Config", configObject);

            return configObject;



        }
    }
}
