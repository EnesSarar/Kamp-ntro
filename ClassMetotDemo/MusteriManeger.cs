using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManeger
    {
        public void Ekle (Musteri Musteri)
        {
            Console.WriteLine("Müşteri Eklendi.\n"+"Id:"+" "+Musteri.Id+"\n"+"Adı Soyadı:"+" "+Musteri.Adi+" " +Musteri.Soyadi);
            Console.WriteLine("---------------------------------");
        }

        public void Silme (Musteri Musteri)
        {
            Console.WriteLine("Müşteri Silindi.\n" + "Id:" + " " + Musteri.Id + "\n" + "Adı Soyadı:" + " " + Musteri.Adi + " " + Musteri.Soyadi);
            Console.WriteLine("---------------------------------");
        }

       
        
            
       
            

}   
        
}
