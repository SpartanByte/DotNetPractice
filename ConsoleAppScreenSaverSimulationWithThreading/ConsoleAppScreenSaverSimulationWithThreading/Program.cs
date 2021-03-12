//generating random colors
//generating random positions

using System;
// Threading needed to slow down the process
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Title = "Simple Screen Saver";
        Console.WriteLine("Number of times to run: ");
        int numb = int.Parse(Console.ReadLine());
        int counter = 1;

        while(counter <= numb)
        {
            // allows us to call the next function which generates numbers
            Random rnd = new Random();
            // set the cursor position randomly
            int x = rnd.Next(0, Console.WindowWidth - 1);
            int y = rnd.Next(0, Console.WindowHeight - 1);

            //random number between 1 and 15
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 15);
            Console.SetCursorPosition(x, y);
            Console.Write("Hello, World!!");
            Thread.Sleep(2000); // miliseconds, need to sleep because this will run too fast to see
            //no copies of text are left behind
            Console.Clear();
            counter++;
        }
    }
}
