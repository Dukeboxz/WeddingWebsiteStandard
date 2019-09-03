using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeddingWebsiteStandard.Models
{
    public class GiftModel
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public int numberAvailable { get; set; }

        public GiftModel(int id, string name, string description, int numberAvailable)
        {
            Id = id;
            this.name = name;
            this.description = description;
            this.numberAvailable = numberAvailable;
        }
    }
}