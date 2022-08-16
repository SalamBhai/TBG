using System;

namespace firstclassafterassessment
{
    class Program
    {
        static void Main(string[] args)
        {
              //Question 3
             /*
             Console.WriteLine("For Position Of Student's Average");

             Console.WriteLine("Enter Your Average");
             int average= int.Parse(Console.ReadLine());

             if (average>=90|| average==100)
             {
               Console.WriteLine("4");
             }
             else if(average>=80 || average==89)
             {
               Console.WriteLine("3");
             }
             else if (average>=70|| average==79)
             {
               Console.WriteLine("2");
             }
             else if(average>=60|| average==69)
             {
               Console.WriteLine("1");
             }
             else if  (average<60)
             {
               Console.WriteLine("0");
             }*/
              
                // Question 5
               /*
                Console.WriteLine("Program To Calculate Distance Between Two Points");

                Console.WriteLine("Enter x1");
                double x1= double.Parse(Console.ReadLine());
                Console.WriteLine("Enter x2");
                double x2= double.Parse(Console.ReadLine());
                 Console.WriteLine("Enter y1");
                double y1= double.Parse(Console.ReadLine());
                 Console.WriteLine("Enter y2");
                double y2= double.Parse(Console.ReadLine());

                double distbtwtwopts= Math.Sqrt((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1));
                double approximate= Math.Round(distbtwtwopts);
                Console.WriteLine("The Distance Between Two Points X1 and X2 and Distance Y2 and Y1 is " +approximate);*/
      
            //Question 9
            // Question that reads three integers as sides from user and computes the perimeter if every pair of two edges is greater than a side of the three sides//
                // Console.WriteLine("Enter Three Integers");

                // Console.WriteLine("edge 1");
                // int edge1= int.Parse(Console.ReadLine());

                // Console.WriteLine("edge 2");
                // int edge2= int.Parse(Console.ReadLine());

                // Console.WriteLine("edge 3");
                // int edge3= int.Parse(Console.ReadLine());
              
                // int perimeter= edge1+edge2+edge3;
                // if (edge1+edge2>edge3 && edge1+edge3>edge2)
                // {
                //  Console.WriteLine("The Input Is Valid!");
                // }
                // else
                // {
                //   Console.WriteLine("The Input Is Not Valid!");
                // }

                // Question 10
               /*
                Console.WriteLine("Enter Monthly Saving Amount");
                double mthlySavingAmt= double.Parse(Console.ReadLine());
                double monthlyintrate= 1+0.00417;
                 double monthlyreturn= mthlySavingAmt*monthlyintrate;
                  
                  
                  double firstmonthReturn= monthlyreturn;
                  Console.WriteLine("Return for the first month is the " +firstmonthReturn);

                  double secondmonthReturn= monthlyreturn+firstmonthReturn;
                   Console.WriteLine("Return for the first month is the " +secondmonthReturn);

                  double thirdmonthReturn= monthlyreturn+secondmonthReturn;
                   Console.WriteLine("Return for the first month is the " +thirdmonthReturn);

                  double fourthmonthReturn= monthlyreturn+thirdmonthReturn;
                   Console.WriteLine("Return for the first month is the " +fourthmonthReturn);

                  double fifthmonthReturn= monthlyreturn+fourthmonthReturn;
                  Console.WriteLine("Return for the first month is the " +fifthmonthReturn);

                  double sixthmonthReturn= monthlyreturn+fifthmonthReturn;
                  Console.WriteLine("The Monthly Return For The Sixth Month is "+sixthmonthReturn);


                   Console.ReadKey();*/

              



              //Question 11
              
              // Console.WriteLine(" Conversion From Chinese RMB To Dollars And From Dollars To Chinese RMB");

              // Console.WriteLine( "enter 0 to Convert For Chinese RMB To Dollars And 1 for Dollars To Chinese RMB Take EXCHANGE amount as 306 RMB");
              // int response= int.Parse(Console.ReadLine());

              // if(response==0)
              // {
              //   Console.WriteLine("Enter Amount To Convert in Dollars To Chinese RMB ");
              //   int exchamt= int.Parse(Console.ReadLine());
              //   int conversion= exchamt*306;
              //   Console.WriteLine("The Converion Amount Of From Dollars To Chinese RMb " +conversion);
              // }
              // else if( response==1)
              // {
              //   Console.WriteLine("Enter Amount To Convert From Chinese RMB To Dollars");
              //   int exchamt=int.Parse(Console.ReadLine());
              //   int conversion= exchamt/306;
              //   Console.WriteLine("The Converted amount of  chinese rmb to dollars is "+conversion);
              // }
             
             

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
                  } Console.WriteLine("The monthly interest for the next month is " + interest);*/

                  //Question 14
                 /*
                  Console.WriteLine("Future Investment Value");

                  Console.WriteLine("Investment Amount");
                  int invamt= int.Parse(Console.ReadLine());

                  Console.WriteLine("Annual Interest Rate");
                  double monthlyintrate= int.Parse(Console.ReadLine());
                  
                  Console.WriteLine("Number Of Years");
                  int numofyrs= int.Parse(Console.ReadLine());

                  double futIntval= invamt*(1+monthlyintrate)^(numofyrs)*12;
                  Console.WriteLine("The Future Investment Value is " +futIntval);*/

                  // Question 15
                  /*
                  Console.WriteLine("Program To Calculate a year and days from minutes entered");

                  Console.WriteLine("Enter For Minutes");
                  double minutes= double.Parse(Console.ReadLine());
                   Console.WriteLine("Total Minutes In a year=60*60*24");
                   double minsinayr= 525600;
                   
                   double year=Math.Floor (minutes/minsinayr);
                   double day= Math.Floor (minutes%minsinayr)/1440;
                   Console.WriteLine($"The number of years is {year} and with {day} number of days");*/
    }   }
} 
