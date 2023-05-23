using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1 2 3 4 5";
            string[] numbersAsStrings = input.Split(' ');
            int[] numbers = new int[numbersAsStrings.Length];

            Console.WriteLine(InvertValues(numbers));

            Console.WriteLine();

            Console.ReadKey();
        }
        public static int[] InvertValues(int[] input)
        {
            //Code it!
            int[] rinput  = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                rinput[i] = -input[i];
            }
            return rinput;
        }
    }
}
