using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
{
    class Program
    {
        static void Main()
        {
            CharArrayWrapper wrapper = new CharArrayWrapper(new char[] { 'a', 'b', 'E', 'д', 'і' });
            Console.WriteLine($"Кiлькiсть голосних: " + wrapper.VowelCount);
        }
    }
}