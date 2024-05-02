using P1_AppConsole.Models;

namespace P1_AppConsole.Features
{
    public class RemoveFeature
    {
        public void RemoveSubject(Campus campus)
        {
            SearchFeature search = campus.Management.SearchFeature;
            int id = search.SearchID(campus.Subjects);

            if (!campus.Subjects.Remove(id))
                Console.WriteLine($"Error! Subject #{id}'s not found.");
        }
    }
}
