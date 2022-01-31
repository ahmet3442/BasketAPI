using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Constant
{
    public static class Error
    {
        public static readonly object ProductNotFound = new { isSuccess = false, errorCode = "P000", message = "Ürün Bulunamadı" };
        public static readonly object ProductPricetNotFound = new { isSuccess = false, errorCode = "P001", message = "Ürün Fiyat Bilgisi Bulunamadı." };      
        
        public static readonly object CampaignAmountError = new { isSuccess = false, errorCode = "C000", message = "Kampanya indirimi ürün tutarından fazla olamaz." };
        
        public static readonly object BasketNotFound = new { isSuccess = false, errorCode = "B000", message = "Sepet Bilgisi bulunamadı." };             
        
        public static readonly object StockNotEnough = new { isSuccess = false, errorCode = "S000", message = "Yeterli Stok Bulunmamaktadır." };
        
        public static readonly object SaveError = new { isSuccess = false, errorCode = "E999", message = "Kayıt işleminde hata oluştu." };

    }
}
