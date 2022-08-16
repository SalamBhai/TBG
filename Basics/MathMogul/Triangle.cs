using System;

// There are some exceptions for this class triangle
namespace MathMogul
{
    public class Triangle : IFOR2DSHAPES
    {

        public double Base { get; set; }
        public double Height { get; set; }

        public double CalculateShapePerimeter()
        {
            double[] sides = new double[3];
            double sum = 0;

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"Enter side {i + 1}");
                sides[i] = double.Parse(Console.ReadLine());
                sum += sides[i];
            }
            Console.WriteLine($"The perimeter pf the three sides of the triangle is {sum}");

            return sum;
        }
        public static double GetOrderArea()
        {
            Console.WriteLine("Enter the base of the given triangle");
            double Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the given triangle");
            double Height = double.Parse(Console.ReadLine());
            double area = 0.5 * Base * Height;
            Console.WriteLine($"The Area of the given circle is {area}");
            return area;
        }
        public double GetArea()
        {
            Console.WriteLine("What type of triangle?");
            Console.WriteLine("Enter 1. For Equilteral triangle\n 2. For others\n");
            double area=1;
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: Triangle.GetEquiArea(); break;

                case 2: Triangle.GetOrderArea(); break;



                default:  Console.WriteLine("invalid input! Please try within the range of options provided!"); break;
                   
                   


            }
            return area;
        }
        public static double GetEquiArea()
        {
            Console.WriteLine("For equilateral triangle enter the side of the  triangle");
            int side = int.Parse(Console.ReadLine());
            double area = Math.Sqrt(3) / 4 * (Math.Pow(side, 2));
            return area;
        }


        public static void OperationToCarry()
        {
            var triangle = new Circle();
            Console.WriteLine("What operation would you like to perform.\n. Enter 1. For Area 2.For Perimeter\n");
            int useroption = int.Parse(Console.ReadLine());
            switch (useroption)
            {
                case 1:
                    triangle.CalculateShapePerimeter();
                    break;
                case 2:
                    triangle.GetArea();
                    break;
                default:
                    Console.WriteLine("Dear user, please return to the main menu to check for the required on the Menu");
                    break;

            }
        }
    }
}