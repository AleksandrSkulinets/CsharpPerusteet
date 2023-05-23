using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Verolaskuri (Yhdessä päivä 9)
            Console.WriteLine("Syötä pallka: ");
            decimal wage = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Syötä vero prosenttia : ");
            decimal percent  = decimal.Parse(Console.ReadLine());

            
            Console.WriteLine($"Palkka netto on: {nettoWage(wage ,  percent)}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
       
        private static decimal nettoWage(decimal wage, decimal percent)

        {
            decimal result = wage - (wage * percent / 100);
            decimal pr= (wage * percent / 100);
            return result;
            return pr;
        }
    }
}

