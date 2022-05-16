using System;


namespace Program
{
    class Program
    {
        int number, sum = 0, n;
        public void readData()
        {
            Console.Write("enter the Number");
            number = int.Parse(Console.ReadLine());
            n = number;
        }
        public void PerfNum()
        {
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
            }

        }
        public static void Main(string[] args)
        {
            Program p=new Program();
            p.readData();
            p.PerfNum();



        }
    }
}