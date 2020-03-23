using MainProject.Core;
using MainProject.Core.Commerce;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MainProject.SBussiness.LandingPage.Models.Home
{
    //MODEL CỦA TRANG CHỦ
    public class HomeViewModel
    {
        //DANH SÁCH ẢNH NHÀ TÀI TRỢ
        public List<Banner> Distributor { get; set; } = new List<Banner>
        {
             new Banner
            {
                ResourcePath = "/Content/resources/assets/images/distributor/1.png",
                Alt = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/distributor/2.png",
                Alt = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/distributor/3.png",
                Alt = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/distributor/4.png",
                Alt = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/distributor/5.png",
                Alt = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            }
        };
        //DANH SÁCH SẢN PHẨM HOT
        public List<Product> HotProduct { get; set } = new List<Product>
        {
            new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "111",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault = "",
            }
        };
    }

    //MODEL CỦA HEADER
    public class HeaderViewModel
    {
        //DANH SÁCH ẢNH BANNER
        public List<Banner> Banners { get; set; } = new List<Banner>
        {
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/home-banner.png",
                Alt = "BANNER QUẢNG CÁO 1",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/home-banner.png",
                Alt = "BANNER QUẢNG CÁO 2",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/home-banner.png",
                Alt = "BANNER QUẢNG CÁO 3",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/home-banner.png",
                Alt = "BANNER QUẢNG CÁO 4",
            }
        };
    }

    //MODEL CỦA FOOTER
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