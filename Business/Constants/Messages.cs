﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi.";
        internal static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        internal static string ProductNameAlreadyExists ="Aynı isimle bir ürün olabilir.";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        internal static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
