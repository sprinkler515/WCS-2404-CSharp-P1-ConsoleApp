using P1_AppConsole.Models;

namespace P1_AppConsole.Features
{
    public class DisplayFeature
    {
        public void Display(Dictionary<int, Student> students)
        {
            foreach (KeyValuePair<int, Student> student in students)
                Console.WriteLine($"#{student.Key}\t: {student.Value.LastName} {student.Value.FirstName}");
            Console.WriteLine();
        }

        public void Display(Dictionary<int, Subject> subjects)
        {
            foreach (KeyValuePair<int, Subject> subject in subjects)
                Console.WriteLine($"#{subject.Key}\t: {subject.Value.Name}");
            Console.WriteLine();
        }

        public void Display(Student student)
        {
            Console.WriteLine("\nStudents information :\n");

            Console.WriteLine($"Last name\t: {student.LastName}");
            Console.WriteLine($"First name\t: {student.FirstName}");
            Console.WriteLine($"Birthdate\t: {student.Birthdate}\n");

            Console.WriteLine("Scores:");

            foreach (Grade grade in student.Grades)
            {
                Console.WriteLine($"\tSubject : {grade.SubjectName}");
                Console.WriteLine($"\t\tScore : {grade.Score}");
                Console.WriteLine($"\t\tEvaluation : {grade.Evaluation}");
            }

            Console.WriteLine($"\tAverage : ");
        }

        public void ConsultStudent(Campus campus)
        {
            // - Check Student
            int id = campus.Feature.SearchFeature.SearchByID(campus.Students);
            // - Display student
            Display(campus.Students[id]);
        }
    }
}
