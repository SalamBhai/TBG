using System;

namespace MathMogul
{
    public class Rectangle : IFOR2DSHAPES
    {

        public double Length {get;set;}
        public double Breadth{get;set;}
         public double GetArea()
        {
            Console.WriteLine("Enter the length of the rectangle");
            double length= double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the rectangle");
            double breadth= double.Parse(Console.ReadLine());
             double area=  Length*Breadth;
            Console.WriteLine($"The Area of the Rectangle is {area}");
            return area;
        }

        public double CalculateShapePerimeter()
        {
          Console.WriteLine("Enter the length of the rectangle");
            double length= double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the rectangle");
            double breadth= double.Parse(Console.ReadLine());
            double Perimeter= 2*(length+breadth);
           Console.WriteLine($"The Perimeter of the given circle is {Perimeter}");
          return Perimeter;
        }

        public void OperationToCarry()
        {
            var circle= new Circle();
            Console.WriteLine("What operation would you like to perform.\n. Enter 1. For Area 2.For Perimeter\n");
            int useroption= int.Parse(Console.ReadLine());
            switch(useroption)
            {
                case 1:
                circle.CalculateShapePerimeter();
                break;
                case 2:
                circle.GetArea();
                break;
                default:
                Console.WriteLine("Dear user, return to the main menu to check for operation on the Menu");
                break;

            }
        }
    }
}