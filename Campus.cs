using System.ComponentModel.Design;

namespace P1_AppConsole
{
    public class Campus
    {
        public Dictionary<int, Student> Students { get; set; } = [];
        protected Dictionary<int, Subject> Subjects = [];
    }
}
