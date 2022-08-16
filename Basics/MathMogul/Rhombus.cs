using System;

namespace MathMogul
{
    public class Rhombus : IFOR2DSHAPES
    {
        public double Diagonals{get;set;}
         public virtual double GetArea()
        {
            Console.WriteLine("Enter the value of the first diagonal");
            double P= double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of the second diagonal");
            double Q = double.Parse(Console.ReadLine());
            double area = 0.5 * (P * Q);
            Console.WriteLine($"The Area of the given circle is {area}");
            return area;
        }
        public double CalculateShapePerimeter()
        {
            Console.WriteLine("Enter the value of the side");
            double side= double.Parse(Console.ReadLine());
            double perimeter= 4*(side);
            return perimeter;
        }

          public void OperationToCarry()
        {
            var rhombus= new Rhombus();
            Console.WriteLine("What operation would you like to perform.\n. Enter 1. For Area 2.For Perimeter\n");
            int useroption= int.Parse(Console.ReadLine());
            switch(useroption)
            {
                case 1:
                rhombus.CalculateShapePerimeter();
                break;
                case 2:
                rhombus.GetArea();
                break;
                default:
                Console.WriteLine("Dear user, return to the main menu to check for operation on the Menu");
                break;

            }
        }
    }
}