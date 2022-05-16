using System;
namespace LogicalPrograms
{
    public class Program
    {
        int num1;
        
        public void readData()
        {
            Console.WriteLine("Accept number:");
            num1 = Convert.ToInt32(Console.ReadLine());

        }
        public void PrimeNo()
        {
            if (num1 == 0 || num1 == 1)
            {
                Console.WriteLine(num1 + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine(num1 + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(num1 + " is a prime number");
                Console.ReadLine();
            }
        }
        public static void Main(string[] args)
        {
            Program p=new Program();
            p.readData();
            p.PrimeNo();


        }
    }
}