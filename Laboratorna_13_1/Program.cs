using System;

namespace Laboratorna_13_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("xp = ");
            double xStart = Convert.ToDouble(Console.ReadLine());

            Console.Write("xk = ");
            double xEnd = Convert.ToDouble(Console.ReadLine());

            Console.Write("dx = ");
            double dx = Convert.ToDouble(Console.ReadLine());

            Console.Write("eps = ");
            double epsilon = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("|" + " x " + "|" + " arctg(x) " + "|" + " S " + "|" + " n " + "|");
            Console.WriteLine("|----------------------------------------------|");

            for (double x = xStart; x <= xEnd; x += dx)
            {
                int iterations;
                double arctgResult = ArctgCalculate.ArctgFunction.CalculateArctg(x);
                double seriesResult = TaylorCalculate.TaylorSeries.CalculateTaylorSeries(x, epsilon, out iterations);

                Console.WriteLine("| {0,10:F2} | {1,-25:F15} | {2,-25:F15} | {3,-3} |", x, arctgResult, seriesResult, iterations);
            }
        }
    }
}