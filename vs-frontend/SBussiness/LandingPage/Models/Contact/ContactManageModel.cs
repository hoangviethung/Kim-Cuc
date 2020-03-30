using System.ComponentModel.DataAnnotations;
using MainProject.Core;
using MainProject.Core.Commerce;
using MainProject.SBussiness.LandingPage.Models.Contact;
using System.Collections.Generic;
using MainProject.Core.Enums;

namespace MainProject.SBussiness.LandingPage.Models.Contact
{
    public class ContactManageModel
    {
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Content { get; set; }
    }
}   