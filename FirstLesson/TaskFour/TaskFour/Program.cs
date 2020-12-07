using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите переменную a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите переменную b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine("Для закрытия нажмите Enter");
            Console.ReadLine();

        }
    }
}
