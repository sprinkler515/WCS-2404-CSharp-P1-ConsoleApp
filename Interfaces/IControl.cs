using P1_AppConsole.Models;

namespace P1_AppConsole.Interfaces
{
    public interface IControl
    {
        bool Save(Campus campus);
        bool Continue();
    }
}
