using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeddingWebsiteStandard.Models
{
    public class Announcement
    {
        public int Id { get; set; }

        public string announceText { get; set; }

        public DateTime timeOfAnnoucement { get; set; }

        public DateTime relevantUntil { get; set; }

        public bool allGuests { get; set; }

        public bool henDo { get; set; }

        public bool stagDo { get; set; }
    }
}