using System;

namespace MathMogul
{
    public class Polygons: IFOR2DSHAPES
    {
        public void OperationToCarry()
        {
            var poly= new Polygons();
            Console.WriteLine("Dear Champ! What operation would you like to perform :\n Enter 1 for area\n Enter 2 for perimeter  ?");
            int userinput= int.Parse(Console.ReadLine());
            switch(userinput)
            {
              case 1:poly.GetArea();break; case 2: poly.CalculateShapePerimeter();break;

            }
        }

        public double GetArea()
        {
            Console.WriteLine("Have you the value of the apothem i.e (the line segment from the center to the midpoint of the side) of the regular polygon?");
             Console.WriteLine("Enter Y for yes and N for no");
            string response= Console.ReadLine();
            if (response.ToLower()=="y")
            {
                Console.WriteLine("The value of the apothem is ?");
                double apothem= double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of sides of the polygon");
                int n= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value of the side of the polygon");
                int side= int.Parse(Console.ReadLine());
                double area= n*side*(apothem)/2;
               Console.WriteLine($"The Area of the given circle is {area}");
                return area;
            }
            else if(response.ToLower()=="n")
            {
                Console.WriteLine("Enter the number of sides of the regular polygon");
                int numofsides= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value of the side of the polygon");
                int sid= int.Parse(Console.ReadLine());
                double apothem= numofsides/(2* Math.Tan(180/numofsides));
                 Console.WriteLine($"The Apothem of the polygon  is {apothem}");
                int perim= numofsides*sid;
                double area= perim*apothem/2; 
                 Console.WriteLine($"The Area of the {numofsides}-sided given polygon is {area}");
                 return area;
            }
            return GetArea();
        }

        public double CalculateShapePerimeter()
        {
            Console.WriteLine("Enter the number of sides");
            int numssides= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of the side of the polygon");
            int val= int.Parse(Console.ReadLine());
            double perimeter= numssides*val;
             Console.WriteLine($"The perimeter of the {numssides}-sided given shape is {perimeter}");
             return perimeter;
        }

    }
}