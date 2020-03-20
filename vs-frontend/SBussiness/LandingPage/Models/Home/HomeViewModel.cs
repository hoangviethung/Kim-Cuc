using MainProject.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MainProject.SBussiness.LandingPage.Models.Home
{
    public class HomeViewModel
    {
        public Category Category { get; set; } = new Category
        {
            Title = "HomePage"
        };
    }

    public class HeaderViewModel
    {
        public List<Banner> Banners { get; set; } = new List<Banner>
        {
            new Banner
            {
                Name = "Banner1",
                ResourcePath = "http://web4gsolutions.com/Content/layout/resources/images/logo.png"
            },
            new Banner
            {
                Name = "Banner1",
                ResourcePath = "http://web4gsolutions.com/Content/layout/resources/images/logo.png"
            }
        };
    }

    public class FooterViewModel
    {
        public Branch Branch { get; set; } = new Branch
        {
            OfficeName = "Văn phòng chính",
            Address = "192/68 Nguyễn Oanh, ....",
            AddressMap = "iframe or some format text show on map"
        };
    }

    public class SubscribeModel
    {
        [Required]
        public string Email { get; set; }
    }
}