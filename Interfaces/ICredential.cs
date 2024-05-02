using P1_AppConsole.Models;

namespace P1_AppConsole.Interfaces
{
    public interface ICredential
    {
        void SetID(Campus campus);
        string? SetName();
    }
}
