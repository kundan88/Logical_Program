using System;
class Program
{
    int n1 = 0, n2 = 1, n3, i, number;
    public void readData()
    {
        Console.Write("Enter the number of elements: ");
        number = int.Parse(Console.ReadLine());
        Console.Write(n1 + " " + n2 + " ");
    }
    public void Febonacci()
    {

        for (i = 2; i < number; ++i)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
    }

        public static void Main(string[] args)
        {
        Program p=new Program();
        p.readData();
        p.Febonacci();


        }
    }

