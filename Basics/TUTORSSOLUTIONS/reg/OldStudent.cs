using System;

namespace reg
{
    public class OldStudent : Student
    {

        private double CGPA;

        public OldStudent(decimal payment, bool iscleared) : base(payment, iscleared)
        {
            Name = "Olaide";
            Age = 20;
            State = "Akwa Ibom";
            Email = "Oldstudent@gmail.com";
            CGPA = 3.8;
            Matric = 3331234;
        }

        public override void PrintStudentDetails()
        {
            Console.WriteLine($"You are an active student with matric number {Matric} and {(IsCleared ? "have" : "have not")} been cleared");
        }

        public void OldStudentMethod()
        {

        }
    }
}