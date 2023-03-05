using ExpertSystem.KnowledgeBaseDomain;

namespace ExpertSystem.ExpertSystemShellDomain;

public class FormsIo : IExpertSystemIo
{

    public void ShowMessage(string text, string caption)
    {
        MessageBox.Show(text, caption);
    }

    public DomainValue CreateVariableRequest()
    {
        throw new NotImplementedException();
    }

    public KnowledgeBase? ReadKnowledgeBase(string path)
    {
        throw new NotImplementedException();
    }

    public bool SaveKnowledgeBase(string path)
    {
        throw new NotImplementedException();
    }
}