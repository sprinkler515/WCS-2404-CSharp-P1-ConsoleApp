namespace P1_AppConsole
{
    public class Student : Campus
    {
        public int ID { get; private set; }
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public double Age { get; private set; }
        public string? Birthdate { get; private set; }
        public Dictionary<string, Dictionary<int, string>> Grades { get; private set; }
        public double Average { get; private set; }

        public Student()
        {
            Grades = [];
        }

    }
}
