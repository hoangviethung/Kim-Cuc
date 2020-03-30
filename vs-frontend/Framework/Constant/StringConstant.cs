using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.Framework.Constant
{
    public class StringUrlConstant
    {
        // Account
        public const string AccountLogin = "dang-nhap";
        public const string AccountRegister = "dang-ky";
        public const string AccountLogout = "dang-xuat";
        public const string AccountExternalLogin = "external-login";
        public const string AccountForgetPass = "quen-mat-khau";
        public const string AccountValidateCode = "kiem-tra-ma-xac-thuc";
        public const string AccountUpdateForget = "mat-khau-moi";
        public const string AccountUpdatePassword = "doi-mat-khau";
        public const string AccountUpdate = "cap-nhat-tai-khoan";
        public const string AccountUpdateAddress = "cap-nhat-dia-chi";
        public const string AccountOrder = "danh-sach-don-hang";

        // FAQ
        public const string FAQGet = "get-faq";

        // Cart
        public const string CartIndex = "Cart/Index";
        public const string AddToCart = "them-vao-gio-hang";
        public const string UpdateToCart = "cap-nhat-gio-hang";
        public const string RemoveFromCart = "xoa-khoi-gio-hang";
        public const string ClearCart = "xoa-gio-hang";
        public const string CartGoToPayment = "den-trang-thanh-toan";
        public const string CartPaymentAddress = "thong-tin-thanh-toan";
        public const string CartPaymentAddressPost = "dang-ky-thong-tin-thanh-toan";
        public const string CartPaymentMethod = "phuong-thuc-thanh-toan";
        public const string PaymentComplete = "thanh-toan-thanh-cong";
        public const string ApplyCoupon = "ap-dung-ma-khuyen-mai";
        // Url get response from payment gateway
        public const string RedirectUrl = "xac-nhan-thanh-toan";
        // Search
        public const string Search = "tim-kiem-san-pham";

        // Product
        public const string Comment = "binh-luan";
        public const string Reply = "phan-hoi";
        public const string Like = "thich";
        public const string DeleteComment = "xoa-binhluan";
    }
}