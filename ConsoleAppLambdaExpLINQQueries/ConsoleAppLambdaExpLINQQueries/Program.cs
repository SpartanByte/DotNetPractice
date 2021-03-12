using System;
using System.Collections.Generic;//Ienumerable access 
using System.Linq; //for queries in C#

class Program
{
    static void Main()
    {
        //make array of values
        int[] values = new int[] { 3, 5, 2, 8, 6, 3, 4 };
        // find sum of values where each number is more than 5
        // 1. scan list, comparing, then sum
        // 3 > 5? no (do not include this in the sum)

        double compareAgainst = double.Parse(Console.ReadLine());
        Console.WriteLine(values.Where(x => x > compareAgainst).Sum());

        //make a list of values
        IEnumerable<int> lessThanList = values.TakeWhile(x => x < compareAgainst);
        foreach(var item in lessThanList)
        {
            Console.Write(item + ", ");
        }

    }
}