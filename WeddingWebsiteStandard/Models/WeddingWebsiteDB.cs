using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WeddingWebsiteStandard.Models
{
    public class WeddingWebsiteDB : DbContext
    {

        DbSet<Announcement> announcements { get; set; }
        DbSet<Message> messages { get; set; }
        DbSet<Guest> guests { get; set; }
        DbSet<GuestContact> guestsContacts { get; set; }
        DbSet<InvitationModel> invitations { get; set; }
        DbSet<GiftModel> gifts { get; set; }

        public System.Data.Entity.DbSet<WeddingWebsiteStandard.Models.GiftModel> GiftModels { get; set; }

        public System.Data.Entity.DbSet<WeddingWebsiteStandard.Models.Message> Messages { get; set; }

        public System.Data.Entity.DbSet<WeddingWebsiteStandard.Models.Guest> Guests { get; set; }
    }
}