using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    public void StopWatch()
    {
        
        Stopwatch stopwatch = new Stopwatch();

        
        stopwatch.Start();

        
        for (int i = 0; i < 1000; i++)
        {
            Thread.Sleep(1);
        }

       
        stopwatch.Stop();

        
        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
    }
    public static void Main(string[] args)
    {
        Program p=new Program();
        p.StopWatch();

    }
}