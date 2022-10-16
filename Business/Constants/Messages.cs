using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Car Crud operations
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba bilgileri güncellendi.";
        public static string CarsListed = "Arabalar listelendi.";

        //Car Add validation
        public static string CarNameInvalid = "Araba ismi en az 2 karakterden oluşmalıdır.";
        public static string CarDailyPriceInvalid = "Araba fiyatı 0'dan bütük olmalıdır.";


        //Brand Crud operations
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandsListed = "Markalar listelendi.";


        //Color Crud operations
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorsListed = "Renkler listelendi.";

        //Rental Crud operations
        public static string ReturnDateNull = "Araba teslim edilmemiş. Kiralanamaz.";
        public static string RentalAdded = "Araba kiralandı.";

        //CarImage Crud operations
        public static string CarImageLimitExceeded = "Bir arabaya ait en fazla 5 resim olabilir.";

        //Auth operations
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Sisteme giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "AccessToken başarıyla oluşturuldu.";

        //SecuredOperation messages
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
