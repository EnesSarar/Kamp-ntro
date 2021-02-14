using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class BasvuruManager
    {
        //Method injectio
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //            
            krediManager.Hesapla();
            loggerService.log();
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
