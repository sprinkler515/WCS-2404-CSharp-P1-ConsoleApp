namespace P1_AppConsole.Menus
{
    public class StudentsManager : CampusManager, IDisplay
    {
        public StudentsManager()
        {
            Options.Clear();
            Options.Add("1. List all students");
            Options.Add("2. Add new student");
            Options.Add("3. Check student");
            Options.Add("4. Add grade to student");
            Options.Add("5. Back to menu");
        }

        protected override void Selection()
        {
            while (!Exit)
            {
                Display();
                Select();
                switch (Option)
                {
                    case 1:
                        Campus.DisplayStudents();
                        break;
                    case 2:
                        Campus.CreateStudent();
                        break;
                    case 3:
                        Campus.ConsultStudent();
                        break;
                    case 4:
                        Campus.AddGrade();
                        break;
                    case 5:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        public new void Display()
        {
            DrawLine();
            Console.WriteLine("\nSubjects :\n");

            foreach (string option in Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }
    }
}
