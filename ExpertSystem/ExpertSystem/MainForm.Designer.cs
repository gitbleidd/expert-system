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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.rulesPage = new System.Windows.Forms.TabPage();
            this.panelForDgv = new System.Windows.Forms.Panel();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.RuleNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RulesPanel = new System.Windows.Forms.Panel();
            this.groupBoxConclusion = new System.Windows.Forms.GroupBox();
            this.conclusionListBox = new System.Windows.Forms.ListBox();
            this.groupBoxPremise = new System.Windows.Forms.GroupBox();
            this.premiseListBox = new System.Windows.Forms.ListBox();
            this.groupBoxEditRule = new System.Windows.Forms.GroupBox();
            this.deleteRuleButton = new System.Windows.Forms.Button();
            this.editRuleButton = new System.Windows.Forms.Button();
            this.addRuleButton = new System.Windows.Forms.Button();
            this.variablesPage = new System.Windows.Forms.TabPage();
            this.domensPage = new System.Windows.Forms.TabPage();
            this.mainMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.rulesPage.SuspendLayout();
            this.panelForDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.RulesPanel.SuspendLayout();
            this.groupBoxConclusion.SuspendLayout();
            this.groupBoxPremise.SuspendLayout();
            this.groupBoxEditRule.SuspendLayout();
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.rulesPage);
            this.tabControl.Controls.Add(this.variablesPage);
            this.tabControl.Controls.Add(this.domensPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1003, 537);
            this.tabControl.TabIndex = 1;
            // 
            // rulesPage
            // 
            this.rulesPage.Controls.Add(this.panelForDgv);
            this.rulesPage.Controls.Add(this.RulesPanel);
            this.rulesPage.Location = new System.Drawing.Point(4, 24);
            this.rulesPage.Name = "rulesPage";
            this.rulesPage.Padding = new System.Windows.Forms.Padding(3);
            this.rulesPage.Size = new System.Drawing.Size(995, 509);
            this.rulesPage.TabIndex = 0;
            this.rulesPage.Text = "Правила";
            this.rulesPage.UseVisualStyleBackColor = true;
            // 
            // panelForDgv
            // 
            this.panelForDgv.Controls.Add(this.dgvRules);
            this.panelForDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForDgv.Location = new System.Drawing.Point(3, 3);
            this.panelForDgv.Name = "panelForDgv";
            this.panelForDgv.Size = new System.Drawing.Size(654, 503);
            this.panelForDgv.TabIndex = 4;
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
            // RulesPanel
            // 
            this.RulesPanel.Controls.Add(this.groupBoxConclusion);
            this.RulesPanel.Controls.Add(this.groupBoxPremise);
            this.RulesPanel.Controls.Add(this.groupBoxEditRule);
            this.RulesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RulesPanel.Location = new System.Drawing.Point(657, 3);
            this.RulesPanel.Name = "RulesPanel";
            this.RulesPanel.Padding = new System.Windows.Forms.Padding(10);
            this.RulesPanel.Size = new System.Drawing.Size(335, 503);
            this.RulesPanel.TabIndex = 3;
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
            // variablesPage
            // 
            this.variablesPage.Location = new System.Drawing.Point(4, 24);
            this.variablesPage.Name = "variablesPage";
            this.variablesPage.Padding = new System.Windows.Forms.Padding(3);
            this.variablesPage.Size = new System.Drawing.Size(995, 509);
            this.variablesPage.TabIndex = 1;
            this.variablesPage.Text = "Переменные";
            this.variablesPage.UseVisualStyleBackColor = true;
            // 
            // domensPage
            // 
            this.domensPage.Location = new System.Drawing.Point(4, 24);
            this.domensPage.Name = "domensPage";
            this.domensPage.Padding = new System.Windows.Forms.Padding(3);
            this.domensPage.Size = new System.Drawing.Size(995, 509);
            this.domensPage.TabIndex = 2;
            this.domensPage.Text = "Домены";
            this.domensPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 561);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.rulesPage.ResumeLayout(false);
            this.panelForDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.RulesPanel.ResumeLayout(false);
            this.groupBoxConclusion.ResumeLayout(false);
            this.groupBoxPremise.ResumeLayout(false);
            this.groupBoxEditRule.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenuStrip;
        private TabControl tabControl;
        private TabPage variablesPage;
        private TabPage domensPage;
        private ToolStripMenuItem toolStripFile;
        private ToolStripMenuItem toolStripConsult;
        private ToolStripMenuItem newToolStrip;
        private ToolStripMenuItem openToolStrip;
        private ToolStripMenuItem saveToolStrip;
        private ToolStripMenuItem saveAsToolStrip;
        private ToolStripMenuItem beginConsultToolStrip;
        private ToolStripMenuItem explainToolStrip;
        private TabPage rulesPage;
        private Panel RulesPanel;
        private GroupBox groupBoxConclusion;
        private GroupBox groupBoxPremise;
        private GroupBox groupBoxEditRule;
        private Button deleteRuleButton;
        private Button editRuleButton;
        private Button addRuleButton;
        private ListBox conclusionListBox;
        private ListBox premiseListBox;
        private Panel panelForDgv;
        private DataGridView dgvRules;
        private DataGridViewTextBoxColumn RuleNameColumn;
        private DataGridViewTextBoxColumn RuleDescriptionColumn;
    }
}