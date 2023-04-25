using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //33 C# String: Merkkien tulostus
            #region
            Console.Write("Syötä sana ja tulostus suunta (\"Lattia A\"): ");
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            if (inputSplit[1] == "A")
            {

            }
            else if (inputSplit[1] == "L")
            {
                char[] chars = inputSplit[0].ToCharArray();
                Array.Reverse(chars);
                string test = new string(chars);
                inputSplit[0] = test;

            }
            foreach (char jokinNimi in inputSplit[0])
            {
                Console.WriteLine(jokinNimi);
            }
            #endregion
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
           
        }
    }
}
