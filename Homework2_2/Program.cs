using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idcheck = 25544;
            string material1 = "Кирпич пустотелый";
            string material2 = "Щебень";
            int materialcost1 = 522;
            int materialcost2 = 242;
            int cost = materialcost1 + materialcost2;
            Console.WriteLine($"{0,10} ООО 'Чек' ");
            Console.WriteLine($"{0,10} Чек #{idcheck}");
            Console.WriteLine($"{material1}.....Стоимость: {materialcost1}");
            Console.WriteLine($"{material2}.....Стоимость: {materialcost2}");
            Console.WriteLine("==================================");
            Console.WriteLine($"{0,20} Общая стоимось: {cost}");
            Console.WriteLine($"{0,25} ИТОГ: {cost}");

        }
    }
}
