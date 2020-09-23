using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give the value of the first x-coordinate");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please give the value of the first y-coordinate");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please give the value of the second x-coordinate");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please give the value of the second y-coordinate");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double etäisyystot = Etäisyys(x1, y1, x2, y2);
            Console.WriteLine("etäisyys on:");
            Console.WriteLine(etäisyystot);
        }
        private static double Etäisyys(double x1, double y1, double x2, double y2)
        {
            double väli1 = Math.Pow((x2 - x1), 2);
            double väli2 = Math.Pow((y2 - y1), 2);
            double pituus3 = Math.Sqrt(väli1 + väli2);

            return pituus3;

        }

    }
}