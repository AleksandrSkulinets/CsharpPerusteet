using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_16_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Compare(43,31));
            Console.WriteLine(Compare(43, 34));

            Console.WriteLine(IsDivisible(12, 4, 3));

            Console.ReadKey();
        }
        
            
          public static string Compare(int a, int b)
          {
            string aStr = a.ToString();
            string bStr = b.ToString();
            if (aStr[0] == bStr[0] && aStr[1] == bStr[1] || aStr[1] == bStr[0] && aStr[0] == bStr[1])
                return "100%";
            else if (aStr[0] == bStr[0] || aStr[0] == bStr[1] || aStr[1] == bStr[0] || aStr[1] == bStr[1])
                return "50%";
            else
                return "0%";
        }
        public static int[] BubbleSortOnce(int[] input)
        {
            // Code the Bubblesort Algorithm here :D
            int[] result = (int[])input.Clone();
            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] > result[i + 1])
                {
                    int temp = result[i];
                    result[i] = result[i + 1];
                    result[i + 1] = temp;
                }
            }
            return result;

        }
        public static bool IsDivisible(int n, int x, int y)
        {
            // your code
            return (n % x == 0 && n % y == 0) ? true : false;
        }
    }
}
