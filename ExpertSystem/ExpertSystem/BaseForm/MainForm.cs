using System.Runtime.Serialization.Formatters.Binary;
using ExpertSystem.Entities;
using Newtonsoft.Json;

namespace ExpertSystem.BaseForm
{
    public partial class MainForm : Form
    {
        private KnowledgeBase KnowledgeBase { get; set; } = new KnowledgeBase();
        private string KnowledgeBaseFilePath { get; set; } = string.Empty;
        
        public MainForm()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------
        // ToolStrip
        //----------------------------------------------------------------

        private void newToolStrip_Click(object sender, EventArgs e)
        {
            KnowledgeBase = new KnowledgeBase();
            KnowledgeBaseFilePath = string.Empty;
            
            // Set to rerender tab
            tabControl.SelectedIndex = 1; 
            tabControl.SelectedIndex = 0; 
            
            // TODO (?) clear consulting form 
        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new System.Windows.Forms.OpenFileDialog()
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
            var knowledgeBaseJson = File.ReadAllText(KnowledgeBaseFilePath);
            var deserializedKnowledgeBase = JsonConvert.DeserializeObject<KnowledgeBase>(
                knowledgeBaseJson,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            if (deserializedKnowledgeBase is null)
            {
                MessageBox.Show("Не удалось открыть файл базы знаний");
                return;
            }

            KnowledgeBase = deserializedKnowledgeBase;
            tabControl.Visible = true;
            
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
            
            SaveKnowledgeBase(knowledgeBaseFilePath, KnowledgeBase);
            KnowledgeBaseFilePath = knowledgeBaseFilePath;
        }

        private void saveAsToolStrip_Click(object sender, EventArgs e)
        {
            string knowledgeBaseFilePath = SelectSaveFolder();
            if (string.IsNullOrWhiteSpace(knowledgeBaseFilePath))
                return;
            
            SaveKnowledgeBase(knowledgeBaseFilePath, KnowledgeBase);
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

        private static void SaveKnowledgeBase(string path, KnowledgeBase knowledgeBase)
        {
            // TODO bin save
            string knowledgeBaseJson = JsonConvert.SerializeObject(knowledgeBase, Formatting.Indented, 
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            File.WriteAllText(path, knowledgeBaseJson);
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