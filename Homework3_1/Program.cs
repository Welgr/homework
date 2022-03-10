using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            array[0, 0] = 1;
            array[1, 1] = 2;
            array[2, 2] = 3;
            array[3, 3] = 4;
            array[4, 4] = 5;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write($"{array[i, j]} ");
                }
                System.Console.WriteLine();
            }

        }
    }
}
