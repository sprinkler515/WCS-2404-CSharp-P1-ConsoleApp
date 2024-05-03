using P1_AppConsole.Interfaces;
using P1_AppConsole.Models;
using Newtonsoft.Json;

namespace P1_AppConsole.Features
{
    public class RemoveFeature : IControl
    {
        public void RemoveSubject(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            SearchFeature search = campus.Management.SearchFeature;
            int id;
            bool confirm = false;

            while (!confirm)
            {
                display.Display(campus.Subjects);
                id = search.SearchID(campus.Subjects);
                display.Footer();
                if (campus.Subjects.TryGetValue(id, out Subject? subject))
                {
                    Console.Write($"Delete subject : #{id} {subject.Name}\n");
                    if (Save(campus)) campus.Subjects.Remove(id);
                }
                else
                    Console.WriteLine($"Error! Subject's doesn't exist.");
                display.Footer();
                Console.Write("Delete another subject (Yes to confirm) : ");
                if (Continue()) continue;
                confirm = true;
            }
            display.Footer();
        }

        public bool Save(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            string input;

            display.Footer();
            Console.Write("Save (Yes to confirm) : ");
            input = Console.ReadLine() ?? "";
            input = input.ToLower();
            if (input == "y" || input == "ye" || input == "yes")
            {
                display.Footer();
                Console.WriteLine("Save Successful.");
                return true;
            }
            else
                Console.WriteLine("\nNot registered.");
            display.Footer();

            return false;
        }

        public bool Continue()
        {
            string input;

            input = Console.ReadLine() ?? "";
            input = input.ToLower();
            if (input == "y" || input == "ye" || input == "yes")
                return true;
            return false;
        }

        public void SaveJson(Campus campus)
        {
            string json = JsonConvert.SerializeObject(campus);
            File.WriteAllText("db.json", json);
        }

        public void SaveLog(string entry)
        {
            string log = $"{DateTime.Now} {entry}";
            File.AppendAllText("log.txt", log);
        }
    }
}
