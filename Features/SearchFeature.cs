using P1_AppConsole.Models;

namespace P1_AppConsole.Features
{
    public class SearchFeature
    {
        public int SearchByID(Dictionary<int, Student> students)
        {
            Console.Write("Enter student ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
                if (students.TryGetValue(id, out _))
                    return id;
            return default;
        }

        public int SearchByID(Dictionary<int, Subject> subjects)
        {
            Console.Write("Enter subject ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
                if (subjects.TryGetValue(id, out _))
                    return id;
            return default;
        }
    }
}
