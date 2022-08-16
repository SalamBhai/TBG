using System;

namespace MathMogul
{
    public class Trapezium : IFOR2DSHAPES
    {
        public double Height { get; private set; }
        public double Base { get; private set; }


        public double GetArea()
        {
            Console.WriteLine("Enter the value of the Height");
            double height = double.Parse(Console.ReadLine());
            double[] Base = new double[2];
            double sumbase = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter the value of base {i + 1}");
                Base[i] = double.Parse(Console.ReadLine());
                sumbase += Base[i];
            }
            double area = 0.5 * (sumbase * (Height));
            Console.WriteLine($"The area of the trapezium is {area}Cmsqr");
          return area;
        }

        public  double CalculateShapePerimeter()
        {
            double[] sides = new double[4];
            double perimeter = 0;
            for (int i = 0; i < sides.Length; i++)
            {
                Console.WriteLine($"Enter the side {i + 1} ");
                sides[i] = double.Parse(Console.ReadLine());
                perimeter += sides[i];
            }
            Console.WriteLine($"The perimeter of the shape is {perimeter}");
            return perimeter;
        }
        public static void OperationToCarry()
        {
            var trap= new Trapezium();
            Console.WriteLine("What operation would you like to perform.\n. Enter 1. For Area 2.For Perimeter\n");
            int useroption = int.Parse(Console.ReadLine());
            switch (useroption)
            {
                case 1:
                    trap.CalculateShapePerimeter();
                    break;
                case 2:
                   trap.GetArea();
                    break;
                default:
                    Console.WriteLine("Dear user, please return to the main menu to check for the required on the Menu");
                    break;

            }
        }

    }
}