using MainProject.Core.Commerce.Enum;
using System.ComponentModel.DataAnnotations;

namespace MainProject.SCommerce.LandingPage.Models.Payment
{
    public class OrderInfoViewModel
    {
        #region Recipient
        [Required(ErrorMessage = "Recipient_Name_Required")]
        [StringLength(100, ErrorMessage = "Recipient_Name_Length")]
        public string RecipientName { get; set; }

        //[Required(ErrorMessage = "Recipient_Email_Required")]
        //[StringLength(200, ErrorMessage = "Recipient_Email_Length")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email_Invalid_Format")]
        //public string RecipientEmail { get; set; }

        [Required(ErrorMessage = "Recipient_Phone_Required")]
        [RegularExpression("^[0-9]{10,11}$", ErrorMessage = "Recipient_Phone_Invalid_Format")]
        public string RecipientPhone { get; set; }

        [Required(ErrorMessage = "Recipient_Address_Required")]
        [StringLength(500, ErrorMessage = "Recipient_Address_Length")]
        public string ShippingAddress { get; set; }

        //[Required(ErrorMessage = "Recipient_City_Required")]
        public int ShippingCitySelectedValue { get; set; }

        //[Required(ErrorMessage = "Recipient_District_Required")]
        public int ShippingDistrictSelectedValue { get; set; }
        #endregion

        //#region Buyer
        //[Required(ErrorMessage = "Recipient_Name_Required")]
        //[StringLength(100, ErrorMessage = "Recipient_Name_Length")]
        //public string BuyerName { get; set; }

        //[Required(ErrorMessage = "Recipient_Email_Required")]
        //[StringLength(200, ErrorMessage = "Recipient_Email_Length")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email_Invalid_Format")]
        //public string BuyerEmail { get; set; }

        //[Required(ErrorMessage = "Recipient_Phone_Required")]
        //[RegularExpression("^[0-9]{10,11}$", ErrorMessage = "Recipient_Phone_Invalid_Format")]
        //public string BuyerPhone { get; set; }

        //[Required(ErrorMessage = "Recipient_Address_Required")]
        //[StringLength(500, ErrorMessage = "Recipient_Address_Length")]
        //public string BillingAddress { get; set; }

        //[Required(ErrorMessage = "Recipient_City_Required")]
        //public int BillingCitySelectedValue { get; set; }

        //[Required(ErrorMessage = "Recipient_District_Required")]
        //public int BillingDistrictSelectedValue { get; set; }
        //#endregion

        public PaymentMethodCollection PaymentMethod { get; set; }

        public OrderInfoViewModel() { }
    }
}
