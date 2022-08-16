using System;

namespace ExplanationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("For Provided Ten Numbers Get the highest");
            int largest =0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Next number");
                int nextNumber= int.Parse(Console.ReadLine());
                if( nextNumber > largest )
                {
                    largest = nextNumber;
                }                             
            }Console.WriteLine("Largest is " + largest);
              
              /*

               { Console.WriteLine("A Company sells Three Products");
                 bool playOn= true;
                 while(playOn)

                {Console.WriteLine("Enter Product Number");
                int product=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter quantity of product");
                double quantity= Convert.ToDouble(Console.ReadLine());

                double totalvalue;
                

                if(product==1)
                {
                    totalvalue= 2.98*quantity;
                    Console.WriteLine(totalvalue);
                }
                else if(product==2)
                {
                    totalvalue= 4.50*quantity;
                    Console.WriteLine(totalvalue);
                }
                else if(product==3)
                {
                    totalvalue= 9.98*quantity;
                    Console.WriteLine(totalvalue);
                }
                else
                {
                    Console.WriteLine("We Do Not Have This Kind Of Product"); 
                }
                 Console.WriteLine("Enter Exit For user To Leave The App or Continue to Proceed using");
                 string response= Console.ReadLine();
                 if (response=="Continue" )
                 {
                     playOn=true;
                 }
                 else
                 {
                     playOn=false;
                 }
                // }*/
                //     decimal acctbal= 25000.00m;
                //     decimal charges= 0.1m;
                //  Console.Write("Enter Amount To transfer");
                //   decimal amount= decimal.Parse(Console.ReadLine());
                //   Console.WriteLine(DateTime.Now);

                //  if(DateTime.Now.Hour>16)
                //  {
                //      charges= amount*(10/100m);
                //      amount+=charges;
                //  }
                //  else
                //  {
                //    charges= amount*(5/100m);
                //    amount+=charges;
                //  }
                //    charges= (DateTime.Now.Hour>16)? amount*10/100M: 0.5m*amount; 
                //    amount+=charges;

                //     if(amount>acctbal)
                //    {
                //     Console.WriteLine("Inadequate Amount...Transfer Cannot Be Activated");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Charges is : " +charges);
                //        Console.WriteLine("Your New Account Balance Is: "+(acctbal- amount));
                //    }

                        //  int numberoftrials=0;
                        //  bool isValid= true;
                        //  while (!isValid && number<=5)
                        // {
                        //      Console.WriteLine("Enter your Number");
                        //       int number= int.Parse(Console.ReadLine());
                        //     if (number<=10;&& number >0 )
                        //     {
                        //      isValid=false;
                        //      numberoftrials++;
                        //     }
                        //     else
                        //    {
                        //     numberoftrials++;
                        //    }
                             
                        // } Console.WriteLine("Thank You For Using Our App! Your Number of trials is " +numberoftrials++);
                 

                //  Console.Write("Enter Day");
                //  int day= int.Parse(Console.ReadLine());

                //  switch(day)

                // int i=0;
                // int sum=0;
                // while(i<100)
                // {
                    
                //    i++;
                //    sum=sum+i;
                //    Console.WriteLine(i ,sum);
                // }
            // //  for(int k=0, w=0;  w<10; w<5; k<10; k++; w--)
            // //  {
            //      Console.WriteLine(5.0==5L);
            // //  }




            
             int []a = new int[5];
             for(int i=0; i<=a.Length-1; i++ )
              {
                 Console.WriteLine ("Enter Number");
                 a[i]= int.Parse(Console.ReadLine());
                 
               } Console.WriteLine($"The product of the numbers is {Product(a)}");
                //    } Console.WriteLine($"The average of the given five numbers is {Mean(a)}");
                

            
              int Getsum(int [] numbers )
               { 
                  int sum=0;
                  for(int w=0; w<numbers.Length; w++ )
                  {
                      sum+=numbers[w];
                  } return sum;


            //     }

              //    double Mean(int [] a)
              //    {
              //      int sum= Getsum (a);
               //      double average= (double)sum / a.Length;
              //      return average;
               //    }
              

                


        }
    }
}
