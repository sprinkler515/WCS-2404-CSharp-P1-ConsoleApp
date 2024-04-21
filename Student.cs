namespace P1_AppConsole
{
    public class Student
    {
        private int _id;

        /* In progress:
         * private string _firstName;
         * private string _lastName;
         * private double _age;
         * private string _birthday;
         * private List<double> _grades;
         * private double _avgScore;
        */

        public void CreateNewStudent()
        {
            _id = SetId();
        }

        private int SetId()
        {
            var rand = new Random();
            return rand.Next(1000, 9999);
        }

        public void DisplayStudentMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. List students");
            Console.WriteLine("2. Create student");
            Console.WriteLine("3. Consult specific student");
            Console.WriteLine("4. Add grade to a specific student");
            Console.WriteLine("5. Back to menu");
        }
    }
}
