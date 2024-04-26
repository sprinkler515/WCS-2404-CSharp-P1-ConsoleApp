namespace P1_AppConsole
{
    public class Subject : Campus
    {
        private int _id { get; set; }
        public string? Name { get; set; }
        public int ID
        {
            get
            {
                foreach (Subject subject in Subjects)
                {
                    while (_id == subject.ID)
                    {
                        Random rand = new();
                        _id = rand.Next(100, 1000);
                    }
                }
                return _id;
            }
            set { _id = value; }
        }

        public Subject()
        {
            Random rand = new();
            _id = rand.Next(100, 1000);
            SetName();
        }

        private void SetName()
        {
            Name = "";

            while (String.IsNullOrEmpty(Name) || Name.Length < 2)
            {
                Console.Write("Enter a subject name: ");
                Name = Console.ReadLine() ?? "";
                if (String.IsNullOrEmpty(Name) || Name.Length < 2)
                    Console.WriteLine("Error. Enter a valid name.");
            }
            Console.WriteLine();
        }

    }
}
