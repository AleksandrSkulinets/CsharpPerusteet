using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            string input;
            double a;
            double h;
            double A;

            Console.Write("a=");
            input = Console.ReadLine();
            a = Double.Parse(input);

            Console.Write("h=");
            input = Console.ReadLine();
            h = Double.Parse(input);

            A = a * h / 2


            Console.WriteLine($"A= {A}");

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
