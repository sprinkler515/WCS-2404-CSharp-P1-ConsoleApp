using P1_AppConsole.Models;
using P1_AppConsole.Features;
using P1_AppConsole.Interfaces;
using Newtonsoft.Json;

namespace P1_AppConsole.Menus
{
    public class SelectionService : ILog
    {
        private void Select(Menu menu)
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int option))
                menu.Option = option;
            Console.WriteLine();
        }

        public void Selection(CampusManager manager, Campus campus)
        {
            DisplayService display = manager.DisplayService;
            bool exit = manager.Exit;
            string intro = $"{DateTime.Now} - Welcome\n";

            while (!exit)
            {
                display.Display(manager, intro);
                Select(manager);
                switch (manager.Option)
                {
                    case 1:
                        Selection(manager.StudentsManager, campus);
                        break;
                    case 2:
                        Selection(manager.SubjectsManager, campus);
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        display.OptionError();
                        break;
                }
            }
        }

        public void Selection(StudentsManager manager, Campus campus)
        {
            Management m = campus.Management;
            DisplayService display = manager.DisplayService;

            bool exit = manager.Exit;
            string intro = "Students :\n";

            while (!exit)
            {
                exit = false;
                display.Display(manager, intro);
                Select(manager);
                switch (manager.Option)
                {
                    case 1:
                        SaveLog("View all students");
                        m.DisplayFeature.Display(campus.Students);
                        display.Control();
                        break;
                    case 2:
                        m.AddFeature.NewStudent(campus);
                        display.Control();
                        break;
                    case 3:
                        m.DisplayFeature.Check(campus);
                        display.Control();
                        break;
                    case 4:
                        m.AddFeature.AddStudentGrade(campus);
                        display.Control();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        display.OptionError();
                        break;
                }
            }
        }

        public void Selection(SubjectsManager manager, Campus campus)
        {
            Management m = campus.Management;
            DisplayService display = manager.DisplayService;
            bool exit = manager.Exit;
            string intro = "Subjects :\n";

            while (!exit)
            {
                exit = false;
                display.Display(manager, intro);
                Select(manager);
                switch (manager.Option)
                {
                    case 1:
                        SaveLog("View all subjects");
                        m.DisplayFeature.Display(campus.Subjects);
                        display.Control();
                        break;
                    case 2:
                        m.AddFeature.NewSubject(campus);
                        display.Control();
                        break;
                    case 3:
                        m.RemoveFeature.RemoveSubject(campus);
                        display.Control();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        display.OptionError();
                        break;
                }
            }
        }

        public void SaveLog(string entry)
        {
            string log = $"{DateTime.Now} - {entry}\n";
            File.AppendAllText("campus.txt", log);
        }
    }
}
