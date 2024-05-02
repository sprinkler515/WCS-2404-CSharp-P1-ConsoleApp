using P1_AppConsole.Models;
using P1_AppConsole.Interfaces;
using System.Globalization;

namespace P1_AppConsole.Features
{
    public class AddFeature : IControl
    {
        public void NewStudent(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            bool confirm = false;

            while (!confirm)
            {
                Student student = new();

                confirm = false;
                student.SetID(campus);

                display.Header();
                Console.WriteLine("New student :");

                // Set firstname
                Console.Write("\nEnter firstname: ");
                student.FirstName = student.SetName();
                if (student.FirstName == null)
                {
                    if (Continue()) continue;
                    else
                    {
                        display.Footer();
                        return;
                    }
                }
                Console.Write("\nEnter lastname: ");
                student.LastName = student.SetName();
                if (student.LastName == null)
                {
                    if (Continue()) continue;
                    else
                    {
                        display.Footer();
                        return;
                    }
                }
                //  Set birthdate
                Console.Write("\nEnter birthdate (MM-DD-YYYY): ");
                student.Birthdate = student.SetBirthdate();
                if (student.Birthdate == null)
                {
                    if (Continue()) continue;
                    else
                    {
                        display.Footer();
                        return;
                    }
                }
                // Display new student
                display.Header();
                Console.WriteLine("Student information: \n");
                display.Display(student);

                // Control
                if (Save(campus))
                    campus.Students.Add(student.ID, student);
                Console.Write("Register another student (\"Yes\" to confirm) : ");
                if (Continue()) continue;
                confirm = true;
            }
            display.Footer();
        }

        public void NewSubject(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            Subject subject = new();

            subject.SetID(campus);
            display.Header();
            Console.WriteLine("New Subject\n");
            Console.Write("Enter subject's name: ");
            subject.Name = subject.SetName();
            campus.Subjects.Add(subject.ID, subject);
            display.Footer();
        }

        public void AddStudentGrade(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            SearchFeature search = campus.Management.SearchFeature;
            Grade grade = new();
            int studentID, subjectID;

            display.Header();
            display.Display(campus.Students);
            studentID = search.SearchID(campus.Students);
            if (studentID == default)
            {
                Console.WriteLine("\nError! Student doesn't exist.");
                display.Footer();
                return;
            }
            display.Header();
            display.Display(campus.Subjects);
            subjectID = search.SearchID(campus.Subjects);
            if (subjectID == default)
            {
                Console.WriteLine("\nError! Subject doesn't exist.");
                display.Footer();
                return;
            }
            grade.SubjectName = campus.Subjects[subjectID];
            grade.SetScore();
            grade.SetEvaluation();
            campus.Students[studentID].Grades.Add(grade);
            campus.Students[studentID].CalcAverage();
            display.Footer();
        }

        public bool Save(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            string input;

            display.Footer();
            Console.Write("Save (Yes to confirm) : ");
            input = Console.ReadLine() ?? "";
            input = input.ToLower();
            if (input == "y" || input == "ye" || input == "yes")
            {
                Console.WriteLine("\nSave Successful.");
                display.Footer();
                return true;
            }
            else
                Console.WriteLine("\nNot registered.");
            display.Footer();

            return false;
        }

        public bool Continue()
        {
            string input;

            input = Console.ReadLine() ?? "";
            input = input.ToLower();
            if (input == "y" || input == "ye" || input == "yes")
                return true;
            return false;
        }
    }
}
