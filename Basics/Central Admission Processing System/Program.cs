using System;
using System.Collections.Generic;

namespace Central_Admission_Processing_System
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Student> Students = new List<Student>();

            Console.ForegroundColor = ConsoleColor.Red;
            bool Menu = true;
            Student student = new Student();

            while (Menu)
            {
                Console.WriteLine("What Would you like to do? ");
                Console.Write("Enter 1. To Register Aspirant\n Enter 2. To Check Admission Status\n Enter 3. To Update Aspirant Details\n Enter 4. To Enable Student's Admission\n Enter 5. To Exit App\n");
                int response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 1:
                       student.Register();
                        break;
                    case 2:
                        student.AdmissionStatus();
                        break;
                    case 3:
                        student.UpdateDetails();
                        break;
                    case 4:
                        student.AdmitStudents();
                        break;
                    case 5:
                        Console.WriteLine("Good Bye!");
                        Menu = false;
                        break;
                }
                


            }
             Dictionary <string, int> studscore= new Dictionary<string, int> ();
             studscore.Add("Sheriff", 97);
             studscore.Add("Wills", 100);
             studscore.Add("Smith",78);
             
             



        }









    }
}






