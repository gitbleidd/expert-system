namespace ExpertSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addRuleButton_Click(object sender, EventArgs e)
        {
            var ruleEditorForm = new RuleEditorForm();
            ruleEditorForm.ShowDialog();
        }
    }
}