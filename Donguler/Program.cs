using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Pragramlamaya başlangıç için temek kurs";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Pragramlamaya başlangıç için temek kurs","Java","Python","C#"};


            for (int i = 0; i < kurslar.Length; i++) //artı artı demek bir bir arttır demek //kurslar.Length de kurslarının içindeki öğre kadar anlamına gelir.
            {
                Console.WriteLine(kurslar[i]);    //kursların i'ninci elemanı anlamına gelir
            }  //for genel amaçlar içim 

            Console.WriteLine("For Bitti");


            foreach (string kurs in kurslar)    
                //dizi temelli yapıları tek tek dönmeye yarıyor //dizileri kolay dolaşmak için kullanılır

            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
