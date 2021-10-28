using Configurations;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class MessageDatabaseRepository : IMessageRepository
    {
        private readonly MessageContext messageContext;

        public MessageDatabaseRepository()
        {
            messageContext = new MessageContext();


        }

        public void Add(string message)
        {
            Message msg = new Message() { Msg = message, Time = DateTime.Now };
            messageContext.Messages.Add(msg);
            messageContext.SaveChanges();



        }
    }
}
