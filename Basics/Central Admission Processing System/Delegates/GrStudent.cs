using System;
using System.Collections.Generic;

namespace Delegates
{
   
    public class GrStudent
    {
        
        public GrStudent(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public GrStudent()
        {

        }
         public delegate bool  MyDelegates(GrStudent student);
         List<GrStudent> students = new List<GrStudent> ();
        public string Name{get;set;}
       public int Age{get;set;}
       public string Gender{get;set;}
     
     public override string ToString()
     { 
         return $"Name: {Name},\n Age: {Age},\n Gender: {Gender}\n";

     }



       public void StudentsWithNameA(List<GrStudent> Student)
       {
           foreach (var item in Student)
           {
               if(item.Name.StartsWith('A'))
               {
                   Console.WriteLine(item.Name);
               }
           }
       }

       public bool StudentisFemale(GrStudent student)
       {
           return student.Gender.Equals("Female");
       }

       public bool StudentisFemaleOver20(GrStudent student)
       {
           return student.Gender.Equals("Female") && student.Age > 20;
       }
      

      
      
       
    }
}