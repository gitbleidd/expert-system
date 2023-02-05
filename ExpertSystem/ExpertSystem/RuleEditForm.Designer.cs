namespace ExpertSystem
{
    partial class RuleEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ruleEditorMainPanel = new System.Windows.Forms.Panel();
            this.ruleEditorEditPanel = new System.Windows.Forms.Panel();
            this.ruleEditorPremiseGroupBox = new System.Windows.Forms.GroupBox();
            this.okCancelTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ruleEditorSaveButton = new System.Windows.Forms.Button();
            this.ruleEditorCancelButton = new System.Windows.Forms.Button();
            this.ruleEditorExplanationLabel = new System.Windows.Forms.Label();
            this.ruleEditorExplanationTextBox = new System.Windows.Forms.TextBox();
            this.ruleEditorRuleNameLabel = new System.Windows.Forms.Label();
            this.ruleEditorRuleNameTextBox = new System.Windows.Forms.TextBox();
            this.mainTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.premiseConclusionTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.conclusionGroupBox = new System.Windows.Forms.GroupBox();
            this.conclusionListBox = new System.Windows.Forms.ListBox();
            this.conclusionTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.deleteConclusionButton = new System.Windows.Forms.Button();
            this.editConclusionButton = new System.Windows.Forms.Button();
            this.addConclusionButton = new System.Windows.Forms.Button();
            this.premiseGroupBox = new System.Windows.Forms.GroupBox();
            this.premiseListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.premiseTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.deletePremiseButton = new System.Windows.Forms.Button();
            this.editPremiseButton = new System.Windows.Forms.Button();
            this.addPremiseButton = new System.Windows.Forms.Button();
            this.okCancelTablePanel.SuspendLayout();
            this.mainTablePanel.SuspendLayout();
            this.premiseConclusionTablePanel.SuspendLayout();
            this.conclusionGroupBox.SuspendLayout();
            this.conclusionTablePanel.SuspendLayout();
            this.premiseGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.premiseTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ruleEditorMainPanel
            // 
            this.ruleEditorMainPanel.Location = new System.Drawing.Point(0, 0);
            this.ruleEditorMainPanel.Name = "ruleEditorMainPanel";
            this.ruleEditorMainPanel.Size = new System.Drawing.Size(200, 100);
            this.ruleEditorMainPanel.TabIndex = 0;
            // 
            // ruleEditorEditPanel
            // 
            this.ruleEditorEditPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ruleEditorEditPanel.Location = new System.Drawing.Point(0, 0);
            this.ruleEditorEditPanel.Name = "ruleEditorEditPanel";
            this.ruleEditorEditPanel.Size = new System.Drawing.Size(200, 100);
            this.ruleEditorEditPanel.TabIndex = 0;
            // 
            // ruleEditorPremiseGroupBox
            // 
            this.ruleEditorPremiseGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleEditorPremiseGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ruleEditorPremiseGroupBox.Name = "ruleEditorPremiseGroupBox";
            this.ruleEditorPremiseGroupBox.Size = new System.Drawing.Size(94, 365);
            this.ruleEditorPremiseGroupBox.TabIndex = 2;
            this.ruleEditorPremiseGroupBox.TabStop = false;
            this.ruleEditorPremiseGroupBox.Text = "Посылка";
            // 
            // okCancelTablePanel
            // 
            this.okCancelTablePanel.ColumnCount = 3;
            this.okCancelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.okCancelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.okCancelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.okCancelTablePanel.Controls.Add(this.ruleEditorSaveButton, 1, 0);
            this.okCancelTablePanel.Controls.Add(this.ruleEditorCancelButton, 2, 0);
            this.okCancelTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okCancelTablePanel.Location = new System.Drawing.Point(13, 520);
            this.okCancelTablePanel.Name = "okCancelTablePanel";
            this.okCancelTablePanel.RowCount = 1;
            this.okCancelTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.okCancelTablePanel.Size = new System.Drawing.Size(774, 31);
            this.okCancelTablePanel.TabIndex = 15;
            // 
            // ruleEditorSaveButton
            // 
            this.ruleEditorSaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleEditorSaveButton.Location = new System.Drawing.Point(617, 3);
            this.ruleEditorSaveButton.Name = "ruleEditorSaveButton";
            this.ruleEditorSaveButton.Size = new System.Drawing.Size(74, 25);
            this.ruleEditorSaveButton.TabIndex = 7;
            this.ruleEditorSaveButton.Text = "OK";
            this.ruleEditorSaveButton.UseVisualStyleBackColor = true;
            // 
            // ruleEditorCancelButton
            // 
            this.ruleEditorCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleEditorCancelButton.Location = new System.Drawing.Point(697, 3);
            this.ruleEditorCancelButton.Name = "ruleEditorCancelButton";
            this.ruleEditorCancelButton.Size = new System.Drawing.Size(74, 25);
            this.ruleEditorCancelButton.TabIndex = 10;
            this.ruleEditorCancelButton.Text = "Отмена";
            this.ruleEditorCancelButton.UseVisualStyleBackColor = true;
            // 
            // ruleEditorExplanationLabel
            // 
            this.ruleEditorExplanationLabel.AutoSize = true;
            this.ruleEditorExplanationLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ruleEditorExplanationLabel.Location = new System.Drawing.Point(13, 380);
            this.ruleEditorExplanationLabel.Name = "ruleEditorExplanationLabel";
            this.ruleEditorExplanationLabel.Size = new System.Drawing.Size(774, 15);
            this.ruleEditorExplanationLabel.TabIndex = 10;
            this.ruleEditorExplanationLabel.Text = "Пояснение:";
            // 
            // ruleEditorExplanationTextBox
            // 
            this.ruleEditorExplanationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleEditorExplanationTextBox.Location = new System.Drawing.Point(13, 398);
            this.ruleEditorExplanationTextBox.MinimumSize = new System.Drawing.Size(100, 50);
            this.ruleEditorExplanationTextBox.Multiline = true;
            this.ruleEditorExplanationTextBox.Name = "ruleEditorExplanationTextBox";
            this.ruleEditorExplanationTextBox.Size = new System.Drawing.Size(774, 116);
            this.ruleEditorExplanationTextBox.TabIndex = 12;
            // 
            // ruleEditorRuleNameLabel
            // 
            this.ruleEditorRuleNameLabel.AutoSize = true;
            this.ruleEditorRuleNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ruleEditorRuleNameLabel.Location = new System.Drawing.Point(13, 25);
            this.ruleEditorRuleNameLabel.Name = "ruleEditorRuleNameLabel";
            this.ruleEditorRuleNameLabel.Size = new System.Drawing.Size(774, 15);
            this.ruleEditorRuleNameLabel.TabIndex = 2;
            this.ruleEditorRuleNameLabel.Text = "Имя правила:";
            // 
            // ruleEditorRuleNameTextBox
            // 
            this.ruleEditorRuleNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ruleEditorRuleNameTextBox.Location = new System.Drawing.Point(13, 44);
            this.ruleEditorRuleNameTextBox.Name = "ruleEditorRuleNameTextBox";
            this.ruleEditorRuleNameTextBox.Size = new System.Drawing.Size(774, 23);
            this.ruleEditorRuleNameTextBox.TabIndex = 14;
            // 
            // mainTablePanel
            // 
            this.mainTablePanel.ColumnCount = 1;
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.Controls.Add(this.ruleEditorRuleNameTextBox, 0, 1);
            this.mainTablePanel.Controls.Add(this.ruleEditorRuleNameLabel, 0, 0);
            this.mainTablePanel.Controls.Add(this.ruleEditorExplanationTextBox, 0, 4);
            this.mainTablePanel.Controls.Add(this.premiseConclusionTablePanel, 0, 2);
            this.mainTablePanel.Controls.Add(this.ruleEditorExplanationLabel, 0, 3);
            this.mainTablePanel.Controls.Add(this.okCancelTablePanel, 0, 5);
            this.mainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTablePanel.Location = new System.Drawing.Point(0, 0);
            this.mainTablePanel.Name = "mainTablePanel";
            this.mainTablePanel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.mainTablePanel.RowCount = 6;
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.mainTablePanel.Size = new System.Drawing.Size(800, 564);
            this.mainTablePanel.TabIndex = 0;
            // 
            // premiseConclusionTablePanel
            // 
            this.premiseConclusionTablePanel.ColumnCount = 2;
            this.premiseConclusionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.premiseConclusionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.premiseConclusionTablePanel.Controls.Add(this.conclusionGroupBox, 0, 0);
            this.premiseConclusionTablePanel.Controls.Add(this.premiseGroupBox, 0, 0);
            this.premiseConclusionTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.premiseConclusionTablePanel.Location = new System.Drawing.Point(13, 73);
            this.premiseConclusionTablePanel.Name = "premiseConclusionTablePanel";
            this.premiseConclusionTablePanel.RowCount = 1;
            this.premiseConclusionTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.premiseConclusionTablePanel.Size = new System.Drawing.Size(774, 299);
            this.premiseConclusionTablePanel.TabIndex = 4;
            // 
            // conclusionGroupBox
            // 
            this.conclusionGroupBox.Controls.Add(this.conclusionListBox);
            this.conclusionGroupBox.Controls.Add(this.conclusionTablePanel);
            this.conclusionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conclusionGroupBox.Location = new System.Drawing.Point(390, 3);
            this.conclusionGroupBox.Name = "conclusionGroupBox";
            this.conclusionGroupBox.Size = new System.Drawing.Size(381, 293);
            this.conclusionGroupBox.TabIndex = 1;
            this.conclusionGroupBox.TabStop = false;
            this.conclusionGroupBox.Text = "Заключение";
            // 
            // conclusionListBox
            // 
            this.conclusionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conclusionListBox.FormattingEnabled = true;
            this.conclusionListBox.ItemHeight = 15;
            this.conclusionListBox.Location = new System.Drawing.Point(3, 19);
            this.conclusionListBox.Name = "conclusionListBox";
            this.conclusionListBox.Size = new System.Drawing.Size(375, 239);
            this.conclusionListBox.TabIndex = 5;
            // 
            // conclusionTablePanel
            // 
            this.conclusionTablePanel.ColumnCount = 3;
            this.conclusionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.conclusionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.conclusionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.conclusionTablePanel.Controls.Add(this.deleteConclusionButton, 2, 0);
            this.conclusionTablePanel.Controls.Add(this.editConclusionButton, 1, 0);
            this.conclusionTablePanel.Controls.Add(this.addConclusionButton, 0, 0);
            this.conclusionTablePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.conclusionTablePanel.Location = new System.Drawing.Point(3, 258);
            this.conclusionTablePanel.Name = "conclusionTablePanel";
            this.conclusionTablePanel.RowCount = 1;
            this.conclusionTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.conclusionTablePanel.Size = new System.Drawing.Size(375, 32);
            this.conclusionTablePanel.TabIndex = 4;
            // 
            // deleteConclusionButton
            // 
            this.deleteConclusionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteConclusionButton.Location = new System.Drawing.Point(253, 3);
            this.deleteConclusionButton.Name = "deleteConclusionButton";
            this.deleteConclusionButton.Size = new System.Drawing.Size(119, 26);
            this.deleteConclusionButton.TabIndex = 2;
            this.deleteConclusionButton.Text = "Удалить";
            this.deleteConclusionButton.UseVisualStyleBackColor = true;
            // 
            // editConclusionButton
            // 
            this.editConclusionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editConclusionButton.Location = new System.Drawing.Point(128, 3);
            this.editConclusionButton.Name = "editConclusionButton";
            this.editConclusionButton.Size = new System.Drawing.Size(119, 26);
            this.editConclusionButton.TabIndex = 1;
            this.editConclusionButton.Text = "Изменить";
            this.editConclusionButton.UseVisualStyleBackColor = true;
            // 
            // addConclusionButton
            // 
            this.addConclusionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addConclusionButton.Location = new System.Drawing.Point(3, 3);
            this.addConclusionButton.Name = "addConclusionButton";
            this.addConclusionButton.Size = new System.Drawing.Size(119, 26);
            this.addConclusionButton.TabIndex = 0;
            this.addConclusionButton.Text = "Добавить";
            this.addConclusionButton.UseVisualStyleBackColor = true;
            // 
            // premiseGroupBox
            // 
            this.premiseGroupBox.Controls.Add(this.premiseListBox);
            this.premiseGroupBox.Controls.Add(this.panel3);
            this.premiseGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.premiseGroupBox.Location = new System.Drawing.Point(3, 3);
            this.premiseGroupBox.Name = "premiseGroupBox";
            this.premiseGroupBox.Size = new System.Drawing.Size(381, 293);
            this.premiseGroupBox.TabIndex = 2;
            this.premiseGroupBox.TabStop = false;
            this.premiseGroupBox.Text = "Посылка";
            // 
            // premiseListBox
            // 
            this.premiseListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.premiseListBox.FormattingEnabled = true;
            this.premiseListBox.ItemHeight = 15;
            this.premiseListBox.Location = new System.Drawing.Point(3, 19);
            this.premiseListBox.Name = "premiseListBox";
            this.premiseListBox.Size = new System.Drawing.Size(375, 239);
            this.premiseListBox.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.premiseTablePanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 32);
            this.panel3.TabIndex = 1;
            // 
            // premiseTablePanel
            // 
            this.premiseTablePanel.ColumnCount = 3;
            this.premiseTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.premiseTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.premiseTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.premiseTablePanel.Controls.Add(this.deletePremiseButton, 2, 0);
            this.premiseTablePanel.Controls.Add(this.editPremiseButton, 1, 0);
            this.premiseTablePanel.Controls.Add(this.addPremiseButton, 0, 0);
            this.premiseTablePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.premiseTablePanel.Location = new System.Drawing.Point(0, 0);
            this.premiseTablePanel.Name = "premiseTablePanel";
            this.premiseTablePanel.RowCount = 1;
            this.premiseTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.premiseTablePanel.Size = new System.Drawing.Size(375, 32);
            this.premiseTablePanel.TabIndex = 1;
            // 
            // deletePremiseButton
            // 
            this.deletePremiseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletePremiseButton.Location = new System.Drawing.Point(253, 3);
            this.deletePremiseButton.Name = "deletePremiseButton";
            this.deletePremiseButton.Size = new System.Drawing.Size(119, 26);
            this.deletePremiseButton.TabIndex = 2;
            this.deletePremiseButton.Text = "Удалить";
            this.deletePremiseButton.UseVisualStyleBackColor = true;
            // 
            // editPremiseButton
            // 
            this.editPremiseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPremiseButton.Location = new System.Drawing.Point(128, 3);
            this.editPremiseButton.Name = "editPremiseButton";
            this.editPremiseButton.Size = new System.Drawing.Size(119, 26);
            this.editPremiseButton.TabIndex = 1;
            this.editPremiseButton.Text = "Изменить";
            this.editPremiseButton.UseVisualStyleBackColor = true;
            // 
            // addPremiseButton
            // 
            this.addPremiseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPremiseButton.Location = new System.Drawing.Point(3, 3);
            this.addPremiseButton.Name = "addPremiseButton";
            this.addPremiseButton.Size = new System.Drawing.Size(119, 26);
            this.addPremiseButton.TabIndex = 0;
            this.addPremiseButton.Text = "Добавить";
            this.addPremiseButton.UseVisualStyleBackColor = true;
            // 
            // RuleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.mainTablePanel);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "RuleEditForm";
            this.Text = "RuleEditForm";
            this.okCancelTablePanel.ResumeLayout(false);
            this.mainTablePanel.ResumeLayout(false);
            this.mainTablePanel.PerformLayout();
            this.premiseConclusionTablePanel.ResumeLayout(false);
            this.conclusionGroupBox.ResumeLayout(false);
            this.conclusionTablePanel.ResumeLayout(false);
            this.premiseGroupBox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.premiseTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ruleEditorMainPanel;
        private Panel ruleEditorEditPanel;
        private GroupBox ruleEditorPremiseGroupBox;
        private TableLayoutPanel okCancelTablePanel;
        private Button ruleEditorSaveButton;
        private Button ruleEditorCancelButton;
        private Label ruleEditorExplanationLabel;
        private TextBox ruleEditorExplanationTextBox;
        private Label ruleEditorRuleNameLabel;
        private TextBox ruleEditorRuleNameTextBox;
        private TableLayoutPanel mainTablePanel;
        private TableLayoutPanel premiseConclusionTablePanel;
        private GroupBox conclusionGroupBox;
        private ListBox conclusionListBox;
        private TableLayoutPanel conclusionTablePanel;
        private Button deleteConclusionButton;
        private Button editConclusionButton;
        private Button addConclusionButton;
        private GroupBox premiseGroupBox;
        private ListBox premiseListBox;
        private Panel panel3;
        private TableLayoutPanel premiseTablePanel;
        private Button deletePremiseButton;
        private Button editPremiseButton;
        private Button addPremiseButton;
    }
}