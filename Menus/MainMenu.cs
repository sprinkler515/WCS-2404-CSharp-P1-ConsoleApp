namespace P1_AppConsole.Menus
{
    public class MainMenu : Menu
    {
        public MainMenu()
        {
            Options.Add("1. Students");
            Options.Add("2. Subjects");
            Options.Add("3. Exit");
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
                        StudentsMenu student = new();
                        student.Selection(campus);
                        break;
                    case 2:
                        SubjectsMenu subject = new();
                        subject.Selection(campus);
                        break;
                    case 3:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine(
                            "Error! Please select a valid option.\n");
                        break;
                }
            }
        }
    }
}
