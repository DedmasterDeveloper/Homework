using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive
{
    class Program
    {
        /*
         * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
         * б) Сделать задание, только вывод организуйте в центре экрана
         * в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
         */
        static void Main(string[] args)
        {
            Write("Есиков", "Михаил", "Санкт-Петербург");
        }

        private static void Write(string name, string surname, string city)
        {
            string outString = $"{surname} {name} {city}";
            var width = Console.WindowWidth;
            var padding = width / 2 + outString.Length / 2;
            Console.WriteLine("{0," + padding + "}", outString);
            Console.ReadLine();
        }
    }
}
