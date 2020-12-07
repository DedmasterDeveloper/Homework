using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ответ: {0:f}", distance(x1,x2,y1,y2));
            Console.WriteLine("Для завершения нажмите Enter");
            Console.ReadLine();

        }

        private static double distance(double x1, double x2, double y1, double y2)
        {
            double answer = new double();
            answer = Math.Sqrt(Math.Pow(x2 - x1, x2) + Math.Pow(y2 - y1, y2));
            return answer;
        }
    }
}
