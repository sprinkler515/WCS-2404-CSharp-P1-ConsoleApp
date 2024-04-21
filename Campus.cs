using System.ComponentModel.Design;

namespace P1_AppConsole
{
    public partial class Campus
    {
        protected Dictionary<int, Student> Students = [];
        protected Dictionary<int, Subject> Subjects = [];

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

            Menu.DisplayMenu(menu);
            _option = Menu.SelectMenu(menu);
        }
    }
}
