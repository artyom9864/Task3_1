using System;
using System.Linq;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var _key = ConsoleKey.Enter;
            var keyInfo = new ConsoleKeyInfo();

            for (; ; )
            {
                do
                {
                    string _entryField = Console.ReadLine();
                    char _firstElement = _entryField.FirstOrDefault();
                    keyInfo = Console.ReadKey(true);                
                    Console.WriteLine(_firstElement);                               
                }

                while (keyInfo.Key != _key);
                break;
            }                  
        }
    }
}


