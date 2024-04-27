namespace P1_AppConsole
{
    public class Grade : Student
    {
        private Subject Name { get; set; }
        private double Score { get; set; }
        private string? Eval { get; set; }

        public Grade()
        {
            Name = new();
            DisplaySubjects();
        }

        private void SelectSubject()
        {
            Console.WriteLine("Select a subject:");


        }

        /*
        private void SelectSubject(List<string> list)
        {
            string select;
            bool valid;

            Console.Write("Enter your choice: ");
            select = Console.ReadLine() ?? "Invalid input";
            select = select.ToLower();
            valid = int.TryParse(select, out int option);
            = option;

            if (!valid)
                for (int i = 1; i <= Options.Count; i++)
                {
                    string s = Options[i - 1].ToLower();
                    if (s.Contains(select) && select.Length >= 3)
                        Option = i;
                }
            Console.WriteLine();
        }
        */

        private new List<string> DisplaySubjects()
        {
            List<string> subjects = [];

            for (int i = 0; i < Subjects.Count; i++)
            {
                string s = Subjects[i].Name ?? "";
                if (!String.IsNullOrEmpty(s))
                {
                    Console.WriteLine($"{i + 1}. {s}");
                    subjects.Add(s);
                }
            }
            return subjects;
        }

        /*
        private void AddGrade()
        {
            Dictionary<double, string> grade = [];
            string? subject;
            bool valid;

            Console.WriteLine("Enter subject: ");
            subject = Console.ReadLine();
            foreach (Subject el in Subjects)
            {
                if (subject == el.Name)
                    break;
                if (Subjects.Last() == el)
                    Console.WriteLine("Error! Subject doesn't exist.");
            }

            Console.Write("Add new grade (score/20): ");
            valid = double.TryParse(Console.ReadLine(), out double score);

            if (!valid || score < 0 || score > 20)
                Console.WriteLine("Error! Enter a valid score (0-20)");
        }
        */

    }
}
