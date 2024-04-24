namespace P1_AppConsole
{
    public class Student : Campus
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private double _age;
        private string _birthdate;
        private Dictionary<double, string> _grades;
        private double _avgScore;

        public Student()
        {
            _id = SetId();
            _firstName = SetFirstName();
            _lastName = SetLastName();
            _birthdate = SetBirthDate();
            _grades = [];
        }

        private int SetId()
        {
            var rand = new Random();
            return rand.Next(1000, 9999);
        }
        private string SetFirstName()
        {
            Console.Write("Enter first name: ");
            // Check valid input

            return Console.ReadLine() ?? "";
        }
        private string SetLastName()
        {
            Console.Write("Enter last name: ");
            // Check valid input

            return Console.ReadLine() ?? "";
        }
        private string SetBirthDate()
        {
            string birthdate;

            Console.Write("Enter birthdate (format: MMDDYYYY)");
            birthdate = Console.ReadLine() ?? "Invalid input";
            // Check valid input
            // Format input

            return birthdate;
        }
    }
}
