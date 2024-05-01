using P1_AppConsole.Models;

namespace P1_AppConsole.Menus
{
    public class SubjectsManager : Menu, IMenu
    {
        public SubjectsManager()
        {
            Options.Add("1. List subjects");
            Options.Add("2. Add new subject");
            Options.Add("3. Delete subject");
            Options.Add("4. Back to menu");
        }

        public void Selection(Campus campus)
        {
            while (!Exit)
            {
                Display();
                Select();
                switch (Option)
                {
                    case 1:
                        campus.DisplaySubjects();
                        DisplayControl();
                        break;
                    case 2:
                        campus.CreateSubject();
                        DisplayControl();
                        break;
                    case 3:
                        campus.RemoveSubject();
                        DisplayControl();
                        break;
                    case 4:
                        Exit = true;
                        break;
                    default:
                        OptionError();
                        break;
                }
            }
        }

        public void Display()
        {
            DrawLine();
            Console.WriteLine("\nSubjects :\n");

            foreach (string option in Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }
    }
}
