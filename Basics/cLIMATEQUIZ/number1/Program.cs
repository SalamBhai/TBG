using System;

namespace number1
{
    class Program
    {
        static void Main(string[] args)
        {
            
             Console.WriteLine("Multiple Choice Quiz Questions About The Climatic Change And Global Warming.");

            Console.WriteLine("Enter From Options Lettered A To D For The Correct Options ");

           Console.WriteLine("First Question");

           Console.WriteLine("Question: What percentage Of The Earth's Atmosphere Is Comprised of carbon dioxide, otherwise known as the GreenHouse Gas (GHG)?");

           Console.WriteLine(" Options: A: 0.04. B. 1.04; C. 4.04; D. 40.04");
           Console.WriteLine("Enter Your Answer");
           char response= Convert.ToChar(Console.ReadLine());
           char answer= 'A';
           if(response==answer)
           {
               Console.WriteLine("You Got It Right!");
            }
           else if(response!=answer)
           {
             Console.WriteLine("Incorrect! The Correct Answer Is 0.04 which falls in the option A");
           }
          Console.WriteLine("Second Question");

           Console.WriteLine(" Which Of These Countries Emit The Most Carbon Dioxide?");
           Console.WriteLine("Options: A. U.S.A B: U.K C: China D: Russia");
           Console.WriteLine("Enter Your Answer!");
           char response= Convert.ToChar(Console.ReadLine());
           char answer= 'B';
           if (response==answer)
           {
               Console.WriteLine("Correct!");
           }
           else if(response!=answer)
           {
             Console.WriteLine("Incorrect! The Correct Option Is A. China");
           }
           Console.WriteLine("Third Question");
           Console.WriteLine("What Was Agreed To In The  (Paris Agreement) that came out of COP-21, held in Paris in 2015 ");
           Console.WriteLine("Options: A. To Protect BioDiversity and end the deforestation of the world's rainforests B. To keep global temperature rise well below 2 degrees Celsius; C. To Limit sea level rise to 3 feet above current levels; 4. To pirsue a goal of 100% clean, renewable energy!");
           Console.WriteLine("Enter Your Answer!");
           char response= Convert.ToChar(Console.ReadLine()); 
           char answer= 'B';
           if(response==answer)
           {
             Console.WriteLine("Correct!");
           }
           else if(response!=answer)
           {
             Console.WriteLine("Incorrect!");
           }
          
           Console.WriteLine("Fourth Question");

           Console.WriteLine("True Or False: The Overwhelming Majority Of Scientists Agree That Climate Change Is Real and caused by humans");
           Console.WriteLine("Option: True Or False");
           Console.WriteLine("Enter Your Answer!");
           string response= Console.ReadLine();
           string answer="True";

           if(response==answer)
           {
             Console.WriteLine("Correct!");
           }
           else if(response!=answer)
           {
             Console.WriteLine("Incorrect!");
           }

           Console.WriteLine("Fifth Question");

           Console.WriteLine("What Is The Greenhouse Effect?");
           Console.WriteLine("Option: A. The Name Of Climate Change That Was Passed By Congress B. When You Paint your house green to become an environmentalist C. When the gases in our atmosphere trap heat and block it from escaping our planet D. When you build a green house");
           Console.WriteLine("Enter Your Answer!");
           char response= Convert.ToChar(Console.ReadLine());
           char answer= 'C';

           if(response!=answer)
           {

             Console.WriteLine("Correct!");
            }

           else if(response!=answer)
           {
             Console.WriteLine("Incorrect!");
           }
           
           Console.WriteLine("How Many Questions did you get right? Enter number to get your grade");
           int score= int.Parse(Console.ReadLine());

           if (score==5)
           {
             Console.WriteLine("Excellent!");
           }
           else if(score==4)
           {
             Console.WriteLine(" Very Good!");
           }
           else if(score<=3)
           {
            Console.WriteLine("Good Trial! Learn About The Climate For More!");
           }
           else
           {
             Console.WriteLine("Questions Not Attempted!");
           }

          






        }
    }
}
