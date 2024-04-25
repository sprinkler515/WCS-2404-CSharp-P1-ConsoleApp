namespace P1_AppConsole.Menus
{
    public class SubjectsMenu : Menu
    {
        public SubjectsMenu()
        {
            Options.Add("1. List subjects");
            Options.Add("2. Add new subject");
            Options.Add("3. Delete subject");
            Options.Add("4. Back to menu");
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
                        campus.DisplaySubjects();
                        break;
                    case 2:
                        string name; 
                        Console.WriteLine("Subject to add: ");
                        name = Console.ReadLine() ?? "";
                        name = Tools.NameCheck(name);
                        Subject subject = new(name);
                        campus.Subjects.Add(subject);
                        break;
                    case 3:
                        break;
                    case 4:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Error. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
