using ExpertSystemShellDomain;
using ExpertSystemShellDomain.Entities;

namespace ExpertSystem.BaseForm
{
    public partial class MainForm : Form
    {
        private readonly ExpertSystemShell _expertSystemShell;
        private KnowledgeBase KnowledgeBase => _expertSystemShell.KnowledgeBase; 
        private string KnowledgeBaseFilePath { get; set; } = string.Empty;
        
        public MainForm()
        {
            InitializeComponent();
            _expertSystemShell = new ExpertSystemShell(new FormsIo());
        }

        //----------------------------------------------------------------
        // ToolStrip
        //----------------------------------------------------------------

        private void newToolStrip_Click(object sender, EventArgs e)
        {
            _expertSystemShell.CreateEmptyKnowledgeBase();
            KnowledgeBaseFilePath = string.Empty;
            
            // Set to rerender tab
            tabControl.SelectedIndex = 1; 
            tabControl.SelectedIndex = 0; 
            
            // TODO (?) clear consulting form 
        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog()
            {
                Title = "Открытие к базе знаний",
                DefaultExt = "kb",
                Filter = "knowledge base files (*.kb)|*.kb",
                CheckFileExists = true,
                CheckPathExists = true
            };
            
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            KnowledgeBaseFilePath = openFileDialog.FileName;
            if (!_expertSystemShell.LoadKnowledgeBase(KnowledgeBaseFilePath))
            {
                MessageBox.Show("Не удалось загрузить базу знаний!", "Ошибка");
                return;
            }

            // Set index to rerender tab
            tabControl.SelectedIndex = 1; 
            tabControl.SelectedIndex = 0; 
        }

        private void saveToolStrip_Click(object sender, EventArgs e)
        {
            string knowledgeBaseFilePath = KnowledgeBaseFilePath;
            if (string.IsNullOrWhiteSpace(knowledgeBaseFilePath))
            {
                knowledgeBaseFilePath = SelectSaveFolder();
            }
            if (string.IsNullOrWhiteSpace(knowledgeBaseFilePath))
                return;

            if (!_expertSystemShell.SaveKnowledgeBase(knowledgeBaseFilePath))
            {
                MessageBox.Show("Не удалось сохранить базу знаний", "Ошибка");
                return;
            }
            
            KnowledgeBaseFilePath = knowledgeBaseFilePath;
        }

        private void saveAsToolStrip_Click(object sender, EventArgs e)
        {
            string knowledgeBaseFilePath = SelectSaveFolder();
            if (string.IsNullOrWhiteSpace(knowledgeBaseFilePath))
                return;
            
            if (!_expertSystemShell.SaveKnowledgeBase(knowledgeBaseFilePath))
            {
                MessageBox.Show("Не удалось сохранить базу знаний", "Ошибка");
                return;
            }
            
            KnowledgeBaseFilePath = knowledgeBaseFilePath;
        }

        /// <summary>
        /// Open SaveFileDialog and return knowledge base save path or empty string if couldn't select folder.
        /// </summary>
        /// <returns>Path to saved file or empty string if couldn't save.</returns>
        private static string SelectSaveFolder()
        {
            var saveFileDialog = new SaveFileDialog()
            {
                Title = "Сохранение базы знаний",
                DefaultExt = "kb",
                Filter = "knowledge base files (*.kb)|*.kb",
                RestoreDirectory = true,
                CheckPathExists = true,
            };

            return saveFileDialog.ShowDialog() != DialogResult.OK ? string.Empty : saveFileDialog.FileName;
        }

        private void beginConsultToolStrip_Click(object sender, EventArgs e)
        {
            var inferredVariables = KnowledgeBase.Variables
                .Where(v => v.VariableType == VarType.Inferred || v.VariableType == VarType.InferredRequested).ToList();

            if (!inferredVariables.Any())
            {
                MessageBox.Show("Целевые переменные в данной базе знаний не найдены");
                return;
            }
            
            using var consultForm = new ConsultationForm(inferredVariables);
            consultForm.ShowDialog();

            var targetVariable = consultForm.SelectedVariable;
            if (targetVariable is null)
            {
                MessageBox.Show("Целевая переменная не выбрана", "Ошибка");
                return;
            }
            
            _expertSystemShell.Infer(targetVariable);
        }
        
        private void explainToolStrip_Click(object sender, EventArgs e)
        {
            
        }

        private void DgvSelectionChanged(object sender, Button editButton, Button deleteButton)
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
            premiseListBox.Items.Clear();
            conclusionListBox.Items.Clear();
            
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
            questionTextBox.Text = string.Empty;
            ruleDomainValuesListBox.Items.Clear();
            
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
            domainValuesListBox.Items.Clear();
            
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