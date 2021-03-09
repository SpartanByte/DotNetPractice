namespace ComputingServices
{
    namespace ArithmeticServices
    {
        public class BasicMath
        {
            public static double Add(double x, double y)
            {
                return x + y;
            }
        }
    }

    namespace FinancialServices
    {
        public class FinanceMath
        {
            public static double FindInterest(double rate, double amount)
            {
                return rate*amount;
            }
        }
    }
}