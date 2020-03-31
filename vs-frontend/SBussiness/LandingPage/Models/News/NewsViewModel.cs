using MainProject.Core;
using MainProject.Core.Commerce;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MainProject.SBussiness.LandingPage.Models.News
{
    public class NewsViewModel
    {
        public Category Category { get; set; } = new Category
        {
            Title = "TIN TỨC - SỰ KIỆN"
        };
        //DANH SÁCH TIN TỨC NỔI BẬT ASIDE MENU
        public List<Article> HotNews { get; set; } = new List<Article>
        {
            new Article
            {
                Title = "Tin tức nổi bật 1"
            },
            new Article
            {
                Title = "Tin tức nổi bật 2"
            },
            new Article
            {
                Title = "Tin tức nổi bật 3"
            },
            new Article
            {
                Title = "Tin tức nổi bật 4"
            },
            new Article
            {
                Title = "Tin tức nổi bật 5"
            },
            new Article
            {
                Title = "Tin tức nổi bật 6"
            },
            new Article
            {
                Title = "Tin tức nổi bật 7"
            },
            new Article
            {
                Title = "Tin tức nổi bật 8"
            }
        };
        //DANH SÁCH TIN TỨC
        public List<Article> Articles { get; set; } = new List<Article>
        {
            new Article {
                    Id = 001,
                    Title = "Tin tức nổi bật của Kim Cúc Sports",
                    ImageDefault = "/Content/resources/assets/images/news/home-news/1.png",
                    Order = System.DateTime.Now,
                    ViewCount = 100,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, and when an unknown printer took a galley of type and scrambled it to make a type made specimen book. It has survived not only five centuries, but also the leap into and type electronic typesetting, remaining essentially unchanged.",
                    ExternalUrl = "/news/detail",
            },
            new Article {
                    Id = 002,
                    Title = "Tin tức bình thường của Kim Cúc Sports",
                    ImageDefault = "/Content/resources/assets/images/news/home-news/2.png",
                    Order = System.DateTime.Now,
                    ViewCount = 170,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, and when an unknown printer took a galley of type and scrambled it to make a type made specimen book. It has survived not only five centuries, but also the leap into and type electronic typesetting, remaining essentially unchanged.",
                    ExternalUrl = "/news/detail",
            },
            new Article {
                    Id = 003,
                    Title = "Tin tức bình thường của Kim Cúc Sports",
                    ImageDefault = "/Content/resources/assets/images/news/home-news/3.png",
                    Order = System.DateTime.Now,
                    ViewCount = 99,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, and when an unknown printer took a galley of type and scrambled it to make a type made specimen book. It has survived not only five centuries, but also the leap into and type electronic typesetting, remaining essentially unchanged.",
                     ExternalUrl = "/news/detail",
            },
            new Article {
                    Id = 004,
                    Title = "Tin tức nổi bật của Kim Cúc Sports",
                    ImageDefault = "/Content/resources/assets/images/news/news-others/1.png",
                    Order = System.DateTime.Now,
                    ViewCount = 100,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, and when an unknown printer took a galley of type and scrambled it to make a type made specimen book. It has survived not only five centuries, but also the leap into and type electronic typesetting, remaining essentially unchanged.",
                     ExternalUrl = "/news/detail",
            },
            new Article {
                    Id = 005,
                    Title = "Tin tức bình thường của Kim Cúc Sports",
                    ImageDefault = "/Content/resources/assets/images/news/news-others/1.png",
                    Order = System.DateTime.Now,
                    ViewCount = 170,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, and when an unknown printer took a galley of type and scrambled it to make a type made specimen book. It has survived not only five centuries, but also the leap into and type electronic typesetting, remaining essentially unchanged.",
                     ExternalUrl = "/news/detail",
            },
            new Article {
                    Id = 006,
                    Title = "Tin tức bình thường của Kim Cúc Sports",
                    ImageDefault = "/Content/resources/assets/images/news/news-others/1.png",
                    Order = System.DateTime.Now,
                    ViewCount = 99,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, and when an unknown printer took a galley of type and scrambled it to make a type made specimen book. It has survived not only five centuries, but also the leap into and type electronic typesetting, remaining essentially unchanged.",
            },
            new Article {
                    Id = 007,
                    Title = "Tin tức bình thường của Kim Cúc Sports",
                    ImageDefault = "/Content/resources/assets/images/news/news-others/1.png",
                    Order = System.DateTime.Now,
                    ViewCount = 99,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, and when an unknown printer took a galley of type and scrambled it to make a type made specimen book. It has survived not only five centuries, but also the leap into and type electronic typesetting, remaining essentially unchanged.",
                     ExternalUrl = "/news/detail",
            }
        };
    };
}