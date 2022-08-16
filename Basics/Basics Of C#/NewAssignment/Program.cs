using System;

namespace NewAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Program to convert to lower case");
             Console.WriteLine("User Name");
             string name= Console.ReadLine().ToLower();
             Console.WriteLine($"The User name is {name}");*/



             Console.WriteLine("Program To Project true or false  If Two Digits Given if both numbers are even or odd ");
             Console.WriteLine("Enter First number");
             int a= int.Parse(Console.ReadLine());
             Console.WriteLine("Second number");
             int b= int.Parse (Console.ReadLine());

             if(a%2==0 && b%2==0 )
             {
               Console.WriteLine("True");
             }
             else if(a%2==1 && b%2 == 1 )
             {
                 Console.WriteLine("False");
             }
             else
             {
                 Console.WriteLine("Not A Natural Number!");
             }
             
        }

    }
}
