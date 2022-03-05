using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную суточную температуру: ");
            int minTemp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальную суточную температуру: ");
            int maxTemp = Convert.ToInt32(Console.ReadLine());
            int avTemp = (minTemp + maxTemp) / 2;
            Console.WriteLine($"Среднесуточная температура: {avTemp}");

            Console.Write("Введите порядковый номер текущего месяца: ");
            int mounthnum = Convert.ToInt32(Console.ReadLine());
            string mounthname = "";
            switch(mounthnum)
            {
                case 1:
                    mounthname = "Январь";
                    break;
                case 2:
                    mounthname = "Ферваль";
                    break;
                case 3:
                    mounthname = "Март";
                    break;
                case 4:
                    mounthname = "Апрель";
                    break;
                case 5:
                    mounthname = "Май";
                    break;
                case 6:
                    mounthname = "Июнь";
                    break;
                case 7:
                    mounthname = "Июль";
                    break;
                case 8:
                    mounthname = "Август";
                    break;
                case 9:
                    mounthname = "Сентябрь";
                    break;
                case 10:
                    mounthname = "Октябрь";
                    break;
                case 11:
                    mounthname = "Ноябрь";
                    break;
                case 12:
                    mounthname = "Декабрь";
                    break;
            }
            Console.WriteLine($"Текущий месяц: {mounthname} ");
            switch (mounthnum)
            {
                case 1:
                case 2:
                case 12:
                    if (avTemp > 0)
                        Console.WriteLine("Зима дождливая.");
                    break;
            }
            if (mounthnum % 2 != 0)
                Console.WriteLine("Порядковый номер месяца нёчетный.");
            else
                Console.WriteLine("Порядковый номер месяца чётный");
        }
    }
}
