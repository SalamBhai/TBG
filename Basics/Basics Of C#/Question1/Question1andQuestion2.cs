using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        { 
          
        //  bool playOn =true;

        //  while(playOn)
        //  {
        //    Random random= new Random();
        //    int prediction= random.Next(1,1000);
        //    Console.WriteLine($"{prediction}");

        //    bool guessOn=true;
        //     while(guessOn)
        //     {
        //        Console.WriteLine(" A Guess Game App");

        //        Console.WriteLine("Enter A Guess");
        //        int guess=int.Parse(Console.ReadLine());
              
        //        if (guess>prediction)
        //        {
        //         Console.WriteLine("Oops!You have entered A Number Too High, Try again with aims on a lesser number!");
        //        }
        //         else if( guess< prediction)
        //         {
        //            Console.WriteLine("Oops! You aimed at a number too low! Aim Higher");
        //         }
        //          else if(guess==prediction)
        //         {
        //           Console.WriteLine("Congratulations! You have made an accurate guess!");
        //           guessOn=false;
        //         }
               
        //         Console.WriteLine("Enter N  To Continue And Y To Exit!");  
        //           string response= Console.ReadLine();
        //          if(response=="N")
        //           {
        //             playOn=true;
        //           }
        //           else
        //           {
        //            playOn=false;
        //           }
        //     }

         
        //   }
              //Question2
              
            bool tossOn=true;
            while(tossOn)
            {
              int headCount=0;
              int tailCount=0;
              
              Random random= new Random();
              int appearance= random.Next(0,2);
              Console.WriteLine($"{appearance}");

               bool tossCoin=true;
               while(tossCoin)
               {

                Console.WriteLine("Coin Tossing App");

                Console.WriteLine("Would you like to toss a coin?");
                string response= Console.ReadLine();

                if(response== "yes")
                {
                 Console.WriteLine (" Toss Coin 0 for head and 1 for tail");
                 int toss= int.Parse(Console.ReadLine());
                   if (toss==appearance)
                   { 
                   Console.WriteLine("You won the toss!");
                   }
                   else if (toss!= appearance)
                     { 
                       Console.WriteLine("Oops! You lost the toss!");
                        
                        
                      }

                }
               else if (response=="no")
                { 
                Console.WriteLine("do not play!");
                tossCoin=false;
                }  
                Console.WriteLine("Would You Like To Continue With This Game?");
                string interest= Console.ReadLine();
                      
                if (interest=="N")
                {
                  
                 tossOn=true;
                }

                else if (interest== "Y")
                {
                   tossOn=false;   
                  break;
                   
                }Console.WriteLine("The number of heads is " +headCount);
                 Console.WriteLine("The number of tails is  " +tailCount);
                      

              }


            }

        
        }
    }
}

