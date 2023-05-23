using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greet("Ryan"));

            if(Greet("Ryan") =="Hello, Ryan how are you doing today?")
            {
                Console.WriteLine("Method works");
            }
            else
            {
                Console.WriteLine("Method does not works");
            }

            Console.WriteLine(CheckForFactor(10, 2));
            Console.WriteLine(CheckForFactor(9 , 2));



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        public static string Greet(string name)
        {
            return "Hello, " + name + " how are you doing today?"; 
            throw new NotImplementedException("Greet is not implemented.");
        }
        public static bool CheckForFactor(int num, int factor)
        {
            // code here
            if (num % factor == 0)
            {
                return true;
            }
            return false;
        }
        public static int[] CountPositivesSumNegatives(int[] input)
        {

            int countP = 0;
            int sumN = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    countP += 1;
                }
                else if (input[i] < 0)
                {
                    sumN += input[i];
                }
            }
            return new int[] { countP, sumN }; //return an array with count of positives and sum of negatives
        }
    }
}
