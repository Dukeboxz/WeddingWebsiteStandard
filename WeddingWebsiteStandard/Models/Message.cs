using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeddingWebsiteStandard.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string messageText { get; set; }

        public DateTime TimeOfMessage { get; set; }

        public Guest guest { get; set; }
    }
}