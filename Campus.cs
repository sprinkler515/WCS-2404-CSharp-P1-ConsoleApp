﻿using System.ComponentModel.Design;

namespace P1_AppConsole
{
    public class Campus
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

            DisplayMenu(menu);
            _option = SelectMenu(menu);
        }

        public void DisplayMenu(string[] menu)
        {
            foreach (string option in menu)
                Console.WriteLine(option);
            Console.WriteLine();
        }

        public int SelectMenu(string[] menu)
        {
            string choice;
            bool isNumber;

            Console.Write("Enter your choice: ");
            choice = Console.ReadLine() ?? "";
            choice = choice.ToLower();
            isNumber = int.TryParse(choice, out int option);

            if (!isNumber)
                for (int i = 1; i <= menu.Length; i++)
                {
                    string s = menu[i - 1].ToLower();
                    if (s.Contains(choice))
                        option = i;
                }
            if (option <= 0 || option > menu.Length)
                Console.WriteLine("Invalid input");

            return option;
        }
    }
}
