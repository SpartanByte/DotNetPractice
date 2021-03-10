using System;
using System.Collections.Generic;
class Program
{
    //display lower case
    static void Case(string p)
    { 
        Console.WriteLine(p.ToLower()); 
    }

    static void Main()
    {
        //makes list of strings with no def. size
        List<string> myWords = new List<string>();
        // Read first input
        string s = Console.ReadLine();
        while (s != "Exit")
        {
            myWords.Add(s);// Add to list
            s = Console.ReadLine();// Collect next word
        }
        // Call case on each word
        myWords.ForEach(Case);
        // Reverse the list
        myWords.Reverse();
        // Print again to confirm reversal
        myWords.ForEach(Case);
    }
}
