using System;
using System.Collections.Generic;

namespace StudentApp
{
    public class StudentManager
    {
        readonly FileManager _fileManager = new FileManager(".\\file.txt");
        List<Student> Students = new List<Student>();

        public StudentManager()
        {
            LoadContentFromFile();
        }

        public void Create()
        {
            Console.WriteLine("Enter Your FirstName: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Your LastName: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Gender: ");
            string gender = Console.ReadLine();
            var student = new Student(firstName, lastName, email, phoneNumber, age, gender, Students.Count < 0 ? 1 : Students.Count + 1);  // This is a ternary operator used in making a conditional statement that if the numbers of students in the list is less than 0, the count of the students should be 1. Else, if the number of the Students in the file is greater than 0, the Count of the student should increase.
            Save(student);
            Console.WriteLine($"Admission Success! {firstName} {lastName} has been registered successfully ");
        }

        public void Update()
        {
            Console.WriteLine("Enter the RegNumber of the student you want to Find: ");
            string regNumber = Console.ReadLine().Replace(" ", "");
            var student = Find(regNumber);
            if (student != null)
            {
                student.UpdateInfo();
                Refresh();
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

         public void RemoveStudent()
        {
            Console.WriteLine("Enter the RegNumber of the student you want to remove: ");
            string regNumber = Console.ReadLine().Replace(" ","");
            var student = Find(regNumber);
            if (student != null)
            {
                Students.Remove(student);
                Refresh();
                Console.WriteLine($"The student {student.FirstName} {student.LastName}  with {regNumber} has been removed successfully");
            }
            else
            {
                Console.WriteLine("Student not found");
            }


        }


        public void Find()
        {
            Console.WriteLine("Enter the RegNumber of the student you want to Find: ");
            string regNumber = Console.ReadLine();
            foreach (var student in Students)
            {
                if (student.RegNumber == regNumber)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
        public Student Find(string regNumber)
        {

            foreach (var student in Students)
            {
                if (student.RegNumber == regNumber)
                {
                    return student;
                }
            }
            return null;
        }

        public void List()
        {

            foreach (var student in Students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        private void LoadContentFromFile()
        {
            foreach (var line in _fileManager.Read())
            {
                Student student = Student.ConvertToStudent(line);
                Students.Add(student);
            }
        }
        private void Refresh()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (i == 0)
                {
                    _fileManager.Write(Students[i].ToString(), false);
                }
                else
                {
                    _fileManager.Write(Students[i].ToString());
                }
            }
        }

        private void Save(Student student)
        {
            Students.Add(student);
            _fileManager.Write(student.ToString());
        }

       
    }
}