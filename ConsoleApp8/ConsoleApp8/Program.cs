using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = int.Parse(Console.ReadLine());
            double number2 = int.Parse(Console.ReadLine());

            bool number2Correct = false;

            while (!number2Correct)
            {
                if (number1 < number2)

                { Console.WriteLine("You haven´t guessed, my number is smaller"); }

                else if (number1 > number2)

                { Console.WriteLine("You haven´t guessed, my number is bigger"); }
                else if (number1 == number2)

                       { Console.WriteLine("You have guessed, my number is same"); }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
