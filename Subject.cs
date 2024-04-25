namespace P1_AppConsole
{
    public class Subject : Campus
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        public Subject(string name)
        {
            Random rand = new();
            Name = name;

            while (!Subjects.ContainsKey(ID))
            {
                ID = rand.Next(100, 1000);
                Subjects.Add(ID, Name);
            }
        }
    }
}
