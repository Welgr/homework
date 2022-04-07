using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            File.AppendAllText(filename, "Время запуска: " + DateTime.Now + "\n");
        }
    }
}
