using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luokka / Class
            Person personA = new Person();
            personA.Age = 30;
            personA.Name = "Juho";
            Console.WriteLine($"Henkelö A nimi on {personA.Name} ja ikä on {personA.Age} ");

            Person personB = new Person(25, "Matti", 1.8, new List<Pet>());


            Person personC = new Person(35, "Jesse", 1.78, new List<Pet>());


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    } // class Program
      // class - avainsana
      // Test - oma luokan nimi
    class Person
    {
        //2a Property

        //kirjoita prop and sen jalken sarkain kaksi kerta
        // Propertyn syntaksi: [Näkkyvyys][datatyyppi][nimi][get ja set]
        public int Age { get; set; }
        public string Name { get; set; }

        public double Lengh { get; set; }

        public Location CurrentLocation { get; set; }

        public List<Pet> Pets { get; set; }

       


        //2b Constractor     
        // [Näkkyvyys]
        // [nimi]
        public Person()
        {

        }
        public Person(int age, string name, double lenth, List<Pet> pets)
        {
            Age = age;
            Name = name;
            Lengh = lenth;
            Pets = pets;
            
        }

        //2c Metodi / Method
        public double Walk(Location newLocation)
        {
            int result = CurrentLocation.CoordinateX - newLocation.CoordinateX;
            CurrentLocation = newLocation;
            return result;
        }
    }
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Location
        {
        public int CoordinateX { get; set; }

        }
} //Nmaespace
