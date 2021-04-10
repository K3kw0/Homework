using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввведите ваше имя --> ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");
            Console.ReadKey();
        }
    }
}
