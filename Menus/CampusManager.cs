using P1_AppConsole.Models;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace P1_AppConsole.Menus
{
    public class CampusManager : Menu
    {
        public Campus Campus { get; set; }
        public StudentsManager StudentsManager { get; set; }
        public SubjectsManager SubjectsManager { get; set; }

        public CampusManager()
        {

            if (File.Exists("campus.json"))
            {
                string json = File.ReadAllText("campus.json");
                Campus = JsonConvert.DeserializeObject<Campus>(json) ?? new();
            }
            else Campus = new();
            StudentsManager = new();
            SubjectsManager = new();

            Options.Add("1. Students");
            Options.Add("2. Subjects");
            Options.Add("3. Exit");
        }

        public void StartProgram()
        {
            SelectionService.Selection(this, Campus);
        }
    }
}
