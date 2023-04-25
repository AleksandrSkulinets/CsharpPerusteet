using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numbers to count");
            int numbersToSum = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 0; i<numbersToSum; i++ )
            {
                Console.Write($"give number {i} ");
                sum = sum + int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"Sum of given nubers is {sum} averege is {sum / numbersToSum} ");


            Console.ReadKey();


            
          
        }
    }
}
