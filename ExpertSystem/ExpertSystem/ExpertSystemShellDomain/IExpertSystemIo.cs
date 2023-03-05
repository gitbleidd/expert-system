using ExpertSystem.KnowledgeBaseDomain;

namespace ExpertSystem.ExpertSystemShellDomain;

public interface IExpertSystemIo
{
    void InitIo();
    void ShowMessage(string text, string caption);
    DomainValue? CreateVariableRequest(Variable variable);
}