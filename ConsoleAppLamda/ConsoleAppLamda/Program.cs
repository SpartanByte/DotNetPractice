// Lambda Expressions
// Lambda Statement
using System;

// Delegates - types that don't have to be inside a class
delegate double Multiply(double x, double y);
delegate double CompareFirstTwo(double x, double y);

class Program
{
    static void Main()
    {
        // Can feed values into the lamda and return the product 
        Multiply mult = (x, y) => (x * y);
        Console.WriteLine("The product of 4.5, and 3.8 is " + mult(4.5, 3.8));

        // cft will send a block of code to another function (through a parameter/reference)
        CompareFirstTwo cft = (xin, yin) => {
            double x = xin;
            double y = yin;
            return x > y ? x : y;
        };

        Console.WriteLine(CompareThird(cft, 10));
    }

    private static double CompareThird(CompareFirstTwo cf, double x)
    {
        return x > cf(4, 5) ? x : cf(4, 5);
    }
}