using ExpertSystem.Forms;
using ExpertSystemShellDomain;
using ExpertSystemShellDomain.Entities;

namespace ExpertSystem;

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
    
    public void ShowExplanation(WorkingMemory workingMemory)
    {
        using var explanationForm = new ExplanationForm(workingMemory);
        explanationForm.ShowDialog();
    }
}