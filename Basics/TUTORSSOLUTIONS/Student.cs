namespace RegisterApp
{
    public class Student
    {
        private string FirstName;
        private string LastName;
        private string RegNo;
        private int BirthYear;
        private string Gender;
        private string Institution;
        private string Course;
        private bool IsAdmitted;

        public Student(string firstName, string lastName, string regNo, int birthYear, string gender, string institution, string course)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            Gender = gender;
            Institution = institution;
            Course = course;
            RegNo = regNo;
        }
    }
}