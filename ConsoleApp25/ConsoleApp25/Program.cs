using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.codewars.com/kata/5cd5ba1ce4471a00256930c0/train/csharp

          

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        public static int[] LastDigit(long n, int d)
        {
            // Jos d on negatiivinen, palautetaan tyhjä taulukko
            if (d < 0)
            {
                return new int[] { };
            }

            string asText = n.ToString();

            if (d > asText.Length)
            {
                d = asText.Length;
            }
            int[] result = new int[d];
           
            int arrayIndex = result.Length - 1;
          
            for (int i = asText.Length - 1; i >= asText.Length - d; i--)
            {
                result[arrayIndex] = int.Parse(asText[i].ToString());
                arrayIndex--;
            }

            return result;
        }
    }
}
