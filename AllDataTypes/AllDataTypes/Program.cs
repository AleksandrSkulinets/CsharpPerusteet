using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://moodle.sakky.fi/mod/assign/view.php?id=1171271
            // C# Kaikkien aiheiden kertaus
            /*
            Tee sovellus, jossa käytät kaikkia opiskeltuja aiheita.
            Voit itse keksiä logiikat.
            1. Datatyypit
            int, string, double, char, bool
            2. Valintarakenteet
             - if/else
             - switch
             - ternary - EXTRA
            3. Silmukat
             - for
             - while
             - foreach
            4. Taulukot ja listat
            - taulukko
            - lista
            5. Funktio ja luokat
            - funktio, joka tekee jonkin toiminnon
            - luokka, jossa on propertyja, constructor ja metodi
            */
            

            List<Students> studentsList = new List<Students>();
            Students[] students = new Students[3];
            


            studentsList.Add(new Students { Name = "John", Mark = 90, Subjects = 3 });
            studentsList.Add(new Students { Name = "Jane", Mark = 85, Subjects = 4 });
            studentsList.Add(new Students { Name = "Bill", Mark = 45, Subjects = 7 });
            

            while (true)
            {
                string name = "";

                Console.WriteLine("Enter student name (or type 'n' to stop):");
                string stop = Console.ReadLine();

                if (stop == "n")
                {
                    break;
                }

                Console.WriteLine("Enter student mark:");
                int mark = int.Parse(Console.ReadLine());

                bool studentExists = false;

                foreach (Students student in studentsList)
                {
                   
                    if (student.Name == name)
                    {
                        Console.WriteLine("Student already exists!");
                        studentExists = true;
                        break;
                    }
                }

                if (!studentExists)
                {
                    studentsList.Add(new Students { Name = name, Mark = mark });
                    Console.WriteLine("Student added.");
                }
            }

            foreach (Students student in studentsList)
            {
                Console.WriteLine("Student {0}: Points = {1}", student.Name, student.Points(student.Subjects, student.Mark));
            }


            Console.WriteLine("Press any key to exit...");
          Console.ReadKey();
        }
    }
}
