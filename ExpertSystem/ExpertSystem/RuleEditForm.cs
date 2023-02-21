using ExpertSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class RuleEditForm : Form
    {
        private KnowledgeBase Shell { get; }
        public Rule Rule { get; private set; }

        private readonly List<Fact> _originalPremises;
        private readonly List<Fact> _originalConclusions;

        public RuleEditForm(KnowledgeBase shell)
        {
            InitializeComponent();
            this.Text = "Создание правила";
            
            Shell = shell;
            Rule = new Rule(string.Empty, string.Empty);
            _originalPremises = new List<Fact>();
            _originalConclusions = new List<Fact>();

            // TODO auto-generated description
        }

        public RuleEditForm(KnowledgeBase shell, Rule rule)
        {
            InitializeComponent();
            this.Text = "Изменение правила";
            Shell = shell;
            Rule = rule;

            _originalPremises = new List<Fact>(Rule.Premises);
            _originalConclusions = new List<Fact>(Rule.Conclusions);

            // TODO auto-generated description
        }

        #region Premise buttons
        private void addPremiseButton_Click(object sender, EventArgs e)
        {
            using var FactEditForm = new FactEditForm(Shell, isPremiseForm: true);
            if (FactEditForm.ShowDialog() != DialogResult.OK)
                return;

            var premise = FactEditForm.Fact;
            premiseListBox.Items.Add(premise);
            Rule.Premises.Add(premise);
        }

        private void editPremiseButton_Click(object sender, EventArgs e)
        {
            // (!) Changes in the facts will remain if user cancels editing

            if (premiseListBox.SelectedItems.Count == 0)
                return;
            
            var premise = premiseListBox.SelectedItems[0] as Fact;
            if (premise == null)
                return;

            // Delegate premise to edit. If user cancel result won't be written to it.
            using var FactEditForm = new FactEditForm(Shell, premise, true);
            if (FactEditForm.ShowDialog() != DialogResult.OK)
                return;

            premiseListBox.Refresh(); // Redraw with updated premise
        }

        private void deletePremiseButton_Click(object sender, EventArgs e)
        {
            if (premiseListBox.SelectedItems.Count == 0)
                return;

            var premise = premiseListBox.SelectedItems[0] as Fact;
            if (premise == null)
                return;

            premiseListBox.Items.RemoveAt(premiseListBox.SelectedIndex);
            Rule.Premises.Remove(premise);
        }
        #endregion

        #region Conclusion buttons
        private void addConclusionButton_Click(object sender, EventArgs e)
        {
            using var FactEditForm = new FactEditForm(Shell, isPremiseForm: false);
            if (FactEditForm.ShowDialog() != DialogResult.OK)
                return;

            var conclusion = FactEditForm.Fact; // Getting result from form and updating data and view
            conclusionListBox.Items.Add(conclusion);
            Rule.Conclusions.Add(conclusion);
        }

        private void editConclusionButton_Click(object sender, EventArgs e)
        {
            if (conclusionListBox.SelectedItems.Count == 0)
                return;

            var conclusion = conclusionListBox.SelectedItems[0] as Fact;
            if (conclusion == null)
                return;

            // Delegate conclusion to edit. If user cancel result won't be written to it.
            using var FactEditForm = new FactEditForm(Shell, conclusion, true);
            if (FactEditForm.ShowDialog() != DialogResult.OK)
                return;

            conclusionListBox.Refresh(); // Redraw with updated conclusion
        }

        private void deleteConclusionButton_Click(object sender, EventArgs e)
        {
            if (conclusionListBox.SelectedItems.Count == 0)
                return;

            var conclusion = conclusionListBox.SelectedItems[0] as Fact;
            if (conclusion == null)
                return;

            conclusionListBox.Items.RemoveAt(conclusionListBox.SelectedIndex);
            Rule.Conclusions.Remove(conclusion);
        }
        #endregion

        private void premiseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (premiseListBox.SelectedItems.Count > 0)
            {
                SetEditAndDeletePremiseButtonStatus(true);
            }
            else
            {
                SetEditAndDeletePremiseButtonStatus(false);
            }
        }

        private void SetEditAndDeletePremiseButtonStatus(bool status)
        {
            editPremiseButton.Enabled = status;
            deletePremiseButton.Enabled = status;
        }

        private void conclusionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conclusionListBox.SelectedItems.Count > 0)
            {
                SetEditAndDeleteConclusionButtonStatus(true);
            }
            else
            {
                SetEditAndDeleteConclusionButtonStatus(false);
            }
        }

        private void SetEditAndDeleteConclusionButtonStatus(bool status)
        {
            editConclusionButton.Enabled = status;
            deleteConclusionButton.Enabled = status;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ruleNameTextBox.Text))
            {
                MessageBox.Show("Поле с именем должно быть заполнено!");
                return;
            }
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                MessageBox.Show("Поле с описанием должно быть заполнено!");
                return;
            }
            
            if (Rule.Name != ruleNameTextBox.Text && Shell.GetRuleByName(ruleNameTextBox.Text) != null)
            {
                MessageBox.Show("Правило с таким именем уже сущестувует!");
                return;
            }

            Rule.Name = ruleNameTextBox.Text;
            Rule.Description = descriptionTextBox.Text;
            Rule.Premises = _originalPremises;
            Rule.Conclusions = _originalConclusions;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
