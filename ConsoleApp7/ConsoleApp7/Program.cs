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
            
            string EVEN_TEXT = "parillinen";
            string ODD_TEXT = "pariton";
            Console.WriteLine("Syötä luku");
            int number = int.Parse(Console.ReadLine());
            string input = "";
            bool inputFalse = true;
            while (inputFalse)
            {
                Console.Write($"{EVEN_TEXT} / {ODD_TEXT} :");
                input = Console.ReadLine();
                if (input == EVEN_TEXT)
                {
                    inputFalse = false;
                }
                else if(input == ODD_TEXT)
                {
                    inputFalse = false;

                }
            }
            int startingPoint = input == EVEN_TEXT ? 2 : 1;
            for (int i = startingPoint; i <= number; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
