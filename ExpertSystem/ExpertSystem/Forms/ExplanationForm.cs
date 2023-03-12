using System.Collections.Immutable;
using ExpertSystemShellDomain;
using ExpertSystemShellDomain.Entities;
using Rule = ExpertSystemShellDomain.Entities.Rule;

namespace ExpertSystem.Forms
{
    public partial class ExplanationForm : Form
    {
        private readonly WorkingMemory _workingMemory;
        private readonly ToolStripButton _showAllButton;
        private bool _isExpanded;
        public ExplanationForm(WorkingMemory workingMemory)
        {
            _workingMemory = workingMemory;
            _isExpanded = false;
            
            InitializeComponent();
            this.Text = "Объяснение";
            menuStripLeft.Items.Clear();
            menuStripLeft.Items.Add(new ToolStripLabel("Правила"));

            _showAllButton = new ToolStripButton("Показать все");
            _showAllButton.Click += ShowAllButton_Click;
            menuStripLeft.Items.Add(_showAllButton);

            menuStripRight.Items.Clear();
            menuStripRight.Items.Add(new ToolStripLabel("Переменные"));
            menuStripRight.Items.Add(new ToolStripButton("ㅤ") { Alignment = ToolStripItemAlignment.Right});

            treeView.AfterSelect += (sender, args) =>
            {
                if (treeView.SelectedNode.Tag is not Variable variable)
                    return;

                foreach (ListViewItem row in listView.Items)
                {
                    row.BackColor = Color.White;
                    var rowVariable = row.Tag as Variable;
                    if (rowVariable == variable)
                    {
                        row.BackColor = Color.IndianRed;
                    }
                }
            };

            foreach (var (variable, variableValue) in _workingMemory.VariableValues)
            {
                var row = listView.Items.Add(variable.Name);
                row.SubItems.Add(variableValue.Value);
                row.Tag = variable;
            }
            
            if (_workingMemory.TargetVariable is null)
            {
                MessageBox.Show("Консультация еще не была проведена!");
                return;
            }

            var firedRules = new HashSet<Rule>(_workingMemory.FiredRules);
            try
            {
                treeView.Nodes.Add(FillTreeView(_workingMemory.TargetVariable!, firedRules));
            }
            catch (Exception e)
            {
                MessageBox.Show("Не удалось построить дерево вывода");
            }
        }

        private static TreeNode FillTreeView(Variable targetVariable, HashSet<Rule> firedRules)
        {
            var rule = firedRules.First(r => r.Conclusions.Any(c => c.Variable == targetVariable));
            firedRules.Remove(rule);
            
            var treeNode = new TreeNode($"({rule.Name}) {rule.Description}");
            treeNode.Tag = targetVariable;

            foreach (var premise in rule.Premises)
            {
                TreeNode node;
                if (premise.Variable.VariableType == VarType.Requested)
                {
                    node = new TreeNode(premise.ToString());
                    node.Tag = premise.Variable;
                }
                else
                {
                    node = FillTreeView(premise.Variable, firedRules);
                    node.Tag = premise.Variable;
                }
                treeNode.Nodes.Add(node);
            }

            return treeNode;
        }
        
        private void ShowAllButton_Click(object? sender, EventArgs e)
        {
            if (!_isExpanded)
            {
                treeView.ExpandAll();
                _showAllButton.Text = "Скрыть дерево";
            }
            else
            {
                treeView.CollapseAll();
                _showAllButton.Text = "Показать все";
            }
            
            _isExpanded = !_isExpanded;
        }
    }
}
