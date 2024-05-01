using P1_AppConsole.Models;

namespace P1_AppConsole.Menus
{
    public class StudentsManager : Menu
    {
        public StudentsManager()
        {
            Options.Add("1. List all students");
            Options.Add("2. Add new student");
            Options.Add("3. Check student");
            Options.Add("4. Add grade to student");
            Options.Add("5. Back to menu");
        }

        public void Selection(Campus campus)
        {
            while (!Exit)
            {
                Console.Clear();
                Display();
                Select();
                switch (Option)
                {
                    case 1:
                        campus.DisplayStudents();
                        DisplayControl();
                        break;
                    case 2:
                        campus.CreateStudent();
                        DisplayControl();
                        break;
                    case 3:
                        campus.ConsultStudent();
                        DisplayControl();
                        break;
                    case 4:
                        campus.AddStudentGrade();
                        DisplayControl();
                        break;
                    case 5:
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
