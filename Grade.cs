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
        }
    }
}
