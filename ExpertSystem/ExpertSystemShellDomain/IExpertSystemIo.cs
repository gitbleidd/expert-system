using ExpertSystemShellDomain.Entities;

namespace ExpertSystemShellDomain;

public interface IExpertSystemIo
{
    void InitIo();
    void ShowMessage(string text, string caption);
    DomainValue? CreateVariableRequest(Variable variable);
}