using ExpertSystem.Entities;

namespace ExpertSystem.BaseForm
{
    partial class MainForm
    {
        //----------------------------------------------------------------
        // Rules Tab
        //----------------------------------------------------------------

        private void addRuleButton_Click(object sender, EventArgs e)
        {
            using var ruleEditForm = new RuleEditForm(KnowledgeBase);
            if (ruleEditForm.ShowDialog() != DialogResult.OK)
                return;

            Rule rule = ruleEditForm.Rule; // Get created rule from form
            KnowledgeBase.Rules.Add(rule);
            
            int index = dgvRules.Rows.Add();
            SetRuleRowCells(dgvRules.Rows[index], rule);
            dgvRules.Refresh();

            // Bug: turn on manually because dgv on select_change_event
            // always return null if there is one element
            UpdateRuleTabOnSelectedChange(rule);
        }

        private void editRuleButton_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvRules.SelectedRows[0];
            if (selectedRow.Cells[0].Value is not Rule rule)
                return;
            
            using var ruleEditForm = new RuleEditForm(KnowledgeBase, rule);

            ruleEditForm.ShowDialog();
            // if (ruleEditForm.ShowDialog() != DialogResult.OK)
            //     return;

            // Update rule name, description in dgv cells
            selectedRow.Cells[0].Value = rule;
            selectedRow.Cells[1].Value = rule.Description;
                
            dgvRules_SelectionChanged(sender, e);
            dgvRules.Refresh();
        }

        private void deleteRuleButton_Click(object sender, EventArgs e)
        {
            if (dgvRules.SelectedRows.Count == 0)
                return;

            var rule = (Rule)dgvRules.SelectedRows[0].Cells[0].Value;
            
            dgvRules.Rows.RemoveAt(dgvRules.SelectedRows[0].Index);
            KnowledgeBase.Rules.Remove(rule);
        }

        private void dgvRules_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRules.SelectedRows.Count == 0)
            {
                SetEditAndDeleteRuleButtonStatus(false);
                return;
            }
            
            if (dgvRules.SelectedRows[0].Cells[0].Value is not Rule rule)
                return;
            UpdateRuleTabOnSelectedChange(rule);
        }

        private void SetEditAndDeleteRuleButtonStatus(bool status)
        {
            editRuleButton.Enabled = status;
            deleteRuleButton.Enabled = status;
        }

        private void SetRuleRowCells(DataGridViewRow row, Rule rule)
        {
            row.Cells[0].Value = rule;
            row.Cells[1].Value = rule.Description;
        }

        private void UpdateRuleTabOnSelectedChange(Rule rule)
        {
            SetEditAndDeleteRuleButtonStatus(true);
            premiseListBox.Items.Clear();
            foreach (var premise in rule.Premises)
            {
                premiseListBox.Items.Add(premise);
            }
            
            conclusionListBox.Items.Clear();
            foreach (var conclusion in rule.Conclusions)
            {
                conclusionListBox.Items.Add(conclusion);
            }
        }

        #region DGV - drag and drop
        private void dgvRules_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dgvRules.SelectedRows.Count > 0)
            {
                dgvRules.DoDragDrop(dgvRules.SelectedRows, DragDropEffects.Move);
            }
        }

        private void dgvRules_DragEnter(object sender, DragEventArgs e)
        {
            if (dgvRules.SelectedRows.Count > 0)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void dgvRules_DragDrop(object sender, DragEventArgs e)
        {
            var dragRows = e.Data.GetData(typeof(DataGridViewSelectedRowCollection))
                as DataGridViewSelectedRowCollection;

            if (dragRows == null || dragRows.Count <= 0 || dgvRules.Rows.Count <= 1)
                return;


            Point clientPoint = dgvRules.PointToClient(new Point(e.X, e.Y));
            var hitInfo = dgvRules.HitTest(clientPoint.X, clientPoint.Y);
            if (hitInfo.Type == DataGridViewHitTestType.None)
                return;

            int dragRowIndex = dragRows[0].Index;
            int swapRowIndex = hitInfo.RowIndex;
            var dragValue = KnowledgeBase.Rules[dragRowIndex];
            var swapValue = KnowledgeBase.Rules[swapRowIndex];

            // Swap in knowledge base
            KnowledgeBase.Rules[dragRowIndex] = swapValue;
            KnowledgeBase.Rules[swapRowIndex] = dragValue;
            
            // Swap in dgv
            dgvRules.Rows[dragRowIndex].Cells[0].Value = swapValue;
            dgvRules.Rows[swapRowIndex].Cells[0].Value = dragValue;
            dgvRules.Rows[dragRowIndex].Cells[1].Value = swapValue.Description;
            dgvRules.Rows[swapRowIndex].Cells[1].Value = dragValue.Description;

            dgvRules.Refresh();
            dgvRules.ClearSelection();
            dgvRules.Rows[swapRowIndex].Selected = true;
        }

        #endregion
    }
}
