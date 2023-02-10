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

        private void addRuleButton_Click(object sender, EventArgs e)
        {
            var ruleEditForm = new RuleEditForm();
            ruleEditForm.ShowDialog();
        }

        #region DGV - drag and drop
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

        private void dgvRules_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dgvRules.SelectedRows.Count > 0)
            {
                dgvRules.DoDragDrop(dgvRules.SelectedRows, DragDropEffects.Move);
            }
        }

        #endregion

        private void dgvRules_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRules.SelectedRows.Count > 0)
            {
                SetEditAndDeleteButtonStatus(true);
                //TODO update premise rule listbox
                //TODO update conclusion rule listbox
            }
            else
            {
                SetEditAndDeleteButtonStatus(false);
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
            }
        }

        private void SetEditAndDeleteButtonStatus(bool status)
        {
            editRuleButton.Enabled = status;
            deleteRuleButton.Enabled = status;
        }
    }
}