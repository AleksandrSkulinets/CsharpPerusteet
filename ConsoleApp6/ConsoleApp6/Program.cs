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
            //Console.WriteLine("Syötä luku");
            //int number = int.Parse(Console.ReadLine());
            //int i = 1;
            //Console.WriteLine("pariton/parillinen");
            //string input = Console.ReadLine();

            //while (i <= number)
            //{
            //    if (i % 2 != 0 && input == "pariton")
            //    {
            //        Console.WriteLine(i);                    
            //    }
            //    else if (i % 2 == 0 && input == "parillinen")
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}            


            //Console.ReadKey();

            string EVEN_TEXT = "parillinen";
            string ODD_TEXT = "pariton";
            Console.WriteLine("Syötä luku");
            int number = int.Parse(Console.ReadLine());
            string input = "";
            string input = Console.ReadLine();
            while (input != EVEN_TEXT || input != ODD_TEXT)
            {                
                Console.Write($"{EVEN_TEXT}/{ODD_TEXT}");               
            }
            int sstartingPoint = input == "parillinen" ? 2 : 1;
            // parillinen alkaa 2
            // pariton alkaa 1

        }


    }
}
