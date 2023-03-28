using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            bool priceCorrect = false;

            while(!priceCorrect)
            {
                Console.Write("hinta =");
                int price = int.Parse(Console.ReadLine());
                if (price <= 100 && price >= 0)
                {
                    Console.WriteLine($"price with discount= {price - (price * 0.1)}");
                }
                else if (price >= 100)
                {
                    Console.WriteLine($"price with discount= {price - (price * 0.25)}");
                }
                else 
                    { Console.WriteLine("price is wrong");
                }
                
            }
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
