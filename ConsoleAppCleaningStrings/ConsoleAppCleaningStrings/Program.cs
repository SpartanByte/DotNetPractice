using System;

class Program
{
    static void Main(string[] args)
    {
        string s1 = " this STring is,, as they say., badly formatted#";
        //trim spaces
        Console.WriteLine(s1);
        string s2 = s1.Trim(new char[] { ' ' });
        Console.WriteLine(s2);

        //replace (old character, new character)
        string s3 = s2.Replace(",,", ",");
        Console.WriteLine(s3);

        string s4 = s3.Replace(".,", ",");
        Console.WriteLine(s4);

        //convert all to lower, first uppercase
        string s5 = s4.ToLower();
        string s6 = s5.Substring(0, 1).ToUpper() + s5.Substring(1, s5.Length -1).ToLower();
        Console.WriteLine(s6);

        // will look for hash and set the index value
        string s7 = s6.Remove(s6.IndexOf('#'), 1);
        Console.WriteLine(s7);

        // remove badly from properly formatted string
        string s8 = s7.Replace("badly", "well");
        Console.WriteLine(s8);
    }
}
