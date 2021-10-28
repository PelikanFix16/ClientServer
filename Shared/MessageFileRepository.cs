using Configurations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Shared
{
    public class MessageFileRepository : IMessageRepository
    {
        private readonly Config config;
        public MessageFileRepository()
        {
            config = ConfigCreate.Create();

        }

        public void Add(string message)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, config.File);
            using (FileStream fs = new FileStream(path,FileMode.Append,FileAccess.Write))      
                using (TextWriter file = new StreamWriter(fs))
                {
                    file.WriteLine(String.Format("Message: {0} Time: {1}", message, DateTime.Now));

                }
            
        }
    }
}
