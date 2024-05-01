using P1_AppConsole.Models;

namespace P1_AppConsole
{
    public class Grade
    {
        private double _score;
        private string? _eval;
        public Subject? SubjectName { get; set; }
        public double Score { get => _score; set => _score = value; }
        public string? Evaluation { get => _eval; set => _eval = value; }

        public void SetScore()
        {
            Console.Write("Add score (~/20): ");
            if (double.TryParse(Console.ReadLine(), out _score))
            {
                if (_score < 0 || _score > 20)
                    Console.WriteLine("Error! Enter a score between 0 and 20.");
            }
            else
                Console.WriteLine("Error! Enter a number.");
        }

        public void SetEvaluation()
        {
            Console.Write("Evaluation: ");
            _eval = Console.ReadLine();
        }
    }
}