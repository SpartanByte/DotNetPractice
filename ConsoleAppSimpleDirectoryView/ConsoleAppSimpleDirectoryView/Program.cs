using System;
using System.IO;


class Program
{
    static void Main()
    {
        //store folders and files inside an array of strings
        string[] files = Directory.GetFiles(@"c:\users");
        string[] folders = Directory.GetDirectories(@"c:\users");

        foreach(string f in files)
        {
            Console.WriteLine("File {0} is located in {1}.", Path.GetFileName(f), Path.GetDirectoryName(f));
        }

        foreach(string f in folders)
        {
            Console.WriteLine("The directory is {0}.", f.ToString());
        }
    }
}
