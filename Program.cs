namespace P1_AppConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProgramConsole();
        }

        static void ProgramConsole()
        {
            Campus campus = new();
            bool exit = false;
            Console.WriteLine(DateTime.Now);

            while (!exit)
            {
                int option = Menu.MainMenu();

                switch (option)
                {
                    case 1:
                        StudentMenu(campus.Students);
                        break;
                    case 2:
                        Console.WriteLine("Subjects");
                        break;
                    case 3:
                        exit = true;
                        break;
                }
            }
        }

        public static void StudentMenu(Dictionary<int, Student> students)
        {
            bool exit = false;

            while (!exit)
            {
                int option = Menu.StudentMenu();

                switch (option)
                {
                    case 1:
                    case 2:
                        break;
                    case 3:
                    case 4:
                    case 5:
                        exit = true;
                        break;
                }
                Console.WriteLine();
            }
        }

        public static void CreateStudent()
        {
            Student student = new();
        }
    }
}
