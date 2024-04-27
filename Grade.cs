namespace P1_AppConsole
{
    public class Grade : Student
    {
        private Subject Name { get; set; }
        private double Score { get; set; }
        private string Eval { get; set; }

        public Grade(Subject name, double score, string eval)
        {
            Name = name;
            Score = score;
            Eval = eval;
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
