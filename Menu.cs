namespace P1_AppConsole
{
    public class Menu
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

        public void Display()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Students");
            Console.WriteLine("2. Subjects");
            Console.WriteLine("3. Exit\n");
        }

        public void Select()
        {
            string option;
            bool isNumber;

            Console.Write("Enter your choice: ");
            option = Console.ReadLine() ?? "";
            option = option.ToLower();
            isNumber = int.TryParse(option, out _option);

            if (!isNumber)
                if ("students".Contains(option))
                    _option = 1;
                else if ("subjects".Contains(option))
                    _option = 2;
                else if ("exit".Contains(option))
                    _option = 3;
            if (_option <= 0 || _option > 3)
                Console.WriteLine("Invalid input");
        }
    }
}
