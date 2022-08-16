using System;

namespace Eztras1
{
    class Program
    {
        static void Main(string[] args)
        { 

          //Question 8
           /*
           Console.WriteLine("Program To Check the guess of the flip of a coin");

           Random coin= new Random();
           int headortail= coin.Next(0,2);
           Console.WriteLine($"{headortail}");

           Console.WriteLine("Guess If Head Or Tail");
           Console.WriteLine("Enter 0 for head and 1 for tail");
           int guess=int.Parse(Console.ReadLine());

           if(guess==headortail)
           {
             Console.WriteLine("The Guess Is CORRECT!");
           }
           else
           {
             Console.WriteLine("Hmm! The Guess Is NOT CORRECT! Try Again!");
           }
           */

           //Question 12// 
          /*
          Console.WriteLine("Program For Two Integers");
          
          Random book = new Random();
          int a= book.Next(100);
                    
          Random scroll= new Random();
          int b= scroll.Next(100);
         Console.WriteLine($"{a} +  {b}");
           int sum= a + b;
           int x = int.Parse(Console.ReadLine());        

           if (sum == x)
           {
            Console.WriteLine("true");
           }
           else  
           {
                Console.WriteLine("false");
           }*/

             //Question 13
                 /* 
                  Console.WriteLine("Program To Read The Balance, AnnualInterest Rate, and displays interest");

                  Console.WriteLine(" Find The Balance");
                  double balance= double.Parse(Console.ReadLine());

                  Console.WriteLine("Annual Interest Rate ");
                  double annualIntrate= double.Parse(Console.ReadLine());

                 double interest=0;
                 double a;
                  for (a=0; a<1; a++);
                  {
                    interest= balance*annualIntrate/1200;
                  } Console.WriteLine("The monthly interest for the next month is " +interest);*/


                 //Question 14
                 /*
                  Console.WriteLine("Future Investment Value");

                  Console.WriteLine(" Enter Investment Amount");
                  decimal invamt= int.Parse(Console.ReadLine());
                   Console.WriteLine("Annual Interest Rate");
                  double monthlyintrate= int.Parse(Console.ReadLine());
                  
                  Console.WriteLine("Number Of Years");
                  int numofyrs= int.Parse(Console.ReadLine());

                  double futIntval= invamt*(1+monthlyintrate)*(numofyrs)*(1+monthlyintrate)*12;
                  Console.WriteLine("The Future Investment Value is " +futIntval);*/

               //Question 4{GCD}
               
              //  Console.WriteLine("Enter FirstNumber");
              //  int num1=int.Parse(Console.ReadLine());
              //  Console.WriteLine("Enter The Second Number ");
              //  int num2= int.Parse(Console.ReadLine());
              //  while (num1>num2)
              //  {
              //    if (num1 !=num2)
              //    {
              //      num1-= num2;
              //     }
              //     else
              //     {
              //       num2-=num1;
              //     }
              //   } Console.WriteLine("The GCD Is  " +num1);





        }
    }
}
