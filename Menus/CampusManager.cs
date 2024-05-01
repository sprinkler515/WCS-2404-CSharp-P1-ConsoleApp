using P1_AppConsole.Models;

namespace P1_AppConsole.Menus
{
    public class CampusManager : Menu, IMenu
    {
        public Campus Campus { get; set; }
        public StudentsManager StudentsManager { get; set; }
        public SubjectsManager SubjectsManager { get; set; }

        public CampusManager()
        {
            Campus = new();
            StudentsManager = new();
            SubjectsManager = new();

            Options.Add("1. Students");
            Options.Add("2. Subjects");
            Options.Add("3. Exit");
        }

        public void StartProgram()
        {
            Selection();
        }

        public void Selection()
        {
            while (!Exit)
            {
                Console.Clear();
                Display();
                Select();
                switch (Option)
                {
                    case 1:
                        StudentsManager.Selection(Campus);
                        break;
                    case 2:
                        SubjectsManager.Selection(Campus);
                        break;
                    case 3:
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
            Console.WriteLine($"\n{DateTime.Now} - Welcome\n");

            foreach (string option in Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }
    }
}
