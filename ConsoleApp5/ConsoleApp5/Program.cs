using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double num;

            Console.Write("Write your number:");
            input = Console.ReadLine();
            num = double.Parse(input);

            if (num >= 0)
            { Console.WriteLine("Your number is bigger than 0");
            }
            else 
            Console.WriteLine("Your number smaller than 0");
            Console.ReadKey();

         
        }
    }
}
