using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    //// 1. Написать метод GetFullName(string firstName, string lastName, string patronymic),
    //// принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
    //// Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

    //// в этом задании можно было так же сделать через классы и массивы 

    //class Program
    //{
    //    static string GetFullName(string firstName, string lastName, string patronymic)
    //    {
    //        return firstName + " " + lastName + " " + patronymic;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.Write("Введите кол-во человек --> ");
    //        int a = int.Parse(Console.ReadLine());
    //        int k = 1;
    //        while (k <= a)
    //        {
    //            k++;
    //            Console.Write("Ведите имя --> ");
    //            string firstName = Console.ReadLine();
    //            Console.Write("Ведите фамилию --> ");
    //            string lastName = Console.ReadLine();
    //            Console.Write("Ведите отчество --> ");
    //            string patronymic = Console.ReadLine();
    //            Console.WriteLine(new string('-', 40));
    //            Console.WriteLine(GetFullName(firstName, lastName, patronymic));
    //            Console.WriteLine(new string('-', 40));
    //        }
    //    }
    //}

    //class Program
    //{
    //    // 2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке.
    //    // Ввести данные с клавиатуры и вывести результат на экран.

    //    // надеюсь использование split не запрещенно 

    //    static int Sum(string a)
    //    {
    //        int sum = 0;
    //        string[] v = a.Split(' ');
    //        for (int i = 0; i < v.Length; i++)
    //        {
    //            sum += Convert.ToInt32(v[i]);
    //        }
    //        return sum;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.Write("Введите числа через пробел --> ");
    //        string a = Console.ReadLine();
    //        Console.WriteLine($"Сумма данных чисел --> {Sum(a)}");
    //    }
    //}

    //class Program
    //{
    //    // 3. Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
    //    // На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
    //    // Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
    //    // Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
    //    // Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

    //    enum Seasons
    //    {
    //        Winter = 1,
    //        Spring,
    //        Summer,
    //        Autumn
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Нажав 0, программа завершит свою работу");
    //        int a;
    //        do
    //        {
    //            Console.Write("Номер месяца --> ");
    //            a = int.Parse(Console.ReadLine());
    //            switch (a)
    //            {
    //                case (int)Seasons.Winter: Console.WriteLine("Зима"); break;
    //                case (int)Seasons.Spring: Console.WriteLine("Весна"); break;
    //                case (int)Seasons.Summer: Console.WriteLine("Лето"); break;
    //                case (int)Seasons.Autumn: Console.WriteLine("Осень"); break;
    //                case 0: break;
    //                default:
    //                    Console.WriteLine("Ошибка: введите число от 1 до 12");
    //                    break;
    //            }
    //        } while (a != 0);
    //    }
    //}

    //class Program
    //{

    //    // 4. (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.

    //    static int Fb(int x)
    //    {
    //        if (x == 0) return 0;
    //        else if (x == 1) return 1;
    //        else return Fb(x - 1) + Fb(x - 2);
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.Write("Введите колво чисел в ряду --> ");
    //        int n = int.Parse(Console.ReadLine());
    //        Console.Write("Последовательность имеет вид -->");
    //        for (int i = 0; i < n; i++)
    //        {
    //            Console.Write(" " + Fb(i));
    //        }
    //    }
    //}

    //class Program
    //{
    //    // 5. (**) Есть предложение String str1 = " Предложение один Теперь предложение два Предложение три";
    //    // нужно превести строку к нормально виду " Предложение один. Теперь предложение два. Предложение три";

    //    static void q(string a)
    //    {
    //        for (int i = 0; i < a.Length; i++)
    //        {
    //            if (a[i] == ' ')
    //            {
    //                if (char.IsUpper(a, i + 1))
    //                {
    //                    Console.Write(". ");
    //                }
    //                else Console.Write(" ");
    //                continue;
    //            }
    //            Console.Write(a[i]);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        string a = "Предложение один Теперь предложение два Предложение три";
    //        q(a);
    //    }
    //}
}
