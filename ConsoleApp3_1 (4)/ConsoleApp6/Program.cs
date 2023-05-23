using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Pinta-alat ja tilavuudet (Yhdessä päivä 10)
            //https://moodle.sakky.fi/mod/assign/view.php?id=1159681

            Square squareOne = new Square(5 , 10);

            Console.WriteLine($"Area of square is {squareOne.Area()}");
            Console.WriteLine($"Circumference is {squareOne.Circumference()}");


            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
    public class Square
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Square(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Area()
        {
            return Width * Height;
        }
        public double Circumference()
        {
            return (Width * 2) + (Height * 2);
        }
    }
   
}
