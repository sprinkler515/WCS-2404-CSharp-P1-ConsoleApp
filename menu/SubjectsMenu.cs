namespace P1_AppConsole.menu
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
                        Exit = true;
                        break;
                }
            }
        }
    }
}
