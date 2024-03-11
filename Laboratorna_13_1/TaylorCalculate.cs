namespace Laboratorna_13_1;

public class TaylorCalculate
{
    public static class TaylorSeries
    {
        public static double CalculateTaylorSeries(double x, double epsilon, out int iterations)
        {
            double result = 0;
            double term = x;
            int n = 1;
            iterations = 0;

            while (System.Math.Abs(term) > epsilon)
            {
                result += term;
                term *= -x * x / (2 * n + 1);
                ++n;
                ++iterations;
            }

            return result;
        }
    }
}