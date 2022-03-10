using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как тебя зовут? - ");
            string name = Console.ReadLine();
            Console.Write($"Привет {name}! Сегодня {DateTime.Now}"); ;
        }
    }
}
