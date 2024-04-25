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
                        campus.Display(campus.Subjects);
                        break;
                    case 2:
                        Subject subject = new(Tools.NameEntry());
                        campus.Subjects.Add(subject.ID, subject.Name);
                        break;
                    case 3:
                        Tools.IDRemoval(campus.Subjects);
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
