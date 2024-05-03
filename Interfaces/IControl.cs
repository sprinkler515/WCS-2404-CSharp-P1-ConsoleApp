using P1_AppConsole.Models;

namespace P1_AppConsole.Interfaces
{
    public interface IControl
    {
        bool Continue();
        bool Save(Campus campus);
        void SaveJson(Campus campus);
        void SaveLog(string entry);

    }
}
