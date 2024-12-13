using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y = Pow((c^2*x^2+2), 1/3) + (ln⁡(x^2+1))/2π");

            Console.Write("xmin: ");
            double Xmin = Convert.ToDouble(Console.ReadLine());

            Console.Write("xmax: ");
            double Xmax = Convert.ToDouble(Console.ReadLine());

            Console.Write("dx: ");
            double Dx = Convert.ToDouble(Console.ReadLine());

            Console.Write("c: ");
            double C = Convert.ToDouble(Console.ReadLine());

            if (Dx <= 0)
            {
                Console.WriteLine("Error: step dx must be positive.");
                return;
            }
            if (Xmin > Xmax)
            {
                Console.WriteLine("Error: xmin must be less than or equal to xmax.");
                return;
            }

            Console.WriteLine("\nFunction:\n");
            Console.WriteLine(" x\t\tf(x)");

            for (double x = Xmin; x <= Xmax; x += Dx)
            {
                double part1 = Math.Pow(C * C * x * x + 2, 1.0 / 3.0);
                double part2 = Math.Log(x * x + 1) / (2 * Math.PI);

                double y = part1 + part2;

                Console.WriteLine($"{x:F2}\t\t{y:F4}");
            }
        }

    }
}   
