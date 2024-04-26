namespace P1_AppConsole
{
    public class Subject : Campus
    {
        private int _id { get; set; }
        public string Name { get; set; }
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

        public Subject(string name) : base(name)
        {
            Random rand = new();
            Name = name;
            _id = rand.Next(100, 1000);
        }
    }
}
