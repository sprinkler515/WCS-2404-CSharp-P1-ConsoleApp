namespace P1_AppConsole.menu
{
    public partial class StudentsMenu : Menu
    {
        StudentsMenu()
        {
            Options.Add("1. List all students");
            Options.Add("2. Add new student");
            Options.Add("3. Check student");
            Options.Add("4. Add grade to student");
            Options.Add("5. Back to menu");
        }

        public override void Selection()
        {
            while (!Exit)
            {
                switch (Option)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
