using Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class MessageContext: DbContext
    {
        public DbSet<Message> Messages { get; set; }
        private readonly Config config;


        public MessageContext()
        {
            config = ConfigCreate.Create();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(config.DefaultDB);

            }
            base.OnConfiguring(options);

        }

    }
}
