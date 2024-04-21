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
    }
}
