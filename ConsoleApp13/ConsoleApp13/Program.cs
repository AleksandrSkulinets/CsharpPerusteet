using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            // 33 C# String: Merkkien tulostus

            string text = "Hello World";
           
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
                
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
