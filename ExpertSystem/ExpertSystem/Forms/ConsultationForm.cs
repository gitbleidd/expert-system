using ExpertSystemShellDomain.Entities;

namespace ExpertSystem.Forms
{
    public partial class ConsultationForm : Form
    {
        public DomainValue? SelectedValue { get; private set; }
        public Variable? SelectedVariable { get; private set; }
        
        private static readonly List<string> _questionsAnswers = new();
        private readonly bool _isTargetVariableForm = false;
        public ConsultationForm(List<Variable> variables)
        {
            InitializeComponent();
            _isTargetVariableForm = true;
            
            foreach (var variable in variables)
            {
                consultationComboBox.Items.Add(variable);
            }

            consultationComboBox.SelectedIndex = 0;
        }

        public ConsultationForm(Variable variable)
        {
            InitializeComponent();

            _questionsAnswers.Add($"ЭС: {variable.QuestionText}");
            foreach (var item in _questionsAnswers)
            {
                consultationListBox.Items.Add(item);
            }

            foreach (var domainValue in variable.Domain.Values)
            {
                consultationComboBox.Items.Add(domainValue);
            }
            
            consultationComboBox.SelectedIndex = 0;
        }

        public static void ClearConsultationText() => _questionsAnswers.Clear();

        private void okConsultButton_Click(object sender, EventArgs e)
        {
            if (consultationComboBox.SelectedItem is null)
                return;
            
            if (_isTargetVariableForm)
            {
                SelectedVariable = consultationComboBox.SelectedItem as Variable;
            }
            else
            {
                SelectedValue = consultationComboBox.SelectedItem as DomainValue;
                _questionsAnswers.Add($"Вы: {SelectedValue.Value}");
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
