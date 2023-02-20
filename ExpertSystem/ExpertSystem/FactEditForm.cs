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
    public partial class FactEditForm : Form
    {
        private KnowledgeBase KnowledgeBase { get; }
        private bool IsPremiseForm { get; }
        public Fact Fact { get; private set; }

        public FactEditForm(KnowledgeBase knowledgeBase, bool isPremiseForm)
        {
            InitializeComponent();
            this.Text = "Добавление факта";

            KnowledgeBase = knowledgeBase;
            IsPremiseForm = isPremiseForm;
            Fact = new Fact(null, null);

            InitializeVariableCombobox();
        }

        public FactEditForm(KnowledgeBase knowledgeBase, Fact fact, bool isPremiseForm)
        {
            InitializeComponent();
            this.Text = $"Изменение факта";

            KnowledgeBase = knowledgeBase;
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

            // TODO уточнить насчет типов переменных (1)
            // Посылка: запрашиваемые и запрашиваемо-выводимые (неточно)
            if (IsPremiseForm && (variable.VariableType == VarType.Inquire || variable.VariableType == VarType.InquireProduce))
            {
                variableComboBox.Items.Add(variable);
                variableComboBox.SelectedItem = variable;
            }
            
            // Заключение: выводимые и запрашиваемо-выводимые
            if (!IsPremiseForm && (variable.VariableType == VarType.Produce || variable.VariableType == VarType.InquireProduce))
            {
                variableComboBox.Items.Add(variable);
                variableComboBox.SelectedItem = variable;
            }
        }

        private void variableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var variable = variableComboBox.SelectedItem as Variable;
            if (variable == null)
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
            var variable = variableComboBox.SelectedItem as Variable;
            if (variable is null)
            {
                MessageBox.Show("Выберите переменную!");
                return;
            }

            var domainValue = domainValueComboBox.SelectedItem as DomainValue;
            if (domainValue is null)
            {
                MessageBox.Show("Выберите значение!");
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
            // TODO уточнить насчет типов переменных (2)
            foreach (var variable in KnowledgeBase.Variables)
            {
                // Посылка: запрашиваемые и запрашиваемо-выводимые (неточно)
                if (IsPremiseForm && (variable.VariableType == VarType.Inquire || variable.VariableType == VarType.InquireProduce))
                {
                    variableComboBox.Items.Add(variable);
                }

                // Заключение: выводимые и запрашиваемо-выводимые
                if (!IsPremiseForm && (variable.VariableType == VarType.Produce || variable.VariableType == VarType.InquireProduce))
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
    }
}
