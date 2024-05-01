using P1_AppConsole.Models;

namespace P1_AppConsole.Menus
{
    public class CampusManager : Menu
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
            MenuSelection.Selection(this, Campus);
        }
    }
}
