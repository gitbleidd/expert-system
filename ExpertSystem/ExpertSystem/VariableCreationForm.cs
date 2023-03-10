using ExpertSystemShellDomain.Entities;

namespace ExpertSystem
{
    public partial class VariableCreationForm : Form
    {
        private KnowledgeBase KnowledgeBase { get; }
        public Variable Variable { get; private set; }

        public VariableCreationForm(KnowledgeBase knowledgeBase)
        {
            InitializeComponent();
            KnowledgeBase = knowledgeBase;
            Variable = new Variable(string.Empty, null, VarType.Requested, string.Empty);
            this.Text = "Создание переменной";

            // Initializing form fields
            string initVariableName = $"Variable {KnowledgeBase.Variables.Count + 1}";
            variableNameTextBox.Text = initVariableName;
            foreach (var domain in KnowledgeBase.Domains)
            {
                domainComboBox.Items.Add(domain);
            }
            SetRadioButtonOnVariableType(VarType.Requested);
            
            questionTextBox.Text = $"{initVariableName}?";
        }

        public VariableCreationForm(KnowledgeBase knowledgeBase, Variable variable)
        {
            InitializeComponent();
            KnowledgeBase = knowledgeBase;
            Variable = variable;
            this.Text = "Редактирование переменной";


            // Initializing form fields
            variableNameTextBox.Text = Variable.Name;
            foreach (var domain in KnowledgeBase.Domains)
            {
                domainComboBox.Items.Add(domain);
            }
            domainComboBox.SelectedItem = Variable.Domain;
            SetRadioButtonOnVariableType(Variable.VariableType);
            questionTextBox.Text = Variable.QuestionText;
        }

        private void createDomainButton_Click(object sender, EventArgs e)
        {
            var domain = new Domain(string.Empty);
            using var domainEditForm = new DomainEditForm(KnowledgeBase, domain);
            var dialogResult = domainEditForm.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            KnowledgeBase.Domains.Add(domain);
            int index = domainComboBox.Items.Add(domain);
            domainComboBox.SelectedIndex = index;
            domainComboBox.Refresh();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(variableNameTextBox.Text))
            {
                MessageBox.Show("Необходимо заполнить поле с именем переменной!");
                return;
            }
            if (variableNameTextBox.Text != Variable.Name && KnowledgeBase.GetVariableByName(variableNameTextBox.Text) != null)
            {
                MessageBox.Show("Переменная с таким именем уже существует!");
                return;
            }
            if (domainComboBox.Items.Count == 0 || domainComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Необходимо выбрать домен!");
                return;
            }
            if (string.IsNullOrWhiteSpace(questionTextBox.Text))
            {
                MessageBox.Show("Необходимо заполнить поле вопроса!");
                return;
            }

            Variable.Name = variableNameTextBox.Text;
            Variable.Domain = (Domain)domainComboBox.SelectedItem;
            Variable.VariableType = GetSelectedVariableType();
            Variable.QuestionText = questionTextBox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SetRadioButtonOnVariableType(VarType type)
        {
            switch (type)
            {
                case VarType.Requested:
                    requestedRadioButton.Checked = true;
                    // TODO check later was before: produceInquireRadioButton.Checked = true;
                    break;
                case VarType.Inferred:
                    inferredRadioButton.Checked = true;
                    break;
                case VarType.InferredRequested:
                    inferredRequestedRadioButton.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private VarType GetSelectedVariableType()
        {
            foreach (var control in variableTypePanel.Controls)
            {
                if (control is not RadioButton radio || !radio.Checked)
                {
                    continue;
                }

                var buttonName = radio.Name;
                switch (buttonName)
                {
                    case "requestedRadioButton":
                        return VarType.Requested;
                    case "inferredRadioButton":
                        return VarType.Inferred;
                    case "inferredRequestedRadioButton":
                        return VarType.InferredRequested;
                    default:
                        break;
                }
            }
            throw new Exception("Couldn't determine radio button by its name");
        }
    }
}
