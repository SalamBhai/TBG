using System;

namespace MathMogul
{
    public class Parallelogram : IFOR2DSHAPES
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double GetArea()
        {
            Console.WriteLine("Enter the height of the Parallelogram");
            Height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Base");
             Base = double.Parse(Console.ReadLine());
            double area = Base * Height;
            Console.WriteLine($"The Area of the Rectangle is {area}");
            return area;
        }
        public double CalculateShapePerimeter()
        {
            Console.WriteLine("Enter A for the adjacent side length");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b. The base length of The Parallelogram");
            double blength = double.Parse(Console.ReadLine());
            double perimeter = 2 * (sideA + blength);
            Console.WriteLine($"The Perimeter of the given circle is {perimeter}");
            return perimeter;
        }

        
          public void OperationToCarry()
        {
            var paral= new Parallelogram();
            
            Console.WriteLine("What operation would you like to perform.\n. Enter 1. For Area 2.For Perimeter\n");
            int useroption= int.Parse(Console.ReadLine());
            switch(useroption)
            {
                case 1:
                paral.CalculateShapePerimeter();
                break;
                case 2:
                paral.GetArea();
                break;
                default:
                Console.WriteLine("Dear user, return to the main menu to check for operation on the Menu");
                break;

            }
        }

    }
}