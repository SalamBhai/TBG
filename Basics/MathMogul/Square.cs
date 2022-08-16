using System;

namespace MathMogul
{
    public class Square: IFOR2DSHAPES 
    {
        public double GetArea()
        {
          Console.WriteLine("Enter the length of the Square");
          double length= double.Parse(Console.ReadLine());
          double area=  Math.Pow(length, 2);
           Console.WriteLine($"The Area of the square is {area}Cmsqr.");
          return area;
        }
        public double CalculateShapePerimeter()
        {
            Console.WriteLine("Enter the length of the Square");
            double length= double.Parse(Console.ReadLine());
            double perimeter= 4 * (length);
            Console.WriteLine($"The Perimeter of the square is {perimeter}");
            return perimeter;
            
        }

         public void OperationToCarry()
        {
            var square= new Square();
            Console.WriteLine("What operation would you like to perform.\n. Enter 1. For Area 2.For Perimeter\n");
            int useroption= int.Parse(Console.ReadLine());
            switch(useroption)
            {
                case 1:
                square.CalculateShapePerimeter();
                break;
                case 2:
                square.GetArea();
                break;
                default:
                Console.WriteLine("Dear user, return to the main menu to check for operation on the Menu");
                break;

            }
        }
    }
}