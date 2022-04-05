using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] numberBook = new string[5, 2];
            numberBook[0, 0] = "Vasya";
            numberBook[0, 1] = "+71111111111";
            numberBook[1, 0] = "Vadim";
            numberBook[1, 1] = "+72222222222";
            numberBook[2, 0] = "Klim";
            numberBook[2, 1] = "+73333333333";
            numberBook[3, 0] = "Egor";
            numberBook[3, 1] = "+74444444444";
            numberBook[4, 0] = "Oleg";
            numberBook[4, 1] = "+75555555555";
            for (int i = 0; i < numberBook.GetLength(0); i++)
            {
                Console.WriteLine(i + " - " + numberBook[i, 0]);
            }
            Console.Write("Введите номер необходимого контакта: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Номер: {numberBook[number, 1]}");
        }
    }
}
