using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeddingWebsiteStandard.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string  firstName { get; set; }
        public string secondName { get; set; }
        public string email { get; set; }
        public bool isAdmin { get; set; }
        public bool inWeddingPart { get; set; }
        public bool isAdult { get; set; }

        public bool henDo { get; set; }

        public bool stagDo { get; set; }

    }
}