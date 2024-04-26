namespace P1_AppConsole
{
    public class Student : Campus
    {
        private string? FirstName { get; set; }
        private string? LastName { get; set; }
        private string? Birthdate { get; set; }
        private Dictionary<string, Dictionary<int, string>> Grades { get; set; }
        private double Average { get; set; }

        public Student(string firstName, string lastName, string birthdate) : base(lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Grades = [];
        }

    }
}
