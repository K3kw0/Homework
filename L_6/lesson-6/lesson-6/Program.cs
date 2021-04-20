using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;


namespace lesson_6
{

    class Program
    {
        /*
         * Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
         * Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
         * В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
         */

        //static void Show()
        //{
        //    Process[] localAll = Process.GetProcesses();
        //    for (int i = 0; i < localAll.Length; i++)
        //    {
        //        Console.WriteLine($"{i + 1}) ID: {localAll[i].Id}  Name: {localAll[i].ProcessName}");
        //    }
        //}

        //static void KillByName(string name)
        //{
        //    Process[] process = Process.GetProcessesByName(name);
        //    for (int i = 0; i < process.Length; i++)
        //    {
        //        process[i].Kill();
        //    }
        //}

        //static void KillById(int id)
        //{
        //    try
        //    {
        //        Process process = Process.GetProcessById(id);
        //        process.Kill();
        //    }
        //    catch (ArgumentException )
        //    {
        //        Console.WriteLine("Введите верный ID");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\tМЕНЮ\n1) вывести все процессы;\n2) завершить процесс по ID;\n3) завершить процесс по имени.");
        //    int a;
        //    do
        //    {
        //        Console.Write("Выберете что нужно сделать --> ");
        //        a = int.Parse(Console.ReadLine());
        //        switch (a)
        //        {
        //            case 1: Show(); break;
        //            case 2:
        //                Console.Write("Введите ID процесса --> ");
        //                int id = int.Parse(Console.ReadLine());
        //                KillById(id);
        //                break;
        //            case 3:
        //                Console.Write("Введите имя процесса --> ");
        //                string name = Console.ReadLine();
        //                KillByName(name);
        //                break;
        //            default:
        //                Console.WriteLine("Ошибка: выберите действие");
        //                break;
        //        }
        //    } while (a != 0);
        //}

        /*
           2. Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4,
              при подаче массива другого размера необходимо бросить исключение MyArraySizeException.
              Далее метод должен пройтись по всем элементам массива, преобразовать в int, и просуммировать.
              Если в каком-то элементе массива преобразование не удалось
              (например, в ячейке лежит символ или текст вместо числа), должно быть брошено исключение MyArrayDataException, с детализацией в какой именно ячейке лежат неверные данные.
              В методе main() вызвать полученный метод, обработать возможные исключения MySizeArrayException и MyArrayDataException, и вывести результат расчета.
         */

        //    static void Q(string[,] a)
        //    {

        //        // реализовал как понял (при обязательной вставке текста ошибка обрабатывается. Если убрать строчку со вставкой текста, то массив выведется и сумма посчитается)

        //        if (a.Length != 16) throw new MyArraySizeException("Введите корректную размерность массива");
        //        int sum = 0;
        //        int indX;
        //        int indY;
        //        int[,] numb = new int[4, 4];
        //        Console.Write(@"Введите символ\слово которое хотите вставить --> ");
        //        string text = Console.ReadLine();
        //        for (int i = 0; i < a.GetLength(0); i++)
        //        {
        //            for (int j = 0; j < a.GetLength(1); j++)
        //            {
        //                a[i, j] = "1";
        //                if (i == 1 && j == 3) a[i, j] = text;
        //                Console.Write(" " + a[i, j]);
        //                if (a[i, j] == text)
        //                {
        //                    indX = i + 1;
        //                    indY = j + 1;
        //                    throw new MyArrayDataException($"\nЯчейка содержащая неверные данные --> a[{indX},{indY}]");
        //                }
        //                numb[i, j] = Convert.ToInt32(a[i, j]);
        //                sum += numb[i, j];
        //            }
        //            Console.WriteLine();
        //        }
        //        Console.WriteLine(sum);
        //    }

        //    static void Main(string[] args)
        //    {
        //        try
        //        {
        //            Console.Write("Введите размерность массива --> ");
        //            int n = int.Parse(Console.ReadLine());
        //            string[,] a = new string[n, n];
        //            Q(a);
        //        }
        //        catch (MyArraySizeException x)
        //        {
        //            Console.WriteLine(x.Message);
        //        }
        //        catch (MyArrayDataException x)
        //        {
        //            Console.WriteLine(x.Message);
        //        }

        //    }
        //}

        //class MyArraySizeException : Exception
        //{
        //    public MyArraySizeException(string message) : base(message)
        //    {
        //    }
        //}

        //class MyArrayDataException : Exception
        //{
        //    public MyArrayDataException(string message) : base(message)
        //    {
        //    }
        //}
    }
}



















