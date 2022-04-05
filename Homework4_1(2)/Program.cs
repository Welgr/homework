using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество ФИО: ");
            int numberNames = Convert.ToInt32(Console.ReadLine());
            string[] fullNames = new string[numberNames];
            for (int i = 0; i < numberNames; i++)
            {
                fullNames[i] = InputNames();
            }
            for (int i = 0; i < numberNames; i++)
            {
                Console.WriteLine(fullNames[i]);
            }
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullName = lastName + " " + firstName + " " + patronymic;
            return fullName;

        }
        static string InputNames()
        {
            Console.WriteLine("Введите фамилию: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string patronymic = Console.ReadLine();
            string fullNames = GetFullName(firstName, lastName, patronymic);
            return fullNames;
        }
    }
}
