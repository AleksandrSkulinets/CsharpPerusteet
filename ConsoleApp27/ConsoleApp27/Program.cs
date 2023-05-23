using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FireFight("Boat Rudder Mast Boat Hull Water Fire Boat Deck Hull Fire Propeller Deck Fire Deck Boat Mast"));


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        public static string FireFight(string s)
        {
            return s.Replace("Fire", "~~");
        }
    }
}
