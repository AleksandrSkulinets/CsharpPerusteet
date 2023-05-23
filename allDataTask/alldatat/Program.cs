using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class Student //Class
    {
        // Properties
        public string Name { get; set; }//string
        public double Points { get; set; }//double
        public bool Passed { get; set; }//bool

        // Constructor
        public Student(string name, int points)
        {
            Name = name;
            Points = points;
            Passed = (points >= 60); 
        }
        // Method

        public char GetInitial()//char
        {
            return Name[0];
        }
        
        //Function
        public void Congratulations()
        {
            Console.WriteLine("Congratulations {0}! You have passed.", Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentsArray = new Student[]//array
            {
                new Student("John", 90),
                new Student("Jane", 85),
                new Student("Bill", 45),
                new Student("Tom", 45)
            };

            List<Student> studentsList = new List<Student>();//List
            studentsList.Add(new Student("John", 90));
            studentsList.Add(new Student("Jane", 85));
            studentsList.Add(new Student("Bill", 45));
            studentsList.Add(new Student("Tom", 45));

            Console.WriteLine("Enter '1' to print list of students along with their points and pass/fail status.");
            Console.WriteLine("Enter '2' to print list of student initials.");
            Console.WriteLine("Enter '3' to check if any student has passed.");

            string userInput = Console.ReadLine();

            switch (userInput)//switch
            {
                case "1":
                    Console.WriteLine("Printing out pass/fail :");
                    foreach (Student student in studentsArray)//foreach
                    {
                        Console.WriteLine("{0} {1}", student.Name, student.Passed ? "Passed" : "Failed"); //ternary
                    }
                    break; 

                case "2":
                    Console.WriteLine("Student initials:");
                    for (int j = 0; j < studentsArray.Length; j++)//for 
                    {
                        char initial = studentsArray[j].GetInitial();//using method
                        Console.WriteLine("{0}: {1}", studentsArray[j].Name, initial);
                    }
                    break;

                case "3":
                    Console.WriteLine("Checking if any student has passed:");
                    int i = 0;//int
                    while (i < studentsArray.Length)//while
                    {
                        if (studentsArray[i].Passed)//if
                        {
                            studentsArray[i].Congratulations();//using function
                        }
                        i++;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
