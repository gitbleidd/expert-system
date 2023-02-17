using ExpertSystem.Entities;

namespace ExpertSystem
{
    public partial class MainForm : Form
    {
        private ExpertSystemShell Shell { get; set; } = null!;
        public MainForm()
        {
            InitializeComponent();
            tabControl.Visible = false;

            //dgvRules.Rows.Add(new string[] { "Orange-Salsa Pork Chops", "Main Dish" });
            //dgvRules.Rows.Add(new string[] { "Other", "Stuff" });
            //dgvRules.Rows.Add(new string[] { "Hmm", "Testing datagrid visew rules" });
        }

        //----------------------------------------------------------------
        // ToolStrip
        //----------------------------------------------------------------

        private void newToolStrip_Click(object sender, EventArgs e)
        {
            tabControl.Visible = true;
            Shell = new ExpertSystemShell();
            // TODO update current tab
        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {
            tabControl.Visible = true;
            // TODO open file explorer
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
            var domain = new Domain("");
            var domainEditForm = new DomainEditForm(Shell, domain);
            var dialogResult = domainEditForm.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            Shell.Domains.Add(domain);
            dgvDomains.Rows.Add(domain);
        }

        private void editDomainButton_Click(object sender, EventArgs e)
        {
            var selectedDomain = (Domain)dgvDomains.SelectedRows[0].Cells[0].Value;

            var domainEditForm = new DomainEditForm(Shell, selectedDomain);
            var dialogResult = domainEditForm.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            dgvDomains.Refresh();
        }

        private void deleteDomainButton_Click(object sender, EventArgs e)
        {
            if (dgvDomains.SelectedRows.Count == 0)
                return;

            int index = dgvDomains.SelectedRows[0].Index;
            var domain = (Domain)dgvDomains.SelectedRows[0].Cells[0].Value;
            dgvDomains.Rows.RemoveAt(index);
            Shell.Domains.Remove(domain);
        }

        private void dgvDomains_SelectionChanged(object sender, EventArgs e)
        {
            dgvSelectionChanged(sender, editDomainButton, deleteDomainButton);

            domainValuesListBox.Items.Clear();
            var domain = (Domain)dgvDomains.SelectedRows[0].Cells[0].Value;
            foreach (var value in domain.Values)
            {
                domainValuesListBox.Items.Add(value.ToString());
            }
        }

        private void dgvSelectionChanged(object sender, Button editButton, Button deleteButton)
        {
            var dgv = sender as DataGridView;
            if (dgv == null)
                return;

            if (dgv.SelectedRows.Count == 0)
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                return;
            }

            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        //----------------------------------------------------------------
        // Tab Control
        //----------------------------------------------------------------

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabControl = sender as TabControl;
            if (tabControl == null)
                return;

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    // TODO fill rules page
                    break;
                case 1:
                    // TODO fill variables page
                    break;
                case 2:
                    // Fill domain page
                    foreach (var domain in Shell.Domains)
                    {
                        //dgvRules.Rows.Add(new string[] { "Orange-Salsa Pork Chops", "Main Dish" });
                        dgvRules.Rows.Add(domain);
                    }

                    // ?? dgvRules.Rows.Add(Shell.Domains.ToArray());
                    break;
                default:
                    break;
            }
            //Shell
        }
    }
}