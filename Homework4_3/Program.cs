using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_3
{
    internal class Program
    {
        enum Seasons: int
        {
            Winter = 1,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца: ");
            int numberMounth = Convert.ToInt32(Console.ReadLine());
            Seasons currentSeason = SeasonChoice(numberMounth);
            if (currentSeason == Seasons.Winter)
            {
                Console.WriteLine("Текущий сезон - Зима");
            }
            else if (currentSeason == Seasons.Spring)
            {
                Console.WriteLine("Текущий сезон - Весна");
            }
            else if (currentSeason == Seasons.Autumn)
            {
                Console.WriteLine("Текущий сезон - Осень");
            }
            else if (currentSeason == Seasons.Summer)
            {
                Console.WriteLine("Текущий сезон - Лето");
            }

        }
        static Seasons SeasonChoice(int numberMounth)
        {
            Seasons currentSeason = new Seasons();
            switch (numberMounth)
            {
                case 1:
                case 2:
                case 12:
                    currentSeason = Seasons.Winter;
                    return currentSeason;
                case 3:
                case 4:
                case 5:
                    currentSeason = Seasons.Spring;
                    return currentSeason;
                case 6:
                case 7:
                case 8:
                    currentSeason = Seasons.Summer;
                    return currentSeason;
                case 9:
                case 10:
                case 11:
                    currentSeason = Seasons.Autumn;
                    return currentSeason;
                default:
                    Console.WriteLine("Введено неккоректное значение месяца.");
                    break;
            }
            return currentSeason;
        }
    }
}
