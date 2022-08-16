using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 10 + 11 + 13 + 12 + 14 + 15 + 16 + 18 + 19 + 20;
            Console.WriteLine($"the total sum of ten digits is equal to: {y}");

            int sum = 25 + 35 + 15 + 20 + 30;
            Console.WriteLine( $"\t the total sum of t digits is equal to: {sum}");

            string r_id = "Adebowale Bernard ";
            string  schl = "Government College Ibadan ";
            string e_mail = "adewaleoloyede@gmail.com ";
            string nationality = "Nigerian ";
            Console.WriteLine($" Library Identity Of Adebowale Bernard {r_id} {schl} {e_mail} {nationality}");


            Console.WriteLine("Program To Calculate Area Of A triangle ");
            Console.WriteLine("Take B as base and h as height ");
            double B = Convert.ToDouble(Console.ReadLine());
            double H = Convert.ToDouble(Console.ReadLine());
            double half = 0.5;
            Console.WriteLine("The Area Of The Triangle");
            double area = (B *H)*half;
            Console.WriteLine($" The area is :{area}");

           
           Console.WriteLine("Program To Calcute The Average of Three Numbers");
          double num1 = 10;
          double num2 = 15;
          double num3 = 20;
         double average = (num1 + num2 + num3) /3;
         Console.WriteLine($"\t The average of the program that reads {num1} {num2} and {num3} is: {average}");
            

         Console.WriteLine( "incomplicated Program For The Calculation of Digit1, Digit2, and Digit3");
         Console.WriteLine( "Enter Digit1");
         double digit1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine( "Enter Digit2");
         double digit2 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine( "Enter Digit3");
         double digit3 = Convert.ToDouble(Console.ReadLine());
         double result = (digit1 + digit2 + digit3 ) /3 ; 
         Console.WriteLine($"\t The average of {digit1} {digit2} {digit3} is {result}");


         Console.WriteLine( "incomplicated Program For The Multiplication of Digit1, Digit2, and Digit3");
         Console.WriteLine( "Enter Digit1");
         double digit12 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine( "Enter Digit2");
         double digit13 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine( "Enter Digit3");
         double digit14 = Convert.ToDouble(Console.ReadLine());
         double output = (digit12 * digit13 * digit14 ) ; 
         Console.WriteLine($"\t The multiplication of {digit12} {digit13} {digit14} is {output}");

         Console.WriteLine("The Program For name, age, Phone Number");
         
         Console.WriteLine("New User: ");
         Console.WriteLine("Name:");
         string name = (Console.ReadLine());
         Console.WriteLine("Age: ");
         int age = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Phone Number: ");
         int phone_number = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine($"\t The Program for the age, Phone number and age of a New user of the New York Library " {name} {age} {phone_number}" " );


       
        }
    }
}

 