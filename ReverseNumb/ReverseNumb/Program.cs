using System;

namespace Reverse_Number
{
    class Program
    {
        int num, temp, remainder, reverse = 0;
        public void readData()
        {
            Console.WriteLine("Enter an integer \n");
            num = int.Parse(Console.ReadLine());
            temp = num;
        }
        public void ReverNum()
        {
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("Given number is = {0}", temp);
            Console.WriteLine("Its reverse is = {0}", reverse);
            Console.ReadLine();
        }
      public static void Main(string[] args)
        {
            Program p=new Program();
            p.readData();
            p.ReverNum();

            
           
        }
    }
}