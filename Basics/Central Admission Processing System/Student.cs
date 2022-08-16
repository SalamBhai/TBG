using System;
using System.Collections.Generic;
using System.IO;


namespace Central_Admission_Processing_System

{
    class Student
    {

         
        string FirstName;
        string LastName;
        private string RegNumber;
        string YearOfBirthInNums;
        string Institution;
        public string Gender;

        string Course;
        private bool IsAdmitted;
        private string History;

        List<Student> Students = new List<Student>();
           
        

        public Student(string firstName, string lastName, string institution, string course, string yearofbirth, string gender, string regNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirthInNums = yearofbirth;
            Institution = institution;
            Gender = gender;
            Course = course;
            RegNumber = regNumber;
            IsAdmitted = false;
            History = "";

        }

        public Student()
        {

        }

        public string GetRegNumber()
        {
            return $"{RegNumber}";
        }
        public string GetFirstName()
        {
            return $"{FirstName}";
        }
        public string GetLastName()
        {
            return $"{LastName}";
        }
        public string GetInstitution()
        {
            return $"{Institution}";
        }
        public string GetCourse()
        {
            return $"{Course}";
        }
        public string GetYearOfBirth()
        {
            return $"{YearOfBirthInNums}";
        }


        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }
        public void SetInstitution(string institution)
        {
            Institution = institution;
        }
        public void SetCourse(string course)
        {
            Course = course;
        }
        public void SetYearOfBirth(string yOB)
        {
            YearOfBirthInNums = yOB;
        }


