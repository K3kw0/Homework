using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdjgdhfg
{

    //class Program
    //{
    //    // 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

    //    static void Main(string[] args)
    //    {
    //        // 1 вариант

    //        string name = "text.txt";
    //        string text = Console.ReadLine();
    //        File.WriteAllText(name, text);
    //        string fileText = File.ReadAllText(name);
    //        Console.WriteLine(fileText);

    //        // 2 вариант

    //        FileStream txt = new FileStream(@"D:\startup.txt", FileMode.Create);
    //        StreamWriter write = new StreamWriter(txt);
    //        Console.Write("Введите кол-во строк --> ");
    //        int n = int.Parse(Console.ReadLine());
    //        string[] slova = new string[n];
    //        for (int i = 0; i < slova.Length; i++)
    //        {
    //            slova[i] = Console.ReadLine();
    //            write.WriteLine(slova[i]);
    //        }
    //        write.Close();
    //        Console.WriteLine("Содержимое файла: ");
    //        string read = File.ReadAllText(@"D:\startup.txt");
    //        Console.WriteLine(read);
    //    }
    //}

    //class Program
    //{
    //    //  2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

    //    static void Main(string[] args)
    //    {
    //        FileStream text = new FileStream(@"D:\startup.txt", FileMode.Append);
    //        StreamWriter write = new StreamWriter(text);
    //        write.WriteLine($"Время последнего открытия --> {DateTime.Now.ToLongTimeString()}");
    //        write.Close();
    //        Console.WriteLine("Содержимое файла: ");
    //        string read = File.ReadAllText(@"D:\startup.txt");
    //        Console.WriteLine(read);
    //    }
    //}

    //class Program
    //{
    //    // 3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.

    //    static void Main(string[] args)
    //    {
    //        // 1 вариант просто запись

    //        //FileStream text = new FileStream(@"D:\test.bin", FileMode.Create);
    //        //BinaryWriter write = new BinaryWriter(text);
    //        //write.Write(byte.Parse(Console.ReadLine()));
    //        //write.Close();

    //        // 2 вариант с выводом на консоль

    //        //FileStream text = new FileStream(@"D:\test.bin", FileMode.Create);
    //        //BinaryWriter write = new BinaryWriter(text);
    //        //Console.Write("Введите кол-во чисел --> ");
    //        //int n = int.Parse(Console.ReadLine());
    //        //byte[] e = new byte[n];
    //        //Console.WriteLine("Введите числа от 0 до 255:");
    //        //for (int i = 0; i < e.Length; i++)
    //        //{
    //        //    e[i] = byte.Parse(Console.ReadLine());
    //        //    write.Write(e[i]);
    //        //}
    //        //write.Close();
    //        //byte[] read = File.ReadAllBytes(@"D:\test.bin");
    //        //for (int i = 0; i < read.Length; i ++)
    //        //{
    //        //    Console.Write(" " + read[i]);
    //        //}
    //    }
    //}

    //class Employee
    //{
    //    // 4. Создать класс "Сотрудник" с полями: ФИО, должность, email, телефон, зарплата, возраст;
    //    // С помощью цикла вывести информацию только о сотрудниках старше 40 лет;

    //    public string FullName { get; set; }
    //    public string Position { get; set; }
    //    public string Email { get; set; }
    //    public int Phone { get; set; }
    //    public int Salary { get; set; }
    //    public int Age { get; set; }

    //    public void e(Employee[] zxc)
    //    {
    //        Console.WriteLine($"ФИО: {FullName}; Должность: {Position}; Email: {Email}; Телефон: {Phone}; Зарплата: {Salary}; Возраст: {Age}.");
    //    }
    //}

    //class Program
    //{
    //    static void print(Employee[] kekw)
    //    {
    //        for (int i = 0; i < kekw.Length; i++)
    //        {
    //            kekw[i].e(kekw);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.Write("Введите кол-во сотрудников --> ");
    //        int n = int.Parse(Console.ReadLine());
    //        Employee[] a = new Employee[n];
    //        for (int i = 0; i < a.Length; i++)
    //        {
    //            Console.WriteLine("Введите данные: ");
    //            a[i] = new Employee();
    //            Console.Write("ФИО --> ");
    //            a[i].FullName = Console.ReadLine();
    //            Console.Write("Должность --> ");
    //            a[i].Position = Console.ReadLine();
    //            Console.Write("Email --> ");
    //            a[i].Email = Console.ReadLine();
    //            Console.Write("Телефон --> ");
    //            a[i].Phone = int.Parse(Console.ReadLine());
    //            Console.Write("Зарплата --> ");
    //            a[i].Salary = int.Parse(Console.ReadLine());
    //            Console.Write("Возраст --> ");
    //            a[i].Age = int.Parse(Console.ReadLine());
    //        }
    //        Console.Clear();
    //        Console.WriteLine("Список сотрудников: ");
    //        print(a);
    //        Console.WriteLine("Все сотрудники старше 40 : ");
    //        for (int i = 0; i < a.Length; i++)
    //        {
    //            if (a[i].Age > 40) a[i].e(a);
    //        }
    //    }
    //}

}








