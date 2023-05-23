using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            string current  = Console.ReadLine();

            Console.WriteLine(UpdateLight(current));
            
        }
        public static string UpdateLight(string current)
        {
            string result = "";
            switch (current)
            {
                case "green":
                    return result = "yellow";
                case "yellow":
                    return result ="red";
                case "red":
                    return result="green";              
            }

        }
    }
}
