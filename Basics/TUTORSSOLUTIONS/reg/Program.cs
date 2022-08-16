using System;

namespace reg
{
    class Program
    {
        static void Main(string[] args)
        {
            OldStudent oldStudent = new OldStudent(2000, true);


            NewStudent newStudent = new NewStudent("Ilyasu", 45, "Kwara", "newStudent1@student.com", 1000, false);
            NewStudent newStudent2 = new NewStudent("Abbass", 405, "Oyo", "newStudent2@student.com", 1000, true);

            oldStudent.PrintStudentDetails();
            newStudent2.PrintStudentDetails();
            newStudent.PrintStudentDetails();
        }
    }
}
