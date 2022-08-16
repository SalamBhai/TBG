using System;

namespace MathMogul
{
    public class SemiCircle 
    {
       public  double GetArea()
        {
            Console.WriteLine("Enter the radius of  the circle");
            double _radius = double.Parse(Console.ReadLine());
            double Area =  (Math.PI * (Math.Pow(_radius, 2)))/2;
            Console.WriteLine($"The Area of the given circle is {Area}Cmsqr");
            return Area;
        }

        public  double CalculateShapePerimeter()
        {
          Console.WriteLine("Enter the radius of the Semicircle");
          double radius= double.Parse(Console.ReadLine());
          double Perimeter= (2* (Math.PI)*radius)/2;
           Console.WriteLine($"The Perimeter of the given circle is {Perimeter}");
          return Perimeter;
        }

        public static void OperationToCarry()
        {
            SemiCircle semi= new SemiCircle();
            Console.WriteLine("What operation would you like to perform.\n. Enter 1. For Area 2.For Perimeter\n");
            int useroption= int.Parse(Console.ReadLine());
            switch(useroption)
            {
                case 1:
                semi.CalculateShapePerimeter();
                break;
                case 2:
                semi.GetArea();
                break;
                default:
                Console.WriteLine("Dear user, return to the main menu to check for operation on the Menu");
                break;

            }
        }




    }
}