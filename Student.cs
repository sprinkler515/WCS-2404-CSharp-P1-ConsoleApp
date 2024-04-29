using System.Security.Cryptography.X509Certificates;

namespace P1_AppConsole
{
    public class Student : Campus
    {
        private int _id;
        public int ID
        {
            get
            {
                while (Students.ContainsKey(_id))
                {
                    Random rand = new();
                    _id = rand.Next(StudentsCapacity);
                }
                return _id;
            }
        }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Birthdate { get; set; }
        private List<Grade> Grades { get; set; }
        private double Average { get; set; }

        public Student()
        {
            Random rand = new();
            _id = rand.Next(StudentsCapacity);
            SetFirstName();
            SetLastName();
            SetBirthdate();
            Grades = [];
        }

        private void SetFirstName()
        {
            FirstName = "";

            while (String.IsNullOrEmpty(FirstName) || FirstName.Length < 2)
            {
                Console.Write("Enter first name: ");
                FirstName = Console.ReadLine() ?? "";
                if (String.IsNullOrEmpty(FirstName) || FirstName.Length < 2)
                    Console.WriteLine("Error. Enter a valid name.");
            }
            Console.WriteLine();
        }

        private void SetLastName()
        {
            LastName = "";

            while (String.IsNullOrEmpty(LastName) || LastName.Length < 2)
            {
                Console.Write("Enter last name: ");
                LastName = Console.ReadLine() ?? "";
                if (String.IsNullOrEmpty(LastName) || LastName.Length < 2)
                    Console.WriteLine("Error. Enter a valid name.");
            }
            Console.WriteLine();
        }

        private void SetBirthdate()
        {
            Birthdate = "";

            while (String.IsNullOrEmpty(Birthdate) || Birthdate.Length < 2)
            {
                Console.Write("Enter birthdate: ");
                Birthdate = Console.ReadLine() ?? "";
                if (String.IsNullOrEmpty(Birthdate) || Birthdate.Length < 2)
                    Console.WriteLine("Error. Enter a valid name.");
            }
            Console.WriteLine();
        }
    }
}
