using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeddingWebsiteStandard.Models
{
    public class InvitationModel
    {
        public int Id { get; set; }

        public GuestContact sentTo { get; set; }

        public ICollection<Guest> guestOnInvite { get; set; }

        public string passCode { get; set; }

    }
}