using System;

namespace ClassÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product1.Elektronik = "Bilgisayar";
            product1.Moda = "Elbise";
            product1.Yaşam = "Yastık";
            product1.Spor = "Ayakkabı";

            product product2 = new product();
            product2.Elektronik = "Yazıcılar";
            product2.Moda = "Triko";
            product2.Yaşam = "perde";
            product2.Spor = "Giyim";

            product product3 = new product();
            product3.Elektronik = "Telefon";
            product3.Moda = "Mont";
            product3.Yaşam = "Halı";
            product3.Spor = "Koşu bandı";

            product product4 = new product();
            product4.Elektronik = "Beyaz eşya";
            product4.Moda = "Pantalon";
            product4.Yaşam = "Mutfak";
            product4.Spor = "Bisiklet";

            product[] urunler = new product[] { product1, product2, product3, product4 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Elektronik + " : " + urun.Spor);
            }
            
                        
            for (int i = 0; i < urunler.Length; i++)
            
            {
                Console.WriteLine(urunler[i].Elektronik + " : " + urunler[i].Spor);
            }
            int x = 0;
            while (x<urunler.Length)
            {
                Console.WriteLine(urunler[x].Elektronik + " : " + urunler[x].Spor);
                x++;
            }

            //daha geçerli ögeler seçilebilirdi tekrar elden geçirmek için geri dön


        }
    }
    class product
    {
        public string Elektronik { get; set; }

        public string Moda { get; set; }

        public string Yaşam { get; set; }

        public string Spor { get; set; }
    }
}
