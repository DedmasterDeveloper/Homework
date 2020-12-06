using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рассчитываем индекс массы тела");
            Console.Write("Введите ваш рост: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш вес: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ИМТ: {0}", bodyMassIndex(h,m));
            Console.WriteLine("Для выхода нажмите Enter");
            Console.ReadLine();
        }

        private static double bodyMassIndex(double h, double m)
        {

            double i = new double();
            i = m / (h * h);
            return i;
        }

    }
}
