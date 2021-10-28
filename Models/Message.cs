using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{

    public class Message
    {

        public int Id { get; set; }
        public string Msg { get; set; }
        public DateTime Time { get; set; }
        

    }
}
