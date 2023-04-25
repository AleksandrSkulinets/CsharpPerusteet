using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä numreo");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä merkki");
            char symbol = char.Parse(Console.ReadLine());

            for(int i=1; i<=number; i++)
            {
                Console.Write(symbol);
            }
            Console.ReadKey();


        }
    }
}
