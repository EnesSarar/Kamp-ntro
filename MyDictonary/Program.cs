using GenericsHomework;
using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string> units = new MyDictonary<string>();
            units.Add("ahmet");
            
            Console.WriteLine(units.Lenght);
        }
    }
}
