using MainProject.Core;
using MainProject.Core.Commerce;
using MainProject.SBussiness.LandingPage.Models.Contact;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MainProject.Core.Enums;

namespace MainProject.SBussiness.LandingPage.Models.Contact
{
    public class ContactViewModel
    {
        public Category Categorys { get; set; }
        //DANH DÁCH TITLE TRANG LIÊN HỆ
        public List<Category> ListTitle = new List<Category>
        {
             new Category
            {
                Title = "THÔNG TIN LIÊN HỆ"
            },
              new Category
            {
                Title = "LIÊN LẠC VỚI CHÚNG TÔI"
            },
        };
        //DANH SÁCH THÔNG TIN CỦA CÔNG TY
        public List<Branch> Branch { get; set; } = new List<Branch>
        {
            new Branch
            {
                Phone = "0906.523.876",
                Email = "kimcucsport@gmail.com",
                Address = "133 - 143 Hùng Vương, t.p Quảng Ngãi",
                Description = "https://www.facebook.com/kimcucsports/",
            }
        };
    }
}