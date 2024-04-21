namespace P1_AppConsole
{
    public class Student : Campus
    {
        private int _option;
        public new int Option
        {
            get => _option;
        }
        public new bool Exit
        {
            get => _option == 5;
        }

        private int _id;

        /* In progress:
         * private string _firstName;
         * private string _lastName;
         * private double _age;
         * private string _birthday;
         * private List<double> _grades;
         * private double _avgScore;
        */

        public void CreateStudent()
        {
            _id = SetId();
        }

        private int SetId()
        {
            var rand = new Random();
            return rand.Next(1000, 9999);
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

            DisplayMenu(menu);
            _option = SelectMenu(menu);
        }
    }
}
