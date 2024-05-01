using P1_AppConsole.Models;
using P1_AppConsole.Features;

namespace P1_AppConsole.Menus
{
    public class MenuSelection
    {
        private Feature Feature { get; set; }
        private DisplayService DisplayService { get; set; }

        public MenuSelection()
        {
            Feature = new();
            DisplayService = new();
        }

        public void Selection(CampusManager campusManager, Campus campus)
        {
            while (!campusManager.Exit)
            {
                Console.Clear();
                campusManager.DisplayService.Display(campusManager);
                Select(campusManager);
                switch (campusManager.Option)
                {
                    case 1:
                        Selection(campusManager.StudentsManager, campus);
                        break;
                    case 2:
                        Selection(campusManager.SubjectsManager, campus);
                        break;
                    case 3:
                        campusManager.Exit = true;
                        break;
                    default:
                        campusManager.DisplayService.OptionError();
                        break;
                }
            }
        }

        public void Selection(StudentsManager studentsManager, Campus campus)
        {
            Feature = campus.Feature;
            DisplayService = studentsManager.DisplayService;

            while (!studentsManager.Exit)
            {
                Console.Clear();
                DisplayService.Display(studentsManager);
                Select(studentsManager);
                switch (studentsManager.Option)
                {
                    case 1:
                        Feature.DisplayFeature.Display(campus.Students);
                        DisplayService.DisplayControl();
                        break;
                    case 2:
                        Feature.AddFeature.CreateStudent(campus);
                        DisplayService.DisplayControl();
                        break;
                    case 3:
                        Feature.DisplayFeature.ConsultStudent(campus);
                        DisplayService.DisplayControl();
                        break;
                    case 4:
                        Feature.AddFeature.AddGrade(campus);
                        DisplayService.DisplayControl();
                        break;
                    case 5:
                        studentsManager.Exit = true;
                        break;
                    default:
                        studentsManager.DisplayService.OptionError();
                        break;
                }
            }
        }

        public void Selection(SubjectsManager subjectsManager, Campus campus)
        {
            Feature = campus.Feature;
            DisplayService = subjectsManager.DisplayService;

            while (!subjectsManager.Exit)
            {
                DisplayService.Display(subjectsManager);
                Select(subjectsManager);
                switch (subjectsManager.Option)
                {
                    case 1:
                        Feature.DisplayFeature.Display(campus.Subjects);
                        DisplayService.DisplayControl();
                        break;
                    case 2:
                        Feature.AddFeature.CreateSubject(campus);
                        DisplayService.DisplayControl();
                        break;
                    case 3:
                        Feature.RemoveFeature.RemoveSubject(campus);
                        DisplayService.DisplayControl();
                        break;
                    case 4:
                        subjectsManager.Exit = true;
                        break;
                    default:
                        DisplayService.OptionError();
                        break;
                }
            }
        }

        private static void Select(Menu menu)
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int option))
                menu.Option = option;
            Console.WriteLine();
        }
    }
}
