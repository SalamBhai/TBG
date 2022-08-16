using System;

namespace MathMogul
{
    public class Sector
    {
   
       
        public double GetArea()
        {
           Console.WriteLine("Enter the angle of the sector");
           double angle= double.Parse(Console.ReadLine());
           Console.WriteLine("Enter the value of the radius of the circle");
           double radius= double.Parse(Console.ReadLine());
           double area= angle/360 *(Math.PI * (Math.Pow(radius, 2)));
           return area;
        }
        public double GetPerim()
        {
            Console.WriteLine("Enter the angle");
            double angle= double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the radius");
            double radius= double.Parse(Console.ReadLine());
            double perimeter= 2*radius*(1+(angle*Math.PI)/180);
            return perimeter;
        }

        public static void OperationToCarry()
        {
            Sector sector= new Sector();
            Console.WriteLine("What operation would you like to perform?");
            int option= int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                sector.GetArea();
                break; 
                case 2: sector.GetPerim(); break;
                default:
                Console.WriteLine("Invalid input");
                break;
            }
             sector.GetArea();
        }
    }
    
}