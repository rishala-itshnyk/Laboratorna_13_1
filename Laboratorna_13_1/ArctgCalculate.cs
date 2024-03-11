namespace Laboratorna_13_1;

public class ArctgCalculate
{
    public static class ArctgFunction
    {
        public static double CalculateArctg(double x)
        {
            double result = 0;
            double term = 1 / x;
            int n = 1;

            while (term > 1e-15 || term < -1e-15)
            {
                result += term;
                term *= -x * x / (2 * n + 1);
                ++n;
            }

            return result;
        }
    }
}