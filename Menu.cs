namespace P1_AppConsole
{
    public class Menu : Campus
    {
        private int _option;

        public int Option
        {
            get => _option;
        }

        public bool Exit
        {
            get => _option == 3;
        }

        public void Select()
        {
            string[] menu = [
                "1. Students",
                "2. Subjects",
                "3. Exit"
                ];

            DisplayMenu(menu);
            _option = SelectMenu(menu);
         }
    }
}
