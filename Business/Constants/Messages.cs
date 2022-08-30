using System;
using System.Collections.Generic;
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
        public static string ReturnDateNotNull = "Araba teslim edilmemiş. Kiralanamaz.";
        public static string RentalAdded = "Araba kiralandı.";
    }
}
