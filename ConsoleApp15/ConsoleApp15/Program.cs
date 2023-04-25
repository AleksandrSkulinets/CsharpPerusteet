using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Console.WriteLine("Enter your word and how many letters delete (\"Omena\"1)" );
            string input = Console.ReadLine();
            // string[] splitInput = input.Split(' ');
            //string result1 = splitInput[0].Substring(int.Parse(splitInput[1]), splitInput[0].Length - (int.Parse(splitInput[1]) * 2));
            //Console.WriteLine(result1);

            //// vaihtoehto 2

            //string result2 = "";
            //for (int i = int.Parse(splitInput[1]); i < splitInput[0].Length - int.Parse(splitInput[1]); i++)
            //{
            //    result2 += splitInput[0][i];
            //}
            //Console.WriteLine(result2);
            //// vaihtoehto 3
            string[] splitInput = new string[1];
            bool inputHasError = true;
            while(inputHasError==true)
            {
                Console.WriteLine("Enter your word and how many letters delete (\"Omena\"1)");
                input = Console.ReadLine();
                splitInput = input.Split(' ');
                if (int.Parse(splitInput[1]) > 0 && int.Parse(splitInput[1]) * 2 < splitInput[0].Length)
                    {
                    inputHasError = false;
                    }
            }

            //int i = int.Parse(splitInput[1]);
            //string cut = string.Concat(input.Skip(i).Take(input.Length - i * 2));
            //Console.WriteLine(cut);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
