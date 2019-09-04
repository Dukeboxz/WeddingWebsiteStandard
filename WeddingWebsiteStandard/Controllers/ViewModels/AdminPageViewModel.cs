using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeddingWebsiteStandard.Models;

namespace WeddingWebsiteStandard.Controllers.ViewModels
{
    public class AdminPageViewModel
    {


        public IEnumerable<Guest>  ListOfGuests {get; set;}

        public IEnumerable<InvitationModel> LisOfInvitations { get; set; }

        public IEnumerable<GiftModel> ListOfGifts { get; set; }


    }
}