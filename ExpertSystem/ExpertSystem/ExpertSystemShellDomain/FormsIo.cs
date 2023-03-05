using ExpertSystem.KnowledgeBaseDomain;

namespace ExpertSystem.ExpertSystemShellDomain;

public class FormsIo : IExpertSystemIo
{
    public void InitIo()
    {
        ConsultationForm.ClearConsultationText();
    }

    public void ShowMessage(string text, string caption)
    {
        MessageBox.Show(text, caption);
    }

    public DomainValue? CreateVariableRequest(Variable variable)
    {
        using var consultForm = new ConsultationForm(variable);
        consultForm.ShowDialog();
        return consultForm.SelectedValue;
    }
}