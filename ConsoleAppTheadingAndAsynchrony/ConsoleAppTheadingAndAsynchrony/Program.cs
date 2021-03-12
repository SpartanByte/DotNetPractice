using System;
using System.Threading;

class Program
{
    public static void Worker()
    {
        //for simulating work
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            //display i on the screen
            if(i == 5)
            {
                Console.WriteLine("Falling asleep at " + DateTime.Now);
                Thread.Sleep(5000); //Muliseconds
                Console.WriteLine("Awaking at " + DateTime.Now);
            }
        }
    }

    static void Main()
    {
        //new thread must be said in such a way that it starts the worker method
        //worker is static so you don't need anything in front of "Worker"
        Thread newThread = new Thread(new ThreadStart(Worker));
        newThread.Name = "Hard Worker Thread!";
        newThread.Start();
        //suspends the current thread (Main starts the process)
        newThread.Join();
        Console.WriteLine("We are back in main");
    }
}