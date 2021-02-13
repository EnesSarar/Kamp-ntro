using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {   // list komutu olmasaydı kendi listerimizi nasıl hazırlardık, öğrenelim.
            MyList<string> isimler = new MyList<string> (); //"<>" içinde çalışıcağımız veri tipini belirtiriz.
            isimler.Add("Engin");
            
        }
    }
}
