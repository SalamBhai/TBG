using System;
using System.Collections.Generic;
namespace RegisterApp
{
    public class Program
    {

        static List<Student> Students = new List<Student>();

        static void Main(string[] args)
        {
Register();

        }


        static void Register()
        {
            var firstName = Prompt.PromptString("Enter your first name: ");
            var lastName = Prompt.PromptString("Enter your last name: ");
            var birthYear = int.Parse(Prompt.PromptString("Enter your year of birth", Prompt.ValidateYear));
            var instituion = Prompt.PromptString("Enter your institution: ");
            var course = Prompt.PromptString("Enter your course: ");
            var gender = Prompt.PromptString("Enter your gender: ", Prompt.ValidateGender).ToUpper();

            var student = new Student(firstName, lastName, GenerateRegNo(), birthYear, gender, instituion, course);

            Students.Add(student);
        }

        static string GenerateRegNo(){
            Random random = new Random();

            return $"JM{random.Next(1,1000).ToString("0000")}{(char)('A' + random.Next(26))}{(char)('A' + random.Next(26))}";
        }
    }

}