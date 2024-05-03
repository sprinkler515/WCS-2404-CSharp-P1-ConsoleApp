using System.ComponentModel.Design;

namespace P1_AppConsole.Menus
{
    public abstract class Menu
    {
        public DisplayService DisplayService { get; private set; }
        protected SelectionService SelectionService { get; private set; }
        public List<string> Options { get; private set; }
        public int Option { get; set; }
        public bool Exit { get; private set; }

        public Menu()
        {
            DisplayService = new();
            SelectionService = new();
            Options = [];
        }
    }
}
