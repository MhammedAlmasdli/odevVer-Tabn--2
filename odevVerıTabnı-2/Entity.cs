using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevVerıTabnı_2
{
   public class Musteri
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return $"{Ad}{Soyad}";
        }

    }

    public class Mune
    {
        public Guid ID { get; set; }          // Ürün kimliği
        public string Ad { get; set; }        // Ürün adı
       public double Fiyat { get; set; } 
        public string Kategori { get; set; }     // Ürün fiyatı
        public double adat { get; set; }      // Ürün stok miktarı
        public string Detay { get; set; }

        public override string ToString()
        {
            return $"{Ad}{Detay}";
        }


    }
    public class satlis
    {
        public Guid ID { get; set; }          // Satış kimliği (benzersiz)
        public Musteri Musteri { get; set; }  // Satışı yapan müşteri
        public Mune Mune { get; set; }        // Satılan ürün
        public DateTime Tarih { get; set; }   // Satış tarihi
        public double Fiyat { get; set; }     // Satış fiyatı (toplam fiyat)


    }
    public class Odeme
    {
        public Guid ID { get; set; }          // Ödeme kimliği (benzersiz)
        public Musteri Musteri { get; set; }  // Ödemeyi yapan müşteri
        public DateTime Tarih { get; set; }   // Ödeme tarihi
        public double Tutar { get; set; }     // Ödeme tutarı
        public string Tur { get; set; }       // Ödeme türü (ör. Nakit, Kredi Kartı)
        public string Aciklama { get; set; }  // Ödeme ile ilgili açıklama

    }
  
}
