using System;
using System.Collections.Generic;

namespace MathMogul
{
    public class Circle : IFOR2DSHAPES
    {
        public double Radius { get; set; }


        public double GetArea()
        {
            Console.WriteLine("Enter the radius of  the circle");
            double _radius = double.Parse(Console.ReadLine());
            double Area = Math.PI * (Math.Pow(_radius, 2));
            Console.WriteLine($"The Area of the given circle is {Area}");
            return Area;
        }

        public double CalculateShapePerimeter()
        {
          Console.WriteLine("Enter the radius of the circle");
          double radius= double.Parse(Console.ReadLine());
          double Perimeter= 2* (Math.PI)*radius;
           Console.WriteLine($"The Perimeter of the given circle is {Perimeter}");
          return Perimeter;
        }

        public void OperationToCarry()
        {
            var circle= new Circle();
            Console.WriteLine("What operation would you like to perform.\n. Enter 1. For Area 2.For Perimeter\n 3. For parts of the circle ");
            int useroption= int.Parse(Console.ReadLine());
            switch(useroption)
            {
                case 1:
                circle.CalculateShapePerimeter();
                break;
                case 2:
                circle.GetArea();
                break;
                case 3: circle.WhatPart();break;
                default:
                circle.UserMenurespect();
                break;

            }
        }
        public void WhatPart()
        {
            Console.WriteLine("What part of the circle do you want to make calculations on?\n  1.For Semi-Circle\n 2.For Sector\n");
            int part= int.Parse(Console.ReadLine());
            switch (part)
            {
                case 1: SemiCircle.OperationToCarry(); break;
                case 2: Sector.OperationToCarry(); break;
                default:Console.WriteLine("Dear user, option is not available in the menu please be kind to help suggest your request on our socialmedia handles! We shall provide you with this in our updates! Thank you!");break;
            }
        }
    }
}