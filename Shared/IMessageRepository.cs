using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public interface IMessageRepository
    {
        public void Add(string message);

    }
}
