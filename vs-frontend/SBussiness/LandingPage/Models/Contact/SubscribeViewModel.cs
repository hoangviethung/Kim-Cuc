using System.ComponentModel.DataAnnotations;
using MainProject.Core;
using MainProject.Core.Commerce;
using MainProject.SBussiness.LandingPage.Models.Contact;
using System.Collections.Generic;
using MainProject.Core.Enums;

namespace MainProject.SBussiness.LandingPage.Models.SubscribeViewModel
{
    public class ContactManagement
    {
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string ContactContent { get; set; }
    }
}   