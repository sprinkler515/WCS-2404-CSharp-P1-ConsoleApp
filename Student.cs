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
                foreach (Student student in Students)
                    while (_id == student.ID)
                    {
                        Random rand = new();
                        _id = rand.Next(0, MaxStudentsCapacity);
                    }
                return _id;
            }
            set { _id = value; }
        }
        private string? FirstName { get; set; }
        private string? LastName { get; set; }
        private string? Birthdate { get; set; }
        private List<Grade> Grades { get; set; }
        private double Average { get; set; }

        public Student()
        {
            Random rand = new();
            _id = rand.Next(MaxStudentsCapacity / 10, MaxStudentsCapacity);
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
                LastName = Console.ReadLine() ?? "";
                if (String.IsNullOrEmpty(Birthdate) || Birthdate.Length < 2)
                    Console.WriteLine("Error. Enter a valid name.");
            }
            Console.WriteLine();
        }
        public void Display()
        {
            int charCnt = 70;

            for (int i = 0; i < charCnt; i++) Console.Write('-');
            Console.WriteLine("\nStudents information :\n");

            Console.WriteLine($"Last name\t: {LastName}");
            Console.WriteLine($"First name\t: {FirstName}");
            Console.WriteLine($"Birthdate\t: {Birthdate}\n");

            Console.WriteLine("Scores:");

            /*
            foreach (KeyValuePair<int, string> grade in Grades)
            {
                Console.WriteLine($"Subject : ");
                Console.WriteLine($"\tScore : ");
            }
            */

            for (int i = 0; i < charCnt; i++) Console.Write('-');
        }

    }
}
