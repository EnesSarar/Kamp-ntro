using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class DatebaseLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Veritabanına loglandı");

        }
    }

}
