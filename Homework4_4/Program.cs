using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fibNum = 1;
            switch(n)
            {
                case 1:
                    Console.WriteLine("Число Фиббоначи: 0");
                    break;
                case 2:
                    Console.WriteLine("Число Фиббоначи: 1");
                    break;
                default:
                    Console.WriteLine("Число Фиббоначи: "+ fibbonaci(n));
                    break;
            }

         }
        static int fibbonaci(int n)
        {
            return n > 1 ? fibbonaci(n - 1) + fibbonaci(n - 2) : n;
        }
    }
}