        public void Register()
        {
             
             Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("How many students would you like to register?");
            int nums = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nums; i++)
            {
                Console.WriteLine(" Welcome To CAPS! Enter Your Year Of Birth");
                int YearOfBirth = int.Parse(Console.ReadLine());
                int ValidYear = DateTime.Now.Year - YearOfBirth;
                if (ValidYear > 0 && ValidYear <= 18)
                {

                    Console.WriteLine("Hello Student! You are not eligible for registration");
                    Console.WriteLine("Please Register Another User");
                }
                else if (ValidYear >= 18)
                {
                    Console.WriteLine("Welcome! To The JAMB Portal");

                    Console.WriteLine("Enter Your FirstName");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Enter Your LastName");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Enter Year Of Birth ");
                    string yearOf = Console.ReadLine();


                    Console.WriteLine(" Student Gender");
                    string gender = Console.ReadLine();

                    Console.WriteLine("Enter your preferred  institution");
                    string institution = Console.ReadLine();

                    Console.WriteLine("Enter course of choice");
                    string course = Console.ReadLine();

                    string regNumber = GenerateRegNumber();

                    Student student = new Student(firstName, lastName, institution, course, yearOf, gender, regNumber);
                    Students.Add(student);

                    Console.WriteLine($"{PrintRegistrationStatus(firstName, lastName, regNumber)}");

                }
                Console.WriteLine("Would you like to register Another Student?\n 1. To continue,\n 2. To End");
                var respond = int.Parse(Console.ReadLine());
                if (respond == 1)
                {
                    continue;
                }
                else if (respond == 2)
                {
                    break;
                }
            }
        }
        private string GenerateRegNumber()
        {
            Random random = new Random();
            return $"JM{random.Next(1, 1000).ToString("0000")}{(char)('A' + random.Next(26))}{(char)('A' + random.Next(26))}";
        }
        public string PrintRegistrationStatus(string firstName, string lastName, string regNumber)
        {
           
            return $"Dear {firstName} {lastName} you have successfully been registered for the {DateTime.Now.Year}'s Unified Tertiary Matriculation Examination(UTME) your registration number is {regNumber}";
        }

        public void AdmissionStatus()
        {
            Console.WriteLine("Enter Your Registration Number");
            string RegNo = Console.ReadLine();
            foreach (var student in Students)
            {
                if (student.RegNumber == RegNo && student.IsAdmitted == true)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine($" Congratulations! Dear {student.FirstName} {student.LastName} You have been admitted to {student.Institution} to study {student.Course}");

                }
                else if (student.RegNumber == RegNo && student.IsAdmitted != true)
                { 
                    Console.ForegroundColor= ConsoleColor.Magenta;
                    Console.WriteLine($"Dear Aspirant {student.FirstName} {student.LastName} you are yet to get admitted to {student.Institution} pay regular attention to checking your status on CAPS!");
                }
            }

        }

        public void UpdateDetails()
        {
            Console.WriteLine($"Enter Your Registration Key to  update your status ");
            string regKey = Console.ReadLine();

            foreach (var item in Students)
            {
                Console.WriteLine("Enter the amount of info to change");
                int howmany = int.Parse(Console.ReadLine());

                for (int i = 1; i <= howmany; i++)
                {
                    if (item.RegNumber == regKey)
                    {
                        Console.WriteLine("What information would you like to change?");
                        Console.Write("Enter 1. TO Update FirstName\n 2.To Update LastName\n 3.To Update Course\n 4 To update Institution\n 5. To update Year Of Birth\n 6. To Update Gender\n");
                        int response = int.Parse(Console.ReadLine());
                        switch (response)
                        {
                            case 1:
                                Console.WriteLine("Enter your FirstName to update");
                                item.FirstName = Console.ReadLine();
                                History += $"FirstName to {item.FirstName}";
                                break;
                            case 2:
                                Console.WriteLine("Enter your LastName to update");
                                item.LastName = Console.ReadLine();
                                History += $"LastName to {item.LastName}";

                                break;
                            case 3:
                                Console.WriteLine("Enter your Course to update");
                                item.Course = Console.ReadLine();
                                History += $"Course to {item.Course}\n  ";
                                break;
                            case 4:
                                Console.WriteLine("Enter your Institution to update");
                                item.Institution = Console.ReadLine();
                                History += $"Your change of institution  has been updated to   {item.Institution} \n";
                                break;
                            case 5:
                                Console.WriteLine("Enter Your correct year of birth");
                                item.YearOfBirthInNums = Console.ReadLine();
                                History += $" Success! Year of birth has been updated  to  {item.YearOfBirthInNums}\n";
                                break;
                            case 6:
                                Console.WriteLine("Enter your gender to update ");
                                item.Gender = Console.ReadLine();
                                History += $"Your gender is now updated to {item.Gender}\n";
                                break;
                            default:
                                Console.WriteLine("Your request is not of the list of Request");
                                break;
                        }

                    }
                   
                }
              PrintUpdateHistory();

            }
        }
        public void PrintUpdateHistory()
        {
            Console.WriteLine($"Update Success : {History}\n");
        }


        public void AdmitStudents()
        {
            Console.WriteLine("Enter 1. To Admit Students by Registration Number\n 2. Through Course\n 3. Through Institution  ");
            int validate = Convert.ToInt32(Console.ReadLine());
            if (validate == 1)
            {
                Console.WriteLine("Enter Your Registration Number");
                string RegiNo = Console.ReadLine();
                foreach (var student in Students)
                {
                    if (student.RegNumber == RegiNo)
                    {
                        student.IsAdmitted = true;
                        Console.WriteLine("Admission Success!");
                    }
                }
            }
            if (validate == 2)
            {
                Console.WriteLine("Enter your course of choice");
                string course = Console.ReadLine();
                foreach (var student in Students)
                {
                    if (student.Course == course)
                    {
                        student.IsAdmitted = true;
                        Console.WriteLine("Admission Success!");

                    }
                }

            }
            if (validate == 3)
            {
                Console.WriteLine("Enter your Choice of institution");
                string institution = Console.ReadLine();
                foreach (var student in Students)
                {
                    if (student.Institution == institution)
                    {
                        student.IsAdmitted = true;
                        Console.WriteLine("Admission success!");
                    }
                }
            }


        }

    }
}
