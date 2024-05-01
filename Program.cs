using P1_AppConsole.Menus;
using System.Globalization;

namespace P1_AppConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            CampusManager campusManager = new();

            SetCulture("en-US");
            campusManager.StartProgram();
        }

        static void SetCulture(string name)
        {
            CultureInfo culture = new(name, false);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}
