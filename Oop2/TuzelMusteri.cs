using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Coorporate
    class TuzelMusteri:Musteri   //Miras yada inheritance denir 
        //TuzelMusteri:Musteri şeklinde yazmak TuzelMusteri bir Musteridir demek
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
