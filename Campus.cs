namespace P1_AppConsole
{
    public class Campus
    {
        public string Name { get; private set; }
        public Dictionary<int, Student> Students { get; set; }
        public Dictionary<int, string> Subjects { get; set; }

        public Campus(string name)
        {
            Name = name;
            Students = [];
            Subjects = [];
        }

        public void Display(Dictionary<int, Student> students)
        {
            foreach (KeyValuePair<int, Student> entry in students)
                Console.WriteLine($"#{entry.Key}\t: {entry.Value}");
            Console.WriteLine();

        }

        public void Display(Dictionary<int, string> subjects)
        {
            foreach (KeyValuePair<int, string> entry in subjects)
                Console.WriteLine($"#{entry.Key}\t: {entry.Value}");
            Console.WriteLine();
        }
    }
}
