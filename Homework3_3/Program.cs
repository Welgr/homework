using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            for(int i = hello.Length - 1 ; i >= 0; i--)
            {
                Console.Write((hello[i]));
            }
        }
    }
}
