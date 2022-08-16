using System;

namespace Explanationpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
           int num= int.Parse(Console.ReadLine());
           var result=((num % 2==0)? "It Is an Even Number" :"Odd Number");
             Console.WriteLine(result);
        
              Console.WriteLine("To Calculate using Bodmas");
                // var digits= (0.5>0.10)? "It Is This": "It Is That";
               // Console.Write(digits);

                 // Program that gets from user the score, for five subjects; math, eng, chem, physics, biology, calculate percentage and grade according to the following
             
             Console.Writeline("Enter Score For Math");
             int mathscore= int.Parse(Console.ReadLine());

             Console.Writeline("Enter Score For English");
             int engscore= int.Parse(Console.ReadLine());

              Console.Writeline("Enter Score For Chem");
             int chemscore= int.Parse(Console.ReadLine());

             Console.Writeline("Enter Score For Phy");
             int physcore= int.Parse(Console.ReadLine());

                Console.Writeline("Enter Score For Biology");
                int bioscore= int.Parse(Console.ReadLine());


                int maxscore= 500;
              int percentage1= mathscore/maxscore*100;
               int percentage2= engscore/maxscore*100;
             int percentage3= chemscore/maxscore*100;
             int percentage4= physcore/maxscore*100;
             int percentage5= bioscore/maxscore*100; 





                // For Math//
                if(percentage1>=90)
                {
                    Console.WriteLine("Grade A");
                }
              else if (percentage1>=80)
              {
                  Console.Write("Grade B");
              }
              else if(percentage1>=70)
              {
                  Console.Write("Grade C");
              }
              else if(percentage1>=60)
              {
                  Console.WriteLine("Grade D");
              }
              else if(percentage1>=40)
              {
                  Console.WriteLine("Grade E");
              }
            else if( percentage1<40)
            {
                Console.WriteLine("Grade F");
            }

            // For english
            if (percentage2>=90)
            {
                Console.WriteLine("Grade A");
            }
            else if(percentage2>=80)
            {
                 Console.WriteLine("Grade B");
            }
         else if(percentage2>=70)
         {
          Console.WriteLine("Grade C");
         }
       
         else if(percentage2>=60)
         {
              Console.WriteLine("Grade D");
         }
         else if(percentage2>= 40)
         {
             Console.WriteLine("Grade E");
         }
         else if (percentage2<40)
         {
             Console.Write("Grade F");
         }

         // For chem

         if(percentage3>=90)
         {
             Console.Write("Grade A");
         }
          else if(Percentage3>=80)
          {
              Console.Write("Grade B");
          }
         else if(percentage3>=70)
         {
             Console.Write("Grade C");
         }
          else if(percentage3>=60)
          {
              Console.Write("Grade D");
          }
          else if(percentage3>=40)
          {
              Console.Write("Grade E");
          }
          else if(percentage3<40)
          {
            Console.Write("Grade F");
          }


          



        }
    }
}
