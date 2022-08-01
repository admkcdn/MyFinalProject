using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string InvalidProductName = "Ürün ismi hatalı";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductNameAlreadyExists = "Böyle bir isimde ürün zaten ekli";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemedi";
        public static string AuthorizationDenied = "Yetkiniz Yok";
    }
}
