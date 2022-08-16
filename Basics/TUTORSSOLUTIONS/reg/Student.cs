using System;

namespace reg
{
    public class Student
    {

        protected int Matric;

        protected string Name;

        protected int Age;

        protected string State;

        public string Email;

        protected decimal Payment;

        protected bool IsCleared;

        public Student(decimal payment, bool iscleared)
        {
            Payment = payment;
            IsCleared = iscleared;
        }

        public virtual void PrintStudentDetails()
        {
            Console.WriteLine($"You have successfully been registered and you {(IsCleared ? "have" : "have not")} been cleared");
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}