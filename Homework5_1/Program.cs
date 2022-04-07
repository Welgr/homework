using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Homework5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите необходимый текст: ");
            string filename = "text.txt";
            File.WriteAllText(filename, Console.ReadLine());
        }
    }
}
