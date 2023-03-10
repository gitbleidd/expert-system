using ExpertSystemShellDomain.Entities;

namespace ExpertSystem
{
    public partial class FactEditForm : Form
    {
        private KnowledgeBase KnowledgeBase { get; }
        private List<Fact> Facts { get; }
        private bool IsPremiseForm { get; }
        public Fact Fact { get; }

        public FactEditForm(KnowledgeBase knowledgeBase, List<Fact> facts, bool isPremiseForm)
        {
            InitializeComponent();
            this.Text = "Добавление факта";

            KnowledgeBase = knowledgeBase;
            Facts = facts;
            IsPremiseForm = isPremiseForm;
            Fact = new Fact(null, null);

            InitializeVariableCombobox();
        }

        public FactEditForm(KnowledgeBase knowledgeBase, List<Fact> facts, Fact fact, bool isPremiseForm)
        {
            InitializeComponent();
            this.Text = "Изменение факта";

            KnowledgeBase = knowledgeBase;
            Facts = facts;
            Fact = fact;
            IsPremiseForm = isPremiseForm;

            InitializeVariableCombobox();
        }

        private void createVariableButton_Click(object sender, EventArgs e)
        {
            using var variableEditForm = new VariableCreationForm(KnowledgeBase);
            var dialogResult = variableEditForm.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return;

            var variable = variableEditForm.Variable; // Get created variable from Form
            KnowledgeBase.Variables.Add(variable);
            
            // Посылка: запрашиваемые и выводимо-запрашиваемые
            if (IsPremiseForm && (variable.VariableType == VarType.Requested || variable.VariableType == VarType.InferredRequested))
            {
                variableComboBox.Items.Add(variable);
                variableComboBox.SelectedItem = variable;
            }
            
            // Заключение: выводимые и выводимо-запрашиваемые
            if (!IsPremiseForm && (variable.VariableType == VarType.Inferred || variable.VariableType == VarType.InferredRequested))
            {
                variableComboBox.Items.Add(variable);
                variableComboBox.SelectedItem = variable;
            }
        }

        private void variableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (variableComboBox.SelectedItem is not Variable variable)
                return;

            // Fill domain values combobox for selected variable
            domainValueComboBox.Items.Clear();
            foreach (var domainValue in variable.Domain.Values)
            {
                domainValueComboBox.Items.Add(domainValue);
            }

            // Select first element in combobox
            if (domainValueComboBox.Items.Count > 0)
            {
                domainValueComboBox.SelectedIndex = 0;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (variableComboBox.SelectedItem is not Variable variable)
            {
                MessageBox.Show("Выберите переменную!");
                return;
            }

            if (domainValueComboBox.SelectedItem is not DomainValue domainValue)
            {
                MessageBox.Show("Выберите значение!");
                return;
            }

            if (IsPremiseForm && FindFactByValues(Facts, variable, domainValue) != null)
            {
                MessageBox.Show("Такая посылка уже существует!");
                return;
            }
            if (!IsPremiseForm && FindFactByValues(Facts, variable, domainValue) != null)
            {
                MessageBox.Show("Такое заключение уже существует!");
                return;
            }

            Fact.Variable = variable;
            Fact.DomainValue = domainValue;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InitializeVariableCombobox()
        {
            foreach (var variable in KnowledgeBase.Variables)
            {
                // Посылка: запрашиваемые и выводимо-запрашиваемые
                if (IsPremiseForm && (variable.VariableType == VarType.Requested || variable.VariableType == VarType.InferredRequested))
                {
                    variableComboBox.Items.Add(variable);
                }

                // Заключение: выводимые и выводимо-запрашиваемые
                if (!IsPremiseForm && (variable.VariableType == VarType.Inferred || variable.VariableType == VarType.InferredRequested))
                {
                    variableComboBox.Items.Add(variable);
                }
            }

            // Choose first variable if combobox is not empty
            if (variableComboBox.Items.Count > 0)
            {
                variableComboBox.SelectedIndex = 0;
            }
        }
        
        private static Fact? FindFactByValues(List<Fact> facts, Variable variable, DomainValue domainValue)
        {
            return facts.FirstOrDefault(f => f.Variable == variable && f.DomainValue == domainValue);
        }
    }
}
