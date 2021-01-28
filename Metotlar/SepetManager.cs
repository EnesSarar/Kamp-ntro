using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        //syntax - yazım şekilleri
        public void Ekle(Urun urun)  //eğer bir yerde normal parantez görürseniz "()" orda metot çalışıyor demektir.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);

        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }

    }
}
