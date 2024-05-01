namespace P1_AppConsole.Menus
{
    public class DisplayService
    {
        public void Display(CampusManager campusManager)
        {
            DrawLine();
            Console.WriteLine($"\n{DateTime.Now} - Welcome\n");

            foreach (string option in campusManager.Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }

        public void Display(StudentsManager studentManager)
        {
            DrawLine();
            Console.WriteLine("\nSubjects :\n");

            foreach (string option in studentManager.Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }

        public void Display(SubjectsManager subjectManager)
        {
            DrawLine();
            Console.WriteLine("\nSubjects :\n");

            foreach (string option in subjectManager.Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }

        public void OptionError()
        {
            Console.WriteLine("Error! Please select a valid option.\n");
            DisplayControl();
        }

        public void DisplayControl()
        {
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }

        public void DrawLine()
        {
            int len = 70;
            for (int i = 0; i < len; i++)
                Console.Write("-");
        }
    }
}
