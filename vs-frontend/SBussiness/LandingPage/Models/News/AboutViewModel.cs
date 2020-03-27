using MainProject.Core;
using MainProject.Core.Commerce;
using MainProject.Framework.Helpers;
using MainProject.SBussiness.LandingPage.Models.News;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MainProject.SBussiness.LandingPage.Models.News
{
    public class IntroductionViewModel
    {
        public Category Categorys { get; set; }

        //BLOCK_1
        public Introduction Section1 { get; set; } = new Introduction
        {
            Title = "GIỚI THIỆU VỀ KIM CÚC SPORT",
            Content = "<h2>Chào mừng đến với Kim Cúc Sport!</h2><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia.</p><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia.</p><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia.</p>",
            Image = "/Content/resources/assets/images/about/section-about-1.png"
        };

        //BLOCK_2
        public Introduction Section2 { set; get; } = new Introduction
        {
            Title = "MỤC TIÊU PHÁT TRIỂN KIM CÚC SPORT",
            Image = JsonHelper.Serialize(new List<IntroImage>
            {
                new IntroImage
                {
                    Name = "Tầm nhìn sứ mệnh 1",
                    ImageDefault = "/Content/resources/assets/images/about/target-1.png",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed eiusmod tempor incididunt ut labore et dolore magna"
                },
                new IntroImage
                {
                    Name = "Tầm nhìn sứ mệnh 2",
                    ImageDefault = "/Content/resources/assets/images/about/target-2.png",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed eiusmod tempor incididunt ut labore et dolore magna"
                },
                new IntroImage
                {
                    Name = "Tầm nhìn sứ mệnh 3",
                    ImageDefault = "/Content/resources/assets/images/about/target-3.png",
                    Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed eiusmod tempor incididunt ut labore et dolore magna"
                },
            })
        };

        //BLOCK_3
        public Introduction Section3 { get; set; } = new Introduction
        {
            Title = "PHƯƠNG CHÂM HOẠT ĐỘNG",
            Content = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p><p> Lorem ipsum dolor sit amet,consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam,quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.<p>",
            Image = "/Content/resources/assets/images/about/section-about-3.png"
        };
    };
}