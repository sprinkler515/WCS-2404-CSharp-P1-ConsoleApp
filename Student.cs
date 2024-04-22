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
        private int _option;
        public new int Option
        {
            get => _option;
        }
        public new bool Exit
        {
            get => _option == 5;
        }

        public Student()
        {
            _id = SetId();
            _firstName = SetFirstName();
            _lastName = SetLastName();
            _birthdate = SetBirthDate();
            _grades = [];
        }

        public new void Select()
        {
            string[] menu = [
                "1. List students",
                "2. Create student",
                "3. Consult specific student",
                "4. Add grade to a specific student",
                "5. Back to menu"
                ];

            Menu.DisplayMenu(menu);
            _option = Menu.SelectMenu(menu);
        }

        private int SetId()
        {
            var rand = new Random();
            return rand.Next(1000, 9999);
        }
        private string SetFirstName()
        {
            Console.Write("Enter first name: ");
            return Console.ReadLine() ?? "";
        }
        private string SetLastName()
        {
            Console.Write("Enter last name: ");
            return Console.ReadLine() ?? "";
        }
        private string SetBirthDate()
        {
            string birthdate = "";

            Console.Write("Enter birthdate (format: MMDDYYYY)");

            return birthdate;
        }
    }
}
