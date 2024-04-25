namespace P1_AppConsole.Menus
{
    public class StudentsMenu : Menu
    {
        public StudentsMenu()
        {
            Options.Add("1. List all students");
            Options.Add("2. Add new student");
            Options.Add("3. Check student");
            Options.Add("4. Add grade to student");
            Options.Add("5. Back to menu");
        }

        public override void Selection(Campus campus)
        {
            while (!Exit)
            {
                Display();
                Select();
                switch (Option)
                {
                    case 1:
                        campus.Display(campus.Students);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
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
    }
}
