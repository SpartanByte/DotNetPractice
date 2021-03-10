using System;
using System.Collections.Generic;// Dictionary
using System.IO;// For writing files
using System.Diagnostics;// Open a program after creation
// Collection of key value pairs firstPlace, John
class Program
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        // Read input from user,
        // Entries will be of the form: key,value
        string s = Console.ReadLine();
        while (s != "Exit")
        {
            // Split string into individual entries
            string[] keyVal = s.Split(new char[] { ',' });
            // Add key, value pairs to dictionary
            dict.Add(keyVal[0], keyVal[1]);
            s = Console.ReadLine();
        }
        // Save to drive
        Program.SaveDictionary(dict);
        // Launch notepad to view file
        Process.Start(@"notepad.exe", @"c:\data\dict.txt");
    }
    private static void SaveDictionary(Dictionary<string, string> entries)
    {
        using (StreamWriter writer = File.CreateText(@"c:\data\dict.txt"))
        {
            foreach (var pair in entries)
            {
                writer.WriteLine(pair.Key + ", " + pair.Value);
            }
        }
    }
}