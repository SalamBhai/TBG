using System;
using System.Collections.Generic;
namespace Delegates
{
    class Program
    {
        public delegate bool Sheriiff(GrStudent student);

        static void Main(string[] args)
        {
            List<GrStudent> students = new List<GrStudent>()
            {
              new GrStudent()
              {
                  Name= "Kilome",
                  Age= 17,
                  Gender= "Male"
              },
              new GrStudent()
              {
                  Name= "Simpson",
                  Age=21,
                  Gender= "Female"
              },

              new GrStudent()
              {
                  Name= "Simpon",
                  Age=21,
                  Gender= "Male"
              },


              new GrStudent()
              {
                  Name= "Simr",
                  Age=21,
                  Gender= "FeMale"
              },
              new GrStudent()
              {
                  Name= "Sims",
                  Age=21,
                  Gender= "FeMale"
              },
            };
            // Anonymous Function used for a delegate is here
            Sheriiff maleoflength5 = delegate (GrStudent student)
             {
                 return student.Gender.Equals("Male") && student.Name.Length > 4;
             };

            Sheriiff studentless20 = delegate (GrStudent student)
             {
                 return student.Gender.Equals("FeMale") && student.Age > 20;
             };

             PrintStudents("Students with age less than 20",students, s => s.Age < 20 );
             
             //PrintStudents("Male students with Name that begins with A", students, s => s.Name.StartsWith('S')) ;// Lambda Expressions
          

        }

        public static void  PrintStudents(string title, List<GrStudent> students, Sheriiff filter)
        {
            Console.WriteLine($"..........{title}...........");
            foreach (var student in students)
            {
                if(filter(student))
                {
                    Console.WriteLine(student);
                }
            }
        }
        



    }
}
