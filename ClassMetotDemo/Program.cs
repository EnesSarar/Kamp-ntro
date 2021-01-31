using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.Id = 145;
            Musteri1.Adi = "Enes";
            Musteri1.Soyadi = "Salman";
            Musteri1.Yas = 25;

            Musteri Musteri2 = new Musteri();
            Musteri2.Id = 146;
            Musteri2.Adi = "Kemal";
            Musteri2.Soyadi = "Kırık";
            Musteri2.Yas = 55;

            Musteri Musteri3 = new Musteri();
            Musteri3.Id = 147;
            Musteri3.Adi = "Selman";
            Musteri3.Soyadi = "kadayıfçı";
            Musteri3.Yas = 45;

            Musteri[] Musteriler = new Musteri[] { Musteri1, Musteri2, Musteri3 };
            Console.WriteLine("Müşteri Listesi");
            foreach (var Musteri in Musteriler)
            {
                Console.WriteLine("Id:"+" " +Musteri.Id);
                Console.WriteLine("Adı:"+" "+Musteri.Adi);
                Console.WriteLine("Soyadı:"+" "+Musteri.Soyadi);
                Console.WriteLine("Yaş:"+Musteri.Yas);
                Console.WriteLine("\n");
            }          
            MusteriManeger MusteriManeger = new MusteriManeger();
            MusteriManeger.Ekle(Musteri1);
            MusteriManeger.Silme(Musteri2);           
            

                     











            //Console.WriteLine("Hello World!");
        }
    }
}
