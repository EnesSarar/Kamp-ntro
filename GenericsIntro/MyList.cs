using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> 
    {
        T[] items;    // T verdiğimiz tipe karşılık gelir //Generiics bir tane değer alıyorsa T şeklinde kullanılır. 
        //Farklı şekillerde de belirtilebilir.
        
        public MyList()    //ctor yazılarak kullanılır. constructor denir.//constructor
        {
            items = new T[0];  // new demek bellekte referans örnek oluştur anlamındadır. 
        }
        public void Add(T item) // o an programcı new lerken hangi type derse o olsun.
            // Ben sana T olarak ne verirsem istediğim elemanın türüde odur anlamına gelir.
        {
            //List komutuda arkada tanımlanmış arrayı yöneltir.
            T[] tempArray = items;  //tempArray dizinin referansıdır. tempArray=geçici dizi
            items = new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }

    
    }
}
