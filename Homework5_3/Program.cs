using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Homework5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "byte.bin";
            Console.Write("Введите число в диапазоне 0..255: ");
            byte[] number = {0};
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0 || num > 255)
            {
                Console.WriteLine("Введено неккоретное число");
            }
            else
            {
                number[0] = Convert.ToByte(num);
            }
            File.WriteAllBytes(filename, number);
        }
    }
}
