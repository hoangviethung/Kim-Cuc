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
        public Category Category { get; set; }

        //DANH SÁCH THÔNG TIN CỦA CÔNG TY
        public Branch Branch { get; set; } = new Branch
        {
            Phone = "0906.523.876",
            Email = "kimcucsport@gmail.com",
            Address = "133 - 143 Hùng Vương, t.p Quảng Ngãi",
            Description = "https://www.facebook.com/kimcucsports/",
        };
    }
}