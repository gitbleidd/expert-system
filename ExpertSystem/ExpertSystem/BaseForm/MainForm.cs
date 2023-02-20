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
            // TODO clear consulting form (?)
        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {
            tabControl.Visible = true;
            // TODO open file explorer
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
                    dgvRules.Rows.Clear();
                    foreach (var rule in KnowledgeBase.Rules)
                    {
                        int index = dgvVariables.Rows.Add();
                        SetRuleRowCells(dgvVariables.Rows[index], rule);
                    }
                    if (dgvRules.Rows.Count > 0)
                    {
                        // TODO bugfix
                    }
                    dgvRules.Refresh();

                    break;
                case 1:
                    // Fill variables page
                    dgvVariables.Rows.Clear();
                    foreach (var variable in KnowledgeBase.Variables)
                    {
                        int index = dgvVariables.Rows.Add();
                        SetVariableRowCells(dgvVariables.Rows[index], variable);
                    }
                    if (dgvVariables.Rows.Count > 0)
                    {
                        // Bug: turn on manually because dgv on select_change_event
                        // always return null if there is one element
                        UpdateFormOnSelectedChange(KnowledgeBase.Variables.First());
                    }
                    dgvVariables.Refresh();
                    break;
                case 2:
                    // Fill domain page
                    dgvDomains.Rows.Clear();
                    foreach (var domain in KnowledgeBase.Domains)
                    {
                        //dgvRules.Rows.Add(new string[] { "Orange-Salsa Pork Chops", "Main Dish" });
                        dgvDomains.Rows.Add(domain);
                    }
                    if (dgvDomains.Rows.Count > 0)
                    {
                        dgvDomains.Rows[0].Selected = true;
                    }
                    dgvDomains.Refresh();

                    // ?? dgvRules.Rows.Add(KnowledgeBase.Domains.ToArray());
                    break;
                default:
                    break;
            }
        }
    }
}