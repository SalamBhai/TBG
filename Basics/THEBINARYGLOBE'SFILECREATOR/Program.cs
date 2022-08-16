using System;

namespace DIY_Create_AFileAndAsktheuserwhathewouldaddtoit
{
    class Program
    {
        static void Main(string[] args)
        {
           bool Continue=true;
            Console.WriteLine(" I am BinBot! Your Assisstant! May I know your name? ");  
             FileAndRespect.UserName = Console.ReadLine(); 
            do
            { 
                FileAndRespect.GreetUser();
                string Content = Console.ReadLine();
                FileAndRespect.WriteToFile($".\\Binary Globe {FileAndRespect.UserName} User File Manager.txt", Content);
                Console.WriteLine($"Would you like to continue adding to the created file Dear {FileAndRespect.UserName}\n. Enter 1. For Yes\n 2. For No\n ");
                int option = Convert.ToInt32(Console.ReadLine());
                Continue=FileAndRespect.AskForAppToEnd(option);
            }while(Continue);
            Console.WriteLine("Would You Like to  check the contents of your file?\n  Enter 1.For Yes\n  2. For No\n");
            int choice=int.Parse(Console.ReadLine());
            if(choice.Equals(1))
            {
                foreach (var information in FileAndRespect.ReadFromFile($".\\Binary Globe {FileAndRespect.UserName} User File Manager.txt"))
                {
                    Console.WriteLine(information);
                }
                FileAndRespect.SaluteUser();
            }
            else if(choice==2)
            {
               FileAndRespect.SaluteUser();
            }

        }


    }
}
