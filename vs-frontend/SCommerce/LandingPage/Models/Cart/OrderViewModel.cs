using System.ComponentModel.DataAnnotations;
using MainProject.Core;
using MainProject.Core.Commerce;
using MainProject.SBussiness.LandingPage.Models.Contact;
using System.Collections.Generic;
using MainProject.Core.Enums;

namespace MainProject.SCommerce.LandingPage.Models.Cart
{
    public class OrderViewModel
    {
        public string Name { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}