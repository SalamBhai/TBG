using System;

namespace reg
{
    public class NewStudent : Student
    {
        public NewStudent(string name, int age, string state, string email, decimal payment, bool iscleared) : base(payment, iscleared)
        {
            Name = name;
            Age = age;
            State = state;
            Email = email;
            Matric = GenerateMatricNumber();
        }

        private int GenerateMatricNumber()
        {

            Random random = new Random();

            return random.Next(1000, 10000);
        }

        public void NewStudentMethod()
        {

        }
    }
}