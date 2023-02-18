using ExpertSystem.Entities;

namespace ExpertSystem.BaseForm
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