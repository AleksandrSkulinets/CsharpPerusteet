using System;

namespace lecture28._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 Silmukat - loops
            // While(condition) 
            //{
            // Execute done
            // as long as condition == true
            //}
            //komentointi ctrl + k sitten ctrl + c
            // poistu ctrl+k sitten ctrl+u
            //
            //while (true);
            //{
            // Console.WriteLine(moi);
            //}
            string input = "";
            while (input != "exit")
            { Console.Write("Chose action:");
                input = Console.ReadLine();
                Console.WriteLine($"Executing action {input}");
            }



        }
    }
}
