using System;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
        
         /* Console.WriteLine("Program For The Calculation of Perimeter Of Trapezium");

          Console.WriteLine("Enter a");
            double a= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter B ");
            double B= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter H");
            double H= Convert.ToDouble(Console.ReadLine());

            double perimeter= 0.5*(a + B)*H;

            Console.WriteLine($"The perimeter of the trapezium is : {perimeter}");*/
            

              Console.WriteLine("Enter Your Guess");
             int guess= Convert.ToInt32(Console.ReadLine());
              if(guess == 42)
            { 
             Console.WriteLine("You have brilliantly won the guess");
            }
           else if(guess > 42)
            { 
              Console.WriteLine("You lost The Guess, but try something lower next time");
            }
             else if(guess<42)
            { 
             Console.WriteLine("oh! Try something a bit higher next time ");
            }
             else 
            {
              Console.WriteLine("Oops! Invalid! Try again next Time");
            }  
              
            
             

  







        }
    }
}
