using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class MessageModel
    {
        public string id { get; set; }

        public string messageText { get; set; }

        public DateTime createdAT { get; set; }
        public DateTime updatedAT { get; set; }
    }
}