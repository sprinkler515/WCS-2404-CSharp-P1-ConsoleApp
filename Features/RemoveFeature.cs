using P1_AppConsole.Models;

namespace P1_AppConsole.Features
{
    public class RemoveFeature
    {
        public void RemoveSubject(Campus campus)
        {
            // Search subject by ID
            int id = campus.Feature.SearchFeature.SearchByID(campus.Subjects);
            if (!campus.Subjects.Remove(id))
                Console.WriteLine($"Error! Subject #{id}'s not found.");
        }
    }
}
