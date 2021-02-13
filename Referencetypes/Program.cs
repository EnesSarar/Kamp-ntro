using System;

namespace Referencetypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("sayı 1 : "+sayi1);
        }
    }
}
