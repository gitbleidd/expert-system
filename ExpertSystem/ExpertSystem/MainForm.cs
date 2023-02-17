namespace ExpertSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //dgvRules.Rows.Add(new string[] { "Orange-Salsa Pork Chops", "Main Dish" });
            //dgvRules.Rows.Add(new string[] { "Other", "Stuff" });
            //dgvRules.Rows.Add(new string[] { "Hmm", "Testing datagrid visew rules" });
        }

        //----------------------------------------------------------------
        // Rules Tab
        //----------------------------------------------------------------

        private void addRuleButton_Click(object sender, EventArgs e)
        {
            var ruleEditForm = new RuleEditForm();
            ruleEditForm.ShowDialog();
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

            var updatedCopyOfDgvItems = dgvRules.Rows.Cast<DataGridViewRow>().ToArray();

            int dragRow = dragRows[0].Index;
            int swapRow = hitInfo.RowIndex;

            updatedCopyOfDgvItems[dragRow] = dgvRules.Rows[swapRow];
            updatedCopyOfDgvItems[swapRow] = dgvRules.Rows[dragRow];
            dgvRules.Rows.Clear();
            dgvRules.Rows.AddRange(updatedCopyOfDgvItems);

            dgvRules.ClearSelection();
            dgvRules.Rows[swapRow].Selected = true;
        }

        #endregion

        private void dgvRules_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRules.SelectedRows.Count > 0)
            {
                SetEditAndDeleteRuleButtonStatus(true);
                //TODO update premise rule listbox
                //TODO update conclusion rule listbox
            }
            else
            {
                SetEditAndDeleteRuleButtonStatus(false);
            }
        }

        private void editRuleButton_Click(object sender, EventArgs e)
        {
            // TODO RuleEditForm.dialog()
        }

        private void deleteRuleButton_Click(object sender, EventArgs e)
        {
            if (dgvRules.SelectedRows.Count > 0)
            {
                dgvRules.Rows.RemoveAt(dgvRules.SelectedRows[0].Index);
                //TODO delete at shell
            }
        }

        private void SetEditAndDeleteRuleButtonStatus(bool status)
        {
            editRuleButton.Enabled = status;
            deleteRuleButton.Enabled = status;
        }

        //----------------------------------------------------------------
        // Variables Tab
        //----------------------------------------------------------------

        private void addVariableButton_Click(object sender, EventArgs e)
        {
            var variableEditForm = new VariableCreationForm();
            variableEditForm.ShowDialog();
        }

        private void editVariableButton_Click(object sender, EventArgs e)
        {
            // TODO var variableEditForm = new VariableEditForm();
        }

        private void deleteVariableButton_Click(object sender, EventArgs e)
        {
            if (dgvVariables.SelectedRows.Count == 0)
                return;
            
            dgvVariables.Rows.RemoveAt(dgvVariables.SelectedRows[0].Index);
            // TODO delete from shell
        }

        private void dgvVariables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVariables.SelectedRows.Count == 0)
            {
                SetEditAndDeleteVariableButtonStatus(false);
            }
            else
            {
                SetEditAndDeleteVariableButtonStatus(true);
                //TODO update question rule textbox
                //TODO update domain values listbox
            }
        }

        private void SetEditAndDeleteVariableButtonStatus(bool status)
        {
            editRuleButton.Enabled = status;
            deleteRuleButton.Enabled = status;
        }

        //----------------------------------------------------------------
        // Domains Tab
        //----------------------------------------------------------------

        private void addDomainButton_Click(object sender, EventArgs e)
        {
            var domainEditForm = new DomainEditForm();
            domainEditForm.ShowDialog();
        }

        private void editDomainButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteDomainButton_Click(object sender, EventArgs e)
        {

        }
    }
}