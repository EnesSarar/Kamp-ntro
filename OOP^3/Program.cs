using System;
using System.Collections.Generic;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
            //o interface i imlamente eden classın referans numarasını tutabilir.
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();  
            IKrediManager taşıtKrediManager = new TaşıtKrediManager();            
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService datebaseLoggerService = new DatebaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatebaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,taşıtKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
