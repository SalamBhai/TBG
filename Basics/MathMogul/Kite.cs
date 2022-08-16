using System;

namespace MathMogul
{
    public class Kite : IFOR2DSHAPES
    {
        public double GetArea()
        {
            int[] diagonals = new int[2];
            int prod = 1;
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"Enter the value of diagonal {i + 1} ");
                diagonals[i] = int.Parse(Console.ReadLine());
                prod *= diagonals[i];
            }
            double area = 0.5 * (prod);
            Kite kiti = new Kite();
            kiti.PrintOperation("Area", area, "Kite");
            return area;
        }

        public void KitePerim()
        {
            Console.WriteLine("What is the length of the first diagonal");
            double d1= double.Parse(Console.ReadLine());
            Console.WriteLine("What is the value of the second diagonal");
            double d2= double.Parse(Console.ReadLine());
            double perimeter= 2*d1 + 2*d2;
            Kite kite= new Kite();
            kite.PrintOperation("Perimeter" , perimeter, "Kite");
        }
        public static void OperationToCarry()
        {
            var kit= new Kite();
            Console.WriteLine("What operation would you like to perform.\n. Enter 1. For Area 2.For Perimeter\n");
            int useroption = int.Parse(Console.ReadLine());
            switch (useroption)
            {
                case 1:
                    kit.KitePerim();
                    break;
                case 2:
                   kit.GetArea();
                    break;
                default:
                    kit.UserMenurespect();
                    break;

            }
        }
    }
}