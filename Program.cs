using P1_AppConsole.Menus;

namespace P1_AppConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Campus campus = new();
            MainMenu menu = new();

            menu.Selection(campus);
        }
    }
}
