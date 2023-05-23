using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine(IsCube(125,-5));

            Console.WriteLine(Remove_char("Testaus"));

            #endregion
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        public static bool IsCube(double volume, double side)
        {
            double testVolume = side * side * side;

            if (volume == testVolume && side > 0 && volume > 0)
            {
                return true;
            }
            
            return false;
            
        }
        public static string Remove_char(string s)
        {
            //return s.Substring(1, s.Length -2); 
            string result = "";
            for(int i = 1; i < s.Length - 1; i++)
            {
                result += s[i];
            }
            return result;
        }

    }
    
}
