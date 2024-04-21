namespace P1_AppConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProgramConsole();
        }

        static void ProgramConsole()
        {
            Campus campus = new();

            while (!campus.Exit)
            {
                campus.Select();

                if (campus.Option == 1)
                {
                    Console.WriteLine("Students");
                }
                else if (campus.Option == 2)
                {
                    Console.WriteLine("Subjects");
                }
            }
        }
    }
}
