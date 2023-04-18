using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ikä:");
            int age = int.Parse(Console.ReadLine());

            if (age <= 0 && age >= 120 )
            {
                Console.WriteLine("Ikä ei ole järkevä");

            }
          
            else
            {
                Console.WriteLine("Ikä on järkevä");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        {
    }

}
