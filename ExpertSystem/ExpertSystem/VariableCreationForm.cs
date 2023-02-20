using ExpertSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Variable = new Variable(string.Empty, null, VarType.Inquire, string.Empty);
            this.Text = "Создание переменной";

            // Initializing form fields
            variableNameTextBox.Text = string.Empty;
            foreach (var domain in KnowledgeBase.Domains)
            {
                domainComboBox.Items.Add(domain);
            }
            SetRadioButtonOnVariableType(VarType.Inquire);

            // TODO auto generate question text
            questionTextBox.Text = string.Empty;
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
            Variable.VariableType = GetSeletedVariableType();
            Variable.QuestionText = questionTextBox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SetRadioButtonOnVariableType(VarType type)
        {
            switch (type)
            {
                case VarType.Inquire:
                    inquireProduceRadioButton.Checked = true;
                    break;
                case VarType.Produce:
                    produceRadioButton.Checked = true;
                    break;
                case VarType.InquireProduce:
                    inquireProduceRadioButton.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private VarType GetSeletedVariableType()
        {
            foreach (var control in variableTypePanel.Controls)
            {
                RadioButton? radio = control as RadioButton;

                if (radio == null || !radio.Checked)
                {
                    continue;
                }

                var buttonName = radio.Name;
                switch (buttonName)
                {
                    case "inquireRadioButton":
                        return VarType.Inquire;
                    case "produceRadioButton":
                        return VarType.Produce;
                    case "inquireProduceRadioButton":
                        return VarType.InquireProduce;
                    default:
                        break;
                }
            }
            throw new Exception("Couldn't determine radio button by its name");
        }
    }
}
