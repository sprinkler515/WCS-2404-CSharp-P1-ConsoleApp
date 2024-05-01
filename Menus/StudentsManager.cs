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
    }
}
