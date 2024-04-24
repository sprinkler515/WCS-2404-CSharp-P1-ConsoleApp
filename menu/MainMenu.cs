namespace P1_AppConsole.menu
{
    public class MainMenu : Menu
    {
        public MainMenu()
        {
            Options.Add("1. Students");
            Options.Add("2. Subjects");
            Options.Add("3. Exit");
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
