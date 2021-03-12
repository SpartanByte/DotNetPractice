using System;
using System.Collections.Generic;// for generic lists
using System.Linq; //for doing searches

class Program
{
    static void Main()
    {
        List<double> myValues = new List<double>();
        Console.WriteLine("Enter Values:");
        string s = Console.ReadLine();
        
        while(s != "Exit")
        {
            myValues.Add(double.Parse(s));
            s = Console.ReadLine();
        }

        //LINQ comes in to enable search features
        var values = from num in myValues where (num >= 0 && num <= 10) select num;
        Console.WriteLine("Matching Values:");
        // display values that match the given condition
        foreach(var d in values)
        {
            Console.Write(d + ", ");
        }
        // Start a new line
        Console.WriteLine();
    }
}