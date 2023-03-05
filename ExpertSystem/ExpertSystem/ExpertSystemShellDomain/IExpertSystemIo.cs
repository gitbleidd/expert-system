using ExpertSystem.KnowledgeBaseDomain;

namespace ExpertSystem.ExpertSystemShellDomain;

public interface IExpertSystemIo
{
    void ShowMessage(string text, string caption);
    DomainValue CreateVariableRequest();
}