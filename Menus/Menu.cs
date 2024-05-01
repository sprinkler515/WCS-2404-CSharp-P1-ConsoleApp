namespace P1_AppConsole.Menus
{
    public abstract class Menu
    {
        public DisplayService DisplayService { get; set; }
        public MenuSelection MenuSelection { get; set; }
        public List<string> Options { get; set; }
        public int Option { get; set; }
        public bool Exit { get; set; }

        protected Menu()
        {
            DisplayService = new();
            MenuSelection = new();
            Options = [];
        }
    }
}
