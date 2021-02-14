using System;

namespace OOP_3
{
    class FileLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }

}
