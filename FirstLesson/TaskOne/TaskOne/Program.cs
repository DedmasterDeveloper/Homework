﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите возрост: ");
            string age = Console.ReadLine();
            Console.Write("Введите рост: ");
            string height = Console.ReadLine();
            Console.Write("Введите вес: ");
            string weight = Console.ReadLine();

            Console.WriteLine("Имя: " + name + ", Фамилия: " + surname + ", Возрост: " + age + ", Рост: " + height + ", Вес: " + weight);
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возрост: {2}, Рост: {3}, Вес: {4}", name, surname, age, height, weight);
            Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Возрост: {age}, Рост: {height}, Вес: {weight}");
            Console.WriteLine("Для закрытия нажмите Enter");
            Console.ReadLine();
        }
    }
}
