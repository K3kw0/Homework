using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    // 0.Сдвиг массива

        //    Console.Write("Введите размерность массива --> ");
        //    int n = int.Parse(Console.ReadLine());
        //    int[] a = new int[n];
        //    Random zxc = new Random();
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        a[i] = zxc.Next(10);
        //        Console.Write(" " + a[i]);
        //    }
        //    Console.Write("\nВведите кол-во элементов --> ");
        //    int kall = int.Parse(Console.ReadLine());
        //    for (int k = 0; k < Math.Abs(kall); k++)
        //    {
        //        int qwe = a[0];
        //        for (int i = 0; i < a.Length; i++)
        //        {
        //            if (i == a.Length - 1)
        //            {
        //                a[i] = qwe;
        //                continue;
        //            }
        //            a[i] = a[i + 1];
        //        }
        //    }
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        Console.Write(" " + a[i]);
        //    }
        //}



        //    static void Main(string[] args)
        //    {
        //        //1.Написать программу, выводящую элементы двумерного массива по диагонали.

        //        Console.Write("Введите размерность массива --> ");
        //        int n = int.Parse(Console.ReadLine());
        //        int[,] a = new int[n, n];
        //        int[] e = new int[n];
        //        Random zxc = new Random();
        //        for (int x = 0; x < a.GetLength(0); x++)
        //        {
        //            for (int y = 0; y < a.GetLength(1); y++)
        //            {
        //                a[x, y] = zxc.Next(15);
        //                Console.Write("{0,5}", a[x, y]);
        //            }
        //            Console.WriteLine();
        //        }
        //        string which;
        //        do
        //        {
        //            Console.Write("Элементы какой диагонали вы хотите вывести --> ");
        //            which = Console.ReadLine();
        //            switch (which)
        //            {
        //                case "главной": main(a, e); break;
        //                case "побочной": secondary(a, e); ; break;
        //                case "выход": break;
        //                default: Console.WriteLine("Ошибка"); break;
        //            }
        //        } while (which != "выход");
        //    }
        //    static void main(int[,] a, int[] e)
        //    {
        //        Console.WriteLine("Элементы  главной диагонали --> ");
        //        for (int x = 0; x < a.GetLength(0); x++)
        //            for (int y = 0; y < a.GetLength(1); y++)
        //                if (x == y) e[x] = a[x, y];
        //        for (int x = 0; x < e.Length; x++)
        //        {
        //            for (int y = 0; y < x; y++)
        //            {
        //                Console.Write("     ");
        //            }
        //            Console.WriteLine("{0,5}", e[x]);
        //        }
        //    }
        //    static void secondary(int[,] a, int[] e)
        //    {
        //        Console.WriteLine("Элементы побочной диагонали --> ");
        //        for (int x = 0; x < a.GetLength(0); x++)
        //            for (int y = 0; y < a.GetLength(1); y++)
        //                if (x + y == a.GetLength(0) - 1) e[x] = a[x, y];
        //        for (int x = 0; x < e.Length; x++)
        //        {
        //            for (int y = e.Length; y > x; y--)
        //            {
        //                Console.Write("     ");
        //            }
        //            Console.WriteLine("{0,5}", e[x]);
        //        }
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    // 2. Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: 
        //    // первый элемент хранит имя контакта, второй — номер телефона/email.

        //    string[,] a = new string[5, 2];
        //    Console.WriteLine("Введите данные:\n1) имя\n2) номер телефона/email");
        //    for (int x = 0; x < a.GetLength(0); x++)
        //    {
        //        for (int y = 0; y < a.GetLength(1); y++)
        //        {
        //            a[x, y] = Console.ReadLine();
        //        }
        //    }
        //    Console.Clear();
        //    for (int x = 0; x < a.GetLength(0); x++)
        //    {
        //        for (int y = 0; y < a.GetLength(1); y++)
        //        {
        //            Console.Write(" " + a[x, y]);
        //        }
        //        Console.WriteLine();
        //    }



        //}

        //static void Main(string[] args)
        //{
        //    // 3. Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).

        //    Console.Write("Введите строку --> ");
        //    string text = Console.ReadLine();
        //    char[] sim = text.ToCharArray();
        //    Array.Reverse(sim);
        //    Console.WriteLine($"Обратный порядок --> {sim}");
        //}
        //    static void Main(string[] args)
        //    {
        //        // *«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
        //        Console.WriteLine("Пустое поле --> ");
        //        char[,] a = new char[10, 10];
        //        for (int x = 0; x < a.GetLength(0); x++)
        //        {
        //            for (int y = 0; y < a.GetLength(1); y++)
        //            {
        //                a[x, y] = 'O';
        //                Console.Write(" " + a[x, y]);
        //            }
        //            Console.WriteLine();
        //        }
        //        Console.WriteLine();
        //        Console.WriteLine("Поле заполненное кораблями --> ");
        //        Console.WriteLine();
        //        one(a, 1, 1);
        //        one(a, 7, 7);
        //        one(a, 3, 3);
        //        one(a, 9, 9);
        //        three(a, 8);
        //        three(a, 0);
        //        four(a, 5);
        //        two(a, 6);
        //        two(a, 3);
        //        two(a, 9);
        //        for (int x = 0; x < a.GetLength(0); x++)
        //        {
        //            for (int y = 0; y < a.GetLength(1); y++)
        //            {
        //                Console.Write(" " + a[x, y]);
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //    static void one(char[,] a, int X, int Y)
        //    {
        //        for (int x = 0; x < a.GetLength(0); x++)
        //        {
        //            for (int y = 0; y < a.GetLength(1); y++)
        //            {
        //                if (x == X && y == Y) a[x, y] = 'X';
        //            }
        //        }
        //    }
        //    static void three(char[,] a, int X)
        //    {
        //        for (int x = 0; x < a.GetLength(0); x++)
        //        {
        //            for (int y = 0; y < a.GetLength(1); y++)
        //            {
        //                for (int i = 3; i < a.GetLength(1) - 4; i++) if (x == X) a[x, i] = 'X';
        //            }
        //        }
        //    }
        //    static void four(char[,] a, int X)
        //    {
        //        for (int x = 0; x < a.GetLength(0); x++)
        //        {
        //            for (int y = 0; y < a.GetLength(1); y++)
        //            {
        //                for (int i = 5; i < a.GetLength(1) - 1; i++) if (x == X) a[x, i] = 'X';
        //            }
        //        }
        //    }
        //    static void two(char[,] a, int X)
        //    {
        //        for (int x = 0; x < a.GetLength(0); x++)
        //        {
        //            for (int y = 0; y < a.GetLength(1); y++)
        //            {
        //                for (int i = 0; i < a.GetLength(1) - 8; i++) if (x == X) a[x, i] = 'X';
        //            }
        //        }
        //    }
        //}
    }
}

