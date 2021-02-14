using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    interface IKrediManager //okunurluğunu ve interface olduğunu anlamak için I harfiyle başlarız.
        //İmzanın aynı olduğu içerisinin farklı olduğu durumlarda class olarak değilde interface olarak oluştururuz.
        //İnterface, KrediManager interface i kullanırsa aşağıdaki metodu/metotları içermek zorunda
    {
        void Hesapla();
        void BiseyYap();
        
    }
}
