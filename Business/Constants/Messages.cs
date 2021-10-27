using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    //new lenmiyor static verince. Messages. diye kullanılıyor.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Sistem bakımdakii";
        public static string UnitPriceInvalid = "UnitPriceInvalid";        
        public static string SameProductName = "Aynı isimden ürün eklenemez";

        public static string CateoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kayıt oldu";
    }
}
