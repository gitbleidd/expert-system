namespace ExpertSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripConsult = new System.Windows.Forms.ToolStripMenuItem();
            this.beginConsultToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.explainToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.variablesTab = new System.Windows.Forms.TabControl();
            this.rulesPage = new System.Windows.Forms.TabPage();
            this.dgvRulesPanel = new System.Windows.Forms.Panel();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.RuleNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rulesPanel = new System.Windows.Forms.Panel();
            this.groupBoxConclusion = new System.Windows.Forms.GroupBox();
            this.conclusionListBox = new System.Windows.Forms.ListBox();
            this.groupBoxPremise = new System.Windows.Forms.GroupBox();
            this.premiseListBox = new System.Windows.Forms.ListBox();
            this.groupBoxEditRule = new System.Windows.Forms.GroupBox();
            this.deleteRuleButton = new System.Windows.Forms.Button();
            this.editRuleButton = new System.Windows.Forms.Button();
            this.addRuleButton = new System.Windows.Forms.Button();
            this.variablesTabPage = new System.Windows.Forms.TabPage();
            this.dgvVariablesPanel = new System.Windows.Forms.Panel();
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.VariableNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableDomainColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variableEditPanel = new System.Windows.Forms.Panel();
            this.ruleDomainValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.ruleDomainValuesListBox = new System.Windows.Forms.ListBox();
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.variableEditGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteVariableButton = new System.Windows.Forms.Button();
            this.editVariableButton = new System.Windows.Forms.Button();
            this.addVariableButton = new System.Windows.Forms.Button();
            this.domainTabPage = new System.Windows.Forms.TabPage();
            this.dgvDomainsPanel = new System.Windows.Forms.Panel();
            this.dgvDomains = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainsRightPanel = new System.Windows.Forms.Panel();
            this.domainValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.domainValuesListBox = new System.Windows.Forms.ListBox();
            this.domainInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editDomainGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteDomainButton = new System.Windows.Forms.Button();
            this.editDomainButton = new System.Windows.Forms.Button();
            this.addDomainButton = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.variablesTab.SuspendLayout();
            this.rulesPage.SuspendLayout();
            this.dgvRulesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.rulesPanel.SuspendLayout();
            this.groupBoxConclusion.SuspendLayout();
            this.groupBoxPremise.SuspendLayout();
            this.groupBoxEditRule.SuspendLayout();
            this.variablesTabPage.SuspendLayout();
            this.dgvVariablesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).BeginInit();
            this.variableEditPanel.SuspendLayout();
            this.ruleDomainValuesGroupBox.SuspendLayout();
            this.questionGroupBox.SuspendLayout();
            this.variableEditGroupBox.SuspendLayout();
            this.domainTabPage.SuspendLayout();
            this.dgvDomainsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomains)).BeginInit();
            this.domainsRightPanel.SuspendLayout();
            this.domainValuesGroupBox.SuspendLayout();
            this.domainInfoGroupBox.SuspendLayout();
            this.editDomainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.toolStripConsult});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1003, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // toolStripFile
            // 
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStrip,
            this.openToolStrip,
            this.saveToolStrip,
            this.saveAsToolStrip});
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(48, 20);
            this.toolStripFile.Text = "Файл";
            // 
            // newToolStrip
            // 
            this.newToolStrip.Name = "newToolStrip";
            this.newToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStrip.Size = new System.Drawing.Size(235, 22);
            this.newToolStrip.Text = "Новый...";
            // 
            // openToolStrip
            // 
            this.openToolStrip.Name = "openToolStrip";
            this.openToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStrip.Size = new System.Drawing.Size(235, 22);
            this.openToolStrip.Text = "Открыть...";
            // 
            // saveToolStrip
            // 
            this.saveToolStrip.Name = "saveToolStrip";
            this.saveToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStrip.Size = new System.Drawing.Size(235, 22);
            this.saveToolStrip.Text = "Сохранить";
            // 
            // saveAsToolStrip
            // 
            this.saveAsToolStrip.Name = "saveAsToolStrip";
            this.saveAsToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStrip.Size = new System.Drawing.Size(235, 22);
            this.saveAsToolStrip.Text = "Сохранить как...";
            // 
            // toolStripConsult
            // 
            this.toolStripConsult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginConsultToolStrip,
            this.explainToolStrip});
            this.toolStripConsult.Name = "toolStripConsult";
            this.toolStripConsult.Size = new System.Drawing.Size(96, 20);
            this.toolStripConsult.Text = "Консультация";
            // 
            // beginConsultToolStrip
            // 
            this.beginConsultToolStrip.Name = "beginConsultToolStrip";
            this.beginConsultToolStrip.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.beginConsultToolStrip.Size = new System.Drawing.Size(228, 22);
            this.beginConsultToolStrip.Text = "Начать консультацию";
            // 
            // explainToolStrip
            // 
            this.explainToolStrip.Name = "explainToolStrip";
            this.explainToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.explainToolStrip.Size = new System.Drawing.Size(228, 22);
            this.explainToolStrip.Text = "Покать объяснение";
            // 
            // variablesTab
            // 
            this.variablesTab.Controls.Add(this.rulesPage);
            this.variablesTab.Controls.Add(this.variablesTabPage);
            this.variablesTab.Controls.Add(this.domainTabPage);
            this.variablesTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variablesTab.Location = new System.Drawing.Point(0, 24);
            this.variablesTab.Name = "variablesTab";
            this.variablesTab.SelectedIndex = 0;
            this.variablesTab.Size = new System.Drawing.Size(1003, 537);
            this.variablesTab.TabIndex = 1;
            // 
            // rulesPage
            // 
            this.rulesPage.Controls.Add(this.dgvRulesPanel);
            this.rulesPage.Controls.Add(this.rulesPanel);
            this.rulesPage.Location = new System.Drawing.Point(4, 24);
            this.rulesPage.Name = "rulesPage";
            this.rulesPage.Padding = new System.Windows.Forms.Padding(3);
            this.rulesPage.Size = new System.Drawing.Size(995, 509);
            this.rulesPage.TabIndex = 0;
            this.rulesPage.Text = "Правила";
            this.rulesPage.UseVisualStyleBackColor = true;
            // 
            // dgvRulesPanel
            // 
            this.dgvRulesPanel.Controls.Add(this.dgvRules);
            this.dgvRulesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRulesPanel.Location = new System.Drawing.Point(3, 3);
            this.dgvRulesPanel.Name = "dgvRulesPanel";
            this.dgvRulesPanel.Size = new System.Drawing.Size(654, 503);
            this.dgvRulesPanel.TabIndex = 4;
            // 
            // dgvRules
            // 
            this.dgvRules.AllowDrop = true;
            this.dgvRules.AllowUserToAddRows = false;
            this.dgvRules.AllowUserToDeleteRows = false;
            this.dgvRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RuleNameColumn,
            this.RuleDescriptionColumn});
            this.dgvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRules.Location = new System.Drawing.Point(0, 0);
            this.dgvRules.MultiSelect = false;
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.ReadOnly = true;
            this.dgvRules.RowHeadersVisible = false;
            this.dgvRules.RowTemplate.Height = 25;
            this.dgvRules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRules.Size = new System.Drawing.Size(654, 503);
            this.dgvRules.TabIndex = 3;
            this.dgvRules.SelectionChanged += new System.EventHandler(this.dgvRules_SelectionChanged);
            this.dgvRules.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvRules_DragDrop);
            this.dgvRules.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvRules_DragEnter);
            this.dgvRules.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvRules_MouseMove);
            // 
            // RuleNameColumn
            // 
            this.RuleNameColumn.FillWeight = 30F;
            this.RuleNameColumn.HeaderText = "Имя";
            this.RuleNameColumn.Name = "RuleNameColumn";
            this.RuleNameColumn.ReadOnly = true;
            // 
            // RuleDescriptionColumn
            // 
            this.RuleDescriptionColumn.FillWeight = 200F;
            this.RuleDescriptionColumn.HeaderText = "Описание";
            this.RuleDescriptionColumn.Name = "RuleDescriptionColumn";
            this.RuleDescriptionColumn.ReadOnly = true;
            // 
            // rulesPanel
            // 
            this.rulesPanel.Controls.Add(this.groupBoxConclusion);
            this.rulesPanel.Controls.Add(this.groupBoxPremise);
            this.rulesPanel.Controls.Add(this.groupBoxEditRule);
            this.rulesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rulesPanel.Location = new System.Drawing.Point(657, 3);
            this.rulesPanel.Name = "rulesPanel";
            this.rulesPanel.Padding = new System.Windows.Forms.Padding(10);
            this.rulesPanel.Size = new System.Drawing.Size(335, 503);
            this.rulesPanel.TabIndex = 3;
            // 
            // groupBoxConclusion
            // 
            this.groupBoxConclusion.Controls.Add(this.conclusionListBox);
            this.groupBoxConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxConclusion.Location = new System.Drawing.Point(10, 380);
            this.groupBoxConclusion.Name = "groupBoxConclusion";
            this.groupBoxConclusion.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.groupBoxConclusion.Size = new System.Drawing.Size(315, 113);
            this.groupBoxConclusion.TabIndex = 2;
            this.groupBoxConclusion.TabStop = false;
            this.groupBoxConclusion.Text = "Заключение";
            // 
            // conclusionListBox
            // 
            this.conclusionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conclusionListBox.FormattingEnabled = true;
            this.conclusionListBox.ItemHeight = 15;
            this.conclusionListBox.Location = new System.Drawing.Point(8, 19);
            this.conclusionListBox.Name = "conclusionListBox";
            this.conclusionListBox.Size = new System.Drawing.Size(299, 91);
            this.conclusionListBox.TabIndex = 0;
            // 
            // groupBoxPremise
            // 
            this.groupBoxPremise.Controls.Add(this.premiseListBox);
            this.groupBoxPremise.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPremise.Location = new System.Drawing.Point(10, 108);
            this.groupBoxPremise.Name = "groupBoxPremise";
            this.groupBoxPremise.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.groupBoxPremise.Size = new System.Drawing.Size(315, 272);
            this.groupBoxPremise.TabIndex = 1;
            this.groupBoxPremise.TabStop = false;
            this.groupBoxPremise.Text = "Посылка";
            // 
            // premiseListBox
            // 
            this.premiseListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.premiseListBox.FormattingEnabled = true;
            this.premiseListBox.ItemHeight = 15;
            this.premiseListBox.Location = new System.Drawing.Point(8, 19);
            this.premiseListBox.Name = "premiseListBox";
            this.premiseListBox.Size = new System.Drawing.Size(299, 250);
            this.premiseListBox.TabIndex = 0;
            // 
            // groupBoxEditRule
            // 
            this.groupBoxEditRule.Controls.Add(this.deleteRuleButton);
            this.groupBoxEditRule.Controls.Add(this.editRuleButton);
            this.groupBoxEditRule.Controls.Add(this.addRuleButton);
            this.groupBoxEditRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditRule.Location = new System.Drawing.Point(10, 10);
            this.groupBoxEditRule.Name = "groupBoxEditRule";
            this.groupBoxEditRule.Size = new System.Drawing.Size(315, 98);
            this.groupBoxEditRule.TabIndex = 0;
            this.groupBoxEditRule.TabStop = false;
            this.groupBoxEditRule.Text = "Редактирование";
            // 
            // deleteRuleButton
            // 
            this.deleteRuleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteRuleButton.Enabled = false;
            this.deleteRuleButton.Location = new System.Drawing.Point(3, 65);
            this.deleteRuleButton.Name = "deleteRuleButton";
            this.deleteRuleButton.Size = new System.Drawing.Size(309, 23);
            this.deleteRuleButton.TabIndex = 2;
            this.deleteRuleButton.Text = "Удалить";
            this.deleteRuleButton.UseVisualStyleBackColor = true;
            this.deleteRuleButton.Click += new System.EventHandler(this.deleteRuleButton_Click);
            // 
            // editRuleButton
            // 
            this.editRuleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editRuleButton.Enabled = false;
            this.editRuleButton.Location = new System.Drawing.Point(3, 42);
            this.editRuleButton.Name = "editRuleButton";
            this.editRuleButton.Size = new System.Drawing.Size(309, 23);
            this.editRuleButton.TabIndex = 1;
            this.editRuleButton.Text = "Изменить";
            this.editRuleButton.UseVisualStyleBackColor = true;
            this.editRuleButton.Click += new System.EventHandler(this.editRuleButton_Click);
            // 
            // addRuleButton
            // 
            this.addRuleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRuleButton.Location = new System.Drawing.Point(3, 19);
            this.addRuleButton.Name = "addRuleButton";
            this.addRuleButton.Size = new System.Drawing.Size(309, 23);
            this.addRuleButton.TabIndex = 0;
            this.addRuleButton.Text = "Добавить";
            this.addRuleButton.UseVisualStyleBackColor = true;
            this.addRuleButton.Click += new System.EventHandler(this.addRuleButton_Click);
            // 
            // variablesTabPage
            // 
            this.variablesTabPage.Controls.Add(this.dgvVariablesPanel);
            this.variablesTabPage.Controls.Add(this.variableEditPanel);
            this.variablesTabPage.Location = new System.Drawing.Point(4, 24);
            this.variablesTabPage.Name = "variablesTabPage";
            this.variablesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.variablesTabPage.Size = new System.Drawing.Size(995, 509);
            this.variablesTabPage.TabIndex = 3;
            this.variablesTabPage.Text = "Переменные";
            this.variablesTabPage.UseVisualStyleBackColor = true;
            // 
            // dgvVariablesPanel
            // 
            this.dgvVariablesPanel.Controls.Add(this.dgvVariables);
            this.dgvVariablesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVariablesPanel.Location = new System.Drawing.Point(3, 3);
            this.dgvVariablesPanel.Name = "dgvVariablesPanel";
            this.dgvVariablesPanel.Size = new System.Drawing.Size(654, 503);
            this.dgvVariablesPanel.TabIndex = 4;
            // 
            // dgvVariables
            // 
            this.dgvVariables.AllowDrop = true;
            this.dgvVariables.AllowUserToAddRows = false;
            this.dgvVariables.AllowUserToDeleteRows = false;
            this.dgvVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VariableNameColumn,
            this.VariableTypeColumn,
            this.VariableDomainColumn});
            this.dgvVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVariables.Location = new System.Drawing.Point(0, 0);
            this.dgvVariables.MultiSelect = false;
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.ReadOnly = true;
            this.dgvVariables.RowHeadersVisible = false;
            this.dgvVariables.RowTemplate.Height = 25;
            this.dgvVariables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVariables.Size = new System.Drawing.Size(654, 503);
            this.dgvVariables.TabIndex = 3;
            this.dgvVariables.SelectionChanged += new System.EventHandler(this.dgvVariables_SelectionChanged);
            // 
            // VariableNameColumn
            // 
            this.VariableNameColumn.HeaderText = "Имя";
            this.VariableNameColumn.Name = "VariableNameColumn";
            this.VariableNameColumn.ReadOnly = true;
            // 
            // VariableTypeColumn
            // 
            this.VariableTypeColumn.FillWeight = 60F;
            this.VariableTypeColumn.HeaderText = "Тип";
            this.VariableTypeColumn.Name = "VariableTypeColumn";
            this.VariableTypeColumn.ReadOnly = true;
            // 
            // VariableDomainColumn
            // 
            this.VariableDomainColumn.HeaderText = "Домен";
            this.VariableDomainColumn.Name = "VariableDomainColumn";
            this.VariableDomainColumn.ReadOnly = true;
            // 
            // variableEditPanel
            // 
            this.variableEditPanel.Controls.Add(this.ruleDomainValuesGroupBox);
            this.variableEditPanel.Controls.Add(this.questionGroupBox);
            this.variableEditPanel.Controls.Add(this.variableEditGroupBox);
            this.variableEditPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.variableEditPanel.Location = new System.Drawing.Point(657, 3);
            this.variableEditPanel.Name = "variableEditPanel";
            this.variableEditPanel.Padding = new System.Windows.Forms.Padding(10);
            this.variableEditPanel.Size = new System.Drawing.Size(335, 503);
            this.variableEditPanel.TabIndex = 3;
            // 
            // ruleDomainValuesGroupBox
            // 
            this.ruleDomainValuesGroupBox.Controls.Add(this.ruleDomainValuesListBox);
            this.ruleDomainValuesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleDomainValuesGroupBox.Location = new System.Drawing.Point(10, 242);
            this.ruleDomainValuesGroupBox.Name = "ruleDomainValuesGroupBox";
            this.ruleDomainValuesGroupBox.Padding = new System.Windows.Forms.Padding(8, 3, 8, 6);
            this.ruleDomainValuesGroupBox.Size = new System.Drawing.Size(315, 251);
            this.ruleDomainValuesGroupBox.TabIndex = 2;
            this.ruleDomainValuesGroupBox.TabStop = false;
            this.ruleDomainValuesGroupBox.Text = "Значения домена";
            // 
            // ruleDomainValuesListBox
            // 
            this.ruleDomainValuesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleDomainValuesListBox.FormattingEnabled = true;
            this.ruleDomainValuesListBox.ItemHeight = 15;
            this.ruleDomainValuesListBox.Location = new System.Drawing.Point(8, 19);
            this.ruleDomainValuesListBox.Name = "ruleDomainValuesListBox";
            this.ruleDomainValuesListBox.Size = new System.Drawing.Size(299, 226);
            this.ruleDomainValuesListBox.TabIndex = 0;
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.Controls.Add(this.questionTextBox);
            this.questionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionGroupBox.Location = new System.Drawing.Point(10, 108);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Padding = new System.Windows.Forms.Padding(8, 3, 8, 6);
            this.questionGroupBox.Size = new System.Drawing.Size(315, 134);
            this.questionGroupBox.TabIndex = 1;
            this.questionGroupBox.TabStop = false;
            this.questionGroupBox.Text = "Текст вопроса";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionTextBox.Location = new System.Drawing.Point(8, 19);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(299, 109);
            this.questionTextBox.TabIndex = 0;
            // 
            // variableEditGroupBox
            // 
            this.variableEditGroupBox.Controls.Add(this.deleteVariableButton);
            this.variableEditGroupBox.Controls.Add(this.editVariableButton);
            this.variableEditGroupBox.Controls.Add(this.addVariableButton);
            this.variableEditGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.variableEditGroupBox.Location = new System.Drawing.Point(10, 10);
            this.variableEditGroupBox.Name = "variableEditGroupBox";
            this.variableEditGroupBox.Size = new System.Drawing.Size(315, 98);
            this.variableEditGroupBox.TabIndex = 0;
            this.variableEditGroupBox.TabStop = false;
            this.variableEditGroupBox.Text = "Редактирование";
            // 
            // deleteVariableButton
            // 
            this.deleteVariableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteVariableButton.Enabled = false;
            this.deleteVariableButton.Location = new System.Drawing.Point(3, 65);
            this.deleteVariableButton.Name = "deleteVariableButton";
            this.deleteVariableButton.Size = new System.Drawing.Size(309, 23);
            this.deleteVariableButton.TabIndex = 2;
            this.deleteVariableButton.Text = "Удалить";
            this.deleteVariableButton.UseVisualStyleBackColor = true;
            this.deleteVariableButton.Click += new System.EventHandler(this.deleteVariableButton_Click);
            // 
            // editVariableButton
            // 
            this.editVariableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editVariableButton.Enabled = false;
            this.editVariableButton.Location = new System.Drawing.Point(3, 42);
            this.editVariableButton.Name = "editVariableButton";
            this.editVariableButton.Size = new System.Drawing.Size(309, 23);
            this.editVariableButton.TabIndex = 1;
            this.editVariableButton.Text = "Изменить";
            this.editVariableButton.UseVisualStyleBackColor = true;
            this.editVariableButton.Click += new System.EventHandler(this.editVariableButton_Click);
            // 
            // addVariableButton
            // 
            this.addVariableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addVariableButton.Location = new System.Drawing.Point(3, 19);
            this.addVariableButton.Name = "addVariableButton";
            this.addVariableButton.Size = new System.Drawing.Size(309, 23);
            this.addVariableButton.TabIndex = 0;
            this.addVariableButton.Text = "Добавить";
            this.addVariableButton.UseVisualStyleBackColor = true;
            this.addVariableButton.Click += new System.EventHandler(this.addVariableButton_Click);
            // 
            // domainTabPage
            // 
            this.domainTabPage.Controls.Add(this.dgvDomainsPanel);
            this.domainTabPage.Controls.Add(this.domainsRightPanel);
            this.domainTabPage.Location = new System.Drawing.Point(4, 24);
            this.domainTabPage.Name = "domainTabPage";
            this.domainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.domainTabPage.Size = new System.Drawing.Size(995, 509);
            this.domainTabPage.TabIndex = 4;
            this.domainTabPage.Text = "Домены";
            this.domainTabPage.UseVisualStyleBackColor = true;
            // 
            // dgvDomainsPanel
            // 
            this.dgvDomainsPanel.Controls.Add(this.dgvDomains);
            this.dgvDomainsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDomainsPanel.Location = new System.Drawing.Point(3, 3);
            this.dgvDomainsPanel.Name = "dgvDomainsPanel";
            this.dgvDomainsPanel.Size = new System.Drawing.Size(654, 503);
            this.dgvDomainsPanel.TabIndex = 4;
            // 
            // dgvDomains
            // 
            this.dgvDomains.AllowDrop = true;
            this.dgvDomains.AllowUserToAddRows = false;
            this.dgvDomains.AllowUserToDeleteRows = false;
            this.dgvDomains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDomains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDomains.Location = new System.Drawing.Point(0, 0);
            this.dgvDomains.MultiSelect = false;
            this.dgvDomains.Name = "dgvDomains";
            this.dgvDomains.ReadOnly = true;
            this.dgvDomains.RowHeadersVisible = false;
            this.dgvDomains.RowTemplate.Height = 25;
            this.dgvDomains.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDomains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDomains.Size = new System.Drawing.Size(654, 503);
            this.dgvDomains.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // domainsRightPanel
            // 
            this.domainsRightPanel.Controls.Add(this.domainValuesGroupBox);
            this.domainsRightPanel.Controls.Add(this.domainInfoGroupBox);
            this.domainsRightPanel.Controls.Add(this.editDomainGroupBox);
            this.domainsRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.domainsRightPanel.Location = new System.Drawing.Point(657, 3);
            this.domainsRightPanel.Name = "domainsRightPanel";
            this.domainsRightPanel.Padding = new System.Windows.Forms.Padding(10);
            this.domainsRightPanel.Size = new System.Drawing.Size(335, 503);
            this.domainsRightPanel.TabIndex = 3;
            // 
            // domainValuesGroupBox
            // 
            this.domainValuesGroupBox.Controls.Add(this.domainValuesListBox);
            this.domainValuesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.domainValuesGroupBox.Location = new System.Drawing.Point(10, 242);
            this.domainValuesGroupBox.Name = "domainValuesGroupBox";
            this.domainValuesGroupBox.Padding = new System.Windows.Forms.Padding(8, 3, 8, 6);
            this.domainValuesGroupBox.Size = new System.Drawing.Size(315, 251);
            this.domainValuesGroupBox.TabIndex = 2;
            this.domainValuesGroupBox.TabStop = false;
            this.domainValuesGroupBox.Text = "Значения домена";
            // 
            // domainValuesListBox
            // 
            this.domainValuesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.domainValuesListBox.FormattingEnabled = true;
            this.domainValuesListBox.ItemHeight = 15;
            this.domainValuesListBox.Location = new System.Drawing.Point(8, 19);
            this.domainValuesListBox.Name = "domainValuesListBox";
            this.domainValuesListBox.Size = new System.Drawing.Size(299, 226);
            this.domainValuesListBox.TabIndex = 0;
            // 
            // domainInfoGroupBox
            // 
            this.domainInfoGroupBox.Controls.Add(this.textBox1);
            this.domainInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.domainInfoGroupBox.Location = new System.Drawing.Point(10, 108);
            this.domainInfoGroupBox.Name = "domainInfoGroupBox";
            this.domainInfoGroupBox.Padding = new System.Windows.Forms.Padding(8, 3, 8, 6);
            this.domainInfoGroupBox.Size = new System.Drawing.Size(315, 134);
            this.domainInfoGroupBox.TabIndex = 1;
            this.domainInfoGroupBox.TabStop = false;
            this.domainInfoGroupBox.Text = "??";
            this.domainInfoGroupBox.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(8, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 109);
            this.textBox1.TabIndex = 0;
            // 
            // editDomainGroupBox
            // 
            this.editDomainGroupBox.Controls.Add(this.deleteDomainButton);
            this.editDomainGroupBox.Controls.Add(this.editDomainButton);
            this.editDomainGroupBox.Controls.Add(this.addDomainButton);
            this.editDomainGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.editDomainGroupBox.Location = new System.Drawing.Point(10, 10);
            this.editDomainGroupBox.Name = "editDomainGroupBox";
            this.editDomainGroupBox.Size = new System.Drawing.Size(315, 98);
            this.editDomainGroupBox.TabIndex = 0;
            this.editDomainGroupBox.TabStop = false;
            this.editDomainGroupBox.Text = "Редактирование";
            // 
            // deleteDomainButton
            // 
            this.deleteDomainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteDomainButton.Enabled = false;
            this.deleteDomainButton.Location = new System.Drawing.Point(3, 65);
            this.deleteDomainButton.Name = "deleteDomainButton";
            this.deleteDomainButton.Size = new System.Drawing.Size(309, 23);
            this.deleteDomainButton.TabIndex = 2;
            this.deleteDomainButton.Text = "Удалить";
            this.deleteDomainButton.UseVisualStyleBackColor = true;
            this.deleteDomainButton.Click += new System.EventHandler(this.deleteDomainButton_Click);
            // 
            // editDomainButton
            // 
            this.editDomainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editDomainButton.Enabled = false;
            this.editDomainButton.Location = new System.Drawing.Point(3, 42);
            this.editDomainButton.Name = "editDomainButton";
            this.editDomainButton.Size = new System.Drawing.Size(309, 23);
            this.editDomainButton.TabIndex = 1;
            this.editDomainButton.Text = "Изменить";
            this.editDomainButton.UseVisualStyleBackColor = true;
            this.editDomainButton.Click += new System.EventHandler(this.editDomainButton_Click);
            // 
            // addDomainButton
            // 
            this.addDomainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addDomainButton.Location = new System.Drawing.Point(3, 19);
            this.addDomainButton.Name = "addDomainButton";
            this.addDomainButton.Size = new System.Drawing.Size(309, 23);
            this.addDomainButton.TabIndex = 0;
            this.addDomainButton.Text = "Добавить";
            this.addDomainButton.UseVisualStyleBackColor = true;
            this.addDomainButton.Click += new System.EventHandler(this.addDomainButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 561);
            this.Controls.Add(this.variablesTab);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.variablesTab.ResumeLayout(false);
            this.rulesPage.ResumeLayout(false);
            this.dgvRulesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.rulesPanel.ResumeLayout(false);
            this.groupBoxConclusion.ResumeLayout(false);
            this.groupBoxPremise.ResumeLayout(false);
            this.groupBoxEditRule.ResumeLayout(false);
            this.variablesTabPage.ResumeLayout(false);
            this.dgvVariablesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).EndInit();
            this.variableEditPanel.ResumeLayout(false);
            this.ruleDomainValuesGroupBox.ResumeLayout(false);
            this.questionGroupBox.ResumeLayout(false);
            this.questionGroupBox.PerformLayout();
            this.variableEditGroupBox.ResumeLayout(false);
            this.domainTabPage.ResumeLayout(false);
            this.dgvDomainsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomains)).EndInit();
            this.domainsRightPanel.ResumeLayout(false);
            this.domainValuesGroupBox.ResumeLayout(false);
            this.domainInfoGroupBox.ResumeLayout(false);
            this.domainInfoGroupBox.PerformLayout();
            this.editDomainGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenuStrip;
        private TabControl variablesTab;
        private ToolStripMenuItem toolStripFile;
        private ToolStripMenuItem toolStripConsult;
        private ToolStripMenuItem newToolStrip;
        private ToolStripMenuItem openToolStrip;
        private ToolStripMenuItem saveToolStrip;
        private ToolStripMenuItem saveAsToolStrip;
        private ToolStripMenuItem beginConsultToolStrip;
        private ToolStripMenuItem explainToolStrip;
        private TabPage rulesPage;
        private Panel rulesPanel;
        private GroupBox groupBoxConclusion;
        private GroupBox groupBoxPremise;
        private GroupBox groupBoxEditRule;
        private Button deleteRuleButton;
        private Button editRuleButton;
        private Button addRuleButton;
        private ListBox conclusionListBox;
        private ListBox premiseListBox;
        private Panel dgvRulesPanel;
        private DataGridView dgvRules;
        private DataGridViewTextBoxColumn RuleNameColumn;
        private DataGridViewTextBoxColumn RuleDescriptionColumn;
        private TabPage variablesTabPage;
        private Panel dgvVariablesPanel;
        private DataGridView dgvVariables;
        private Panel variableEditPanel;
        private GroupBox ruleDomainValuesGroupBox;
        private ListBox ruleDomainValuesListBox;
        private GroupBox questionGroupBox;
        private TextBox questionTextBox;
        private GroupBox variableEditGroupBox;
        private Button deleteVariableButton;
        private Button editVariableButton;
        private Button addVariableButton;
        private DataGridViewTextBoxColumn VariableNameColumn;
        private DataGridViewTextBoxColumn VariableTypeColumn;
        private DataGridViewTextBoxColumn VariableDomainColumn;
        private TabPage domainTabPage;
        private Panel dgvDomainsPanel;
        private DataGridView dgvDomains;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Panel domainsRightPanel;
        private GroupBox domainValuesGroupBox;
        private ListBox domainValuesListBox;
        private GroupBox domainInfoGroupBox;
        private TextBox textBox1;
        private GroupBox editDomainGroupBox;
        private Button deleteDomainButton;
        private Button editDomainButton;
        private Button addDomainButton;
    }
}