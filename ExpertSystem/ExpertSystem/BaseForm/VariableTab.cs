using ExpertSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.BaseForm
{
    partial class MainForm
    {
        //----------------------------------------------------------------
        // Variables Tab
        //----------------------------------------------------------------

        private void addVariableButton_Click(object sender, EventArgs e)
        {
            using var variableEditForm = new VariableCreationForm(Shell);
            if (variableEditForm.ShowDialog() != DialogResult.OK)
                return;

            Variable variable = variableEditForm.Variable;
            Shell.Variables.Add(variable);

            int index = dgvVariables.Rows.Add();
            UpdateVariableRow(dgvVariables.Rows[index], variable);
            dgvVariables.Refresh();
        }

        private void editVariableButton_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvVariables.SelectedRows[0];
            var variable = (Variable)selectedRow.Cells[0].Value;
            var variableCopy = variable.DeepCopy();

            using var variableEditForm = new VariableCreationForm(Shell, variableCopy);
            if (variableEditForm.ShowDialog() != DialogResult.OK)
                return;

            selectedRow.Cells[0].Value = variableCopy;
            UpdateVariableRow(selectedRow, variable);
            dgvVariables_SelectionChanged(sender, e);
            dgvDomains.Refresh();
        }

        private void deleteVariableButton_Click(object sender, EventArgs e)
        {
            if (dgvVariables.SelectedRows.Count == 0)
                return;

            var variable = (Variable)dgvVariables.SelectedRows[0].Cells[0].Value;

            // TODO check for variable use before deleting
            throw new NotImplementedException();

            dgvVariables.Rows.RemoveAt(dgvVariables.SelectedRows[0].Index);
            Shell.Variables.Remove(variable);
        }

        private void dgvVariables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVariables.SelectedRows.Count == 0)
            {
                SetEditAndDeleteVariableButtonStatus(false);
                return;
            }

            SetEditAndDeleteVariableButtonStatus(true);
            var variable = (Variable)dgvVariables.SelectedRows[0].Cells[0].Value;
            questionTextBox.Text = variable.QuestionText;
            ruleDomainValuesListBox.Items.Clear();
            foreach (var value in variable.Domain.Values)
            {
                ruleDomainValuesListBox.Items.Add(value.ToString());
            }
        }

        private void SetEditAndDeleteVariableButtonStatus(bool status)
        {
            editRuleButton.Enabled = status;
            deleteRuleButton.Enabled = status;
        }

        private void UpdateVariableRow(DataGridViewRow row, Variable variable)
        {
            row.Cells[0].Value = variable;
            row.Cells[1].Value = variable.VariableType.GetName();
            row.Cells[2].Value = variable.Domain;
        }
    }
}
