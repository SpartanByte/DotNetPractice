using System;
using ComputingServices.ArithmeticServices;
using ComputingServices.FinancialServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sum of 4 and 5 is " + BasicMath.Add(4, 5));
        Console.WriteLine("56788 invested at 5% gives " + FinanceMath.FindInterest(0.05, 56788));
    }
}