﻿using ExpertSystemShellDomain.Entities;

namespace ExpertSystem
{
    public partial class RuleEditForm : Form
    {
        private KnowledgeBase Knowledge { get; }
        public Rule Rule { get; }

        public RuleEditForm(KnowledgeBase knowledge)
        {
            InitializeComponent();
            Knowledge = knowledge;
            Rule = new Rule(string.Empty, string.Empty);
            
            this.Text = "Создание правила";
            this.ruleNameTextBox.Text = $"Rule {Knowledge.Rules.Count + 1}";
        }

        public RuleEditForm(KnowledgeBase knowledge, Rule rule)
        {
            InitializeComponent();
            Knowledge = knowledge;
            Rule = rule;

            // Fill form fields
            this.Text = "Изменение правила";
            ruleNameTextBox.Text = rule.Name;
            descriptionTextBox.Text = rule.Description;
            foreach (var premise in Rule.Premises)
            {
                premiseListBox.Items.Add(premise);
            }
            foreach (var conclusion in Rule.Conclusions)
            {
                conclusionListBox.Items.Add(conclusion);
            }
        }

        #region Premise buttons
        private void addPremiseButton_Click(object sender, EventArgs e)
        {
            using var factEditForm = new FactEditForm(Knowledge, GetFacts(premiseListBox), true);
            if (factEditForm.ShowDialog() != DialogResult.OK)
                return;

            var premise = factEditForm.Fact;
            premiseListBox.Items.Add(premise);
            UpdateDescription();
        }

        private void editPremiseButton_Click(object sender, EventArgs e)
        {
            // (!) Changes in the premise will remain if user cancels editing
            
            if (premiseListBox.SelectedItems.Count == 0)
                return;
            if (premiseListBox.SelectedItems[0] is not Fact premise)
                return;
            int selectedIndex = premiseListBox.SelectedIndex;

            // Delegate premise to edit. If user cancel result won't be written to it.
            using var factEditForm = new FactEditForm(Knowledge, GetFacts(premiseListBox), premise, true);
            if (factEditForm.ShowDialog() != DialogResult.OK)
                return;

            premiseListBox.Items[selectedIndex] = premise; // Need to redraw with updated premise
            UpdateDescription();
        }

        private void deletePremiseButton_Click(object sender, EventArgs e)
        {
            if (premiseListBox.SelectedItems.Count == 0)
                return;

            if (premiseListBox.SelectedItems[0] is not Fact premise)
                return;

            premiseListBox.Items.RemoveAt(premiseListBox.SelectedIndex);
            UpdateDescription();
        }
        #endregion

        #region Conclusion buttons
        private void addConclusionButton_Click(object sender, EventArgs e)
        {
            using var factEditForm = new FactEditForm(Knowledge, GetFacts(conclusionListBox), false);
            if (factEditForm.ShowDialog() != DialogResult.OK)
                return;

            var conclusion = factEditForm.Fact; 
            conclusionListBox.Items.Add(conclusion);
            UpdateDescription();
        }

        private void editConclusionButton_Click(object sender, EventArgs e)
        {
            if (conclusionListBox.SelectedItems.Count == 0)
                return;
            if (conclusionListBox.SelectedItems[0] is not Fact conclusion)
                return;
            int selectedIndex = conclusionListBox.SelectedIndex;
            
            // Delegate conclusion to edit form. If user cancel result won't be written to it.
            using var factEditForm = new FactEditForm(Knowledge, GetFacts(conclusionListBox), conclusion, true);
            if (factEditForm.ShowDialog() != DialogResult.OK)
                return;

            conclusionListBox.Items[selectedIndex] = conclusion; // Need to redraw with updated conclusion
            UpdateDescription();
        }

        private void deleteConclusionButton_Click(object sender, EventArgs e)
        {
            if (conclusionListBox.SelectedItems.Count == 0)
                return;

            if (conclusionListBox.SelectedItems[0] is not Fact conclusion)
                return;

            conclusionListBox.Items.RemoveAt(conclusionListBox.SelectedIndex);
            UpdateDescription();
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
            if (Rule.Name != ruleNameTextBox.Text && Knowledge.GetRuleByName(ruleNameTextBox.Text) != null)
            {
                MessageBox.Show("Правило с таким именем уже сущестувует!");
                return;
            }
            if (conclusionListBox.Items.Count == 0)
            {
                MessageBox.Show("Правило должно содержать хотя бы одно заключение!");
                return;
            }
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                MessageBox.Show("Поле с описанием должно быть заполнено!");
                return;
            }

            Rule.Name = ruleNameTextBox.Text;
            Rule.Description = descriptionTextBox.Text;

            // Get premises, conclusion from list box and save them in rule
            var premises = new List<Fact>(premiseListBox.Items.Count);
            premises.AddRange(premiseListBox.Items.Cast<Fact>());
            Rule.Premises = premises;
            
            var conclusions = new List<Fact>(conclusionListBox.Items.Count);
            conclusions.AddRange(conclusionListBox.Items.Cast<Fact>());
            Rule.Conclusions = conclusions;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Form rule description by concatenating premises and conclusions and updates its field.
        /// Set field to empty string if couldn't form description.  
        /// </summary>
        private void UpdateDescription()
        {
            if (premiseListBox.Items.Count == 0 || conclusionListBox.Items.Count == 0)
            {
                descriptionTextBox.Text = string.Empty;
                return;
            }

            string premisesText = string.Join(" И ", premiseListBox.Items.Cast<Fact>().Select(f => f.ToString()));
            string conclusionsText = string.Join(" И ", conclusionListBox.Items.Cast<Fact>().Select(f => f.ToString()));
            string description = premisesText + ", ТО " + conclusionsText;
            descriptionTextBox.Text = description;
        }

        private static List<Fact> GetFacts (ListBox listBox)
        {
            return listBox.Items.Count > 0
                ? listBox.Items.Cast<Fact>().ToList()
                : new List<Fact>();
        }
    }
}
