using ExpertSystem.Entities;

namespace ExpertSystem.BaseForm
{
    public partial class MainForm : Form
    {
        private KnowledgeBase KnowledgeBase { get; set; } = null!;
        public MainForm()
        {
            InitializeComponent();
            tabControl.Visible = false;
        }

        //----------------------------------------------------------------
        // ToolStrip
        //----------------------------------------------------------------

        private void newToolStrip_Click(object sender, EventArgs e)
        {
            tabControl.Visible = true;
            KnowledgeBase = new KnowledgeBase();
            tabControl.SelectedIndex = 0;
            // TODO (?) clear consulting form 
        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {
            tabControl.Visible = true;
            // TODO open file explorer
        }


        private void dgvSelectionChanged(object sender, Button editButton, Button deleteButton)
        {
            if (sender is not DataGridView dgv)
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
            if (sender is not TabControl tabControl)
                return;

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    FillRulesPage();
                    break;
                case 1:
                    FillVariablesPage();
                    break;
                case 2:
                    FillDomainPage();
                    break;
                default:
                    return;
            }
        }

        private void FillRulesPage()
        {
            dgvRules.Rows.Clear();
            foreach (var rule in KnowledgeBase.Rules)
            {
                int index = dgvRules.Rows.Add();
                SetRuleRowCells(dgvRules.Rows[index], rule);
            }
            if (dgvRules.Rows.Count > 0)
            {
                // Bugfix: turn on manually because dgv on select_change_event
                // always return null if there is one element
                UpdateRuleTabOnSelectedChange(KnowledgeBase.Rules.First());
            }
            dgvRules.Refresh();
        }
        
        private void FillVariablesPage()
        {
            dgvVariables.Rows.Clear();
            foreach (var variable in KnowledgeBase.Variables)
            {
                int index = dgvVariables.Rows.Add();
                SetVariableRowCells(dgvVariables.Rows[index], variable);
            }
            if (dgvVariables.Rows.Count > 0)
            {
                // Bugfix: turn on manually because dgv on select_change_event
                // always return null if there is one element
                UpdateVariableTabOnSelectedChange(KnowledgeBase.Variables.First());
            }
            dgvVariables.Refresh();
        }

        private void FillDomainPage()
        {
            dgvDomains.Rows.Clear();
            foreach (var domain in KnowledgeBase.Domains)
            {
                dgvDomains.Rows.Add(domain);
            }
            if (dgvDomains.Rows.Count > 0)
            {
                dgvDomains.Rows[0].Selected = true;
            }
            dgvDomains.Refresh();
        }
    }
}