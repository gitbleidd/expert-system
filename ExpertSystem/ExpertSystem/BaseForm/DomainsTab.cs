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
        // Domains Tab
        //----------------------------------------------------------------

        private void addDomainButton_Click(object sender, EventArgs e)
        {
            var domain = new Domain("");
            using var domainEditForm = new DomainEditForm(KnowledgeBase, domain);
            var dialogResult = domainEditForm.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            KnowledgeBase.Domains.Add(domain);
            dgvDomains.Rows.Add(domain);
        }

        private void editDomainButton_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvDomains.SelectedRows[0];
            var selectedDomain = (Domain)selectedRow.Cells[0].Value;

            using var domainEditForm = new DomainEditForm(KnowledgeBase, selectedDomain);
            var dialogResult = domainEditForm.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            dgvDomains_SelectionChanged(sender, e);
            dgvDomains.Refresh();
        }

        private void deleteDomainButton_Click(object sender, EventArgs e)
        {
            if (dgvDomains.SelectedRows.Count == 0)
                return;

            int index = dgvDomains.SelectedRows[0].Index;
            var domain = (Domain)dgvDomains.SelectedRows[0].Cells[0].Value;

            // Forbid deleting domain if it is using in variables
            List<Variable> domainVariables = KnowledgeBase.GetVariablesByDomain(domain);
            if (domainVariables.Any())
            {
                MessageBox.Show($"Данный домен используется в переменных: {string.Join(", ", domainVariables)}!");
                return;
            }

            // Forbid deleting domain if it's values are using in rules' facts
            var matchedRules = KnowledgeBase.GetRulesByDomainValues(domain.Values);
            if (matchedRules.Any())
            {
                MessageBox.Show($"Домен используется в фактах правил: {string.Join(", ", matchedRules)}");
                return;
            }

            dgvDomains.Rows.RemoveAt(index);
            KnowledgeBase.Domains.Remove(domain);
        }

        private void dgvDomains_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDomains.Rows.Count == 0 || dgvDomains.SelectedRows.Count == 0)
                return;

            var domain = dgvDomains.SelectedRows[0].Cells[0].Value as Domain;
            if (domain == null)
                return;

            DgvSelectionChanged(sender, editDomainButton, deleteDomainButton);

            domainValuesListBox.Items.Clear();
            foreach (var value in domain.Values)
            {
                domainValuesListBox.Items.Add(value.ToString());
            }
        }
    }
}
