using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string StartWithA = "Ürünler A harfi ile başlamalı";
        public static string ProductCountOfCategoryError = " Bir kategoride en fazla 10 ürün olabilir";
        public static string ProuctUpdated = "Ürün güncellendi";
        public static string ProductNameAlreadyExists = "Ürün ismi daha önce kullanılmış";
        public static string CategoryLimitExceeded = "Kategori sayısı dolu";
    }
}
