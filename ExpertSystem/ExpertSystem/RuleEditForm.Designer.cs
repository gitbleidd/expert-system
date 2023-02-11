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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.editPanel = new System.Windows.Forms.Panel();
            this.okCancelTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.ruleNameLabel = new System.Windows.Forms.Label();
            this.ruleNameTextBox = new System.Windows.Forms.TextBox();
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
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(200, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.SystemColors.Control;
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(200, 100);
            this.editPanel.TabIndex = 0;
            // 
            // okCancelTablePanel
            // 
            this.okCancelTablePanel.ColumnCount = 3;
            this.okCancelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.okCancelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.okCancelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.okCancelTablePanel.Controls.Add(this.saveButton, 1, 0);
            this.okCancelTablePanel.Controls.Add(this.cancelButton, 2, 0);
            this.okCancelTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okCancelTablePanel.Location = new System.Drawing.Point(13, 520);
            this.okCancelTablePanel.Name = "okCancelTablePanel";
            this.okCancelTablePanel.RowCount = 1;
            this.okCancelTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.okCancelTablePanel.Size = new System.Drawing.Size(774, 31);
            this.okCancelTablePanel.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(617, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(74, 25);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "OK";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(697, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 25);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 380);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(774, 15);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Пояснение:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(13, 398);
            this.descriptionTextBox.MinimumSize = new System.Drawing.Size(100, 50);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(774, 116);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // ruleNameLabel
            // 
            this.ruleNameLabel.AutoSize = true;
            this.ruleNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ruleNameLabel.Location = new System.Drawing.Point(13, 25);
            this.ruleNameLabel.Name = "ruleNameLabel";
            this.ruleNameLabel.Size = new System.Drawing.Size(774, 15);
            this.ruleNameLabel.TabIndex = 2;
            this.ruleNameLabel.Text = "Имя правила:";
            // 
            // ruleNameTextBox
            // 
            this.ruleNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ruleNameTextBox.Location = new System.Drawing.Point(13, 44);
            this.ruleNameTextBox.Name = "ruleNameTextBox";
            this.ruleNameTextBox.Size = new System.Drawing.Size(774, 23);
            this.ruleNameTextBox.TabIndex = 14;
            // 
            // mainTablePanel
            // 
            this.mainTablePanel.ColumnCount = 1;
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.Controls.Add(this.ruleNameTextBox, 0, 1);
            this.mainTablePanel.Controls.Add(this.ruleNameLabel, 0, 0);
            this.mainTablePanel.Controls.Add(this.descriptionTextBox, 0, 4);
            this.mainTablePanel.Controls.Add(this.premiseConclusionTablePanel, 0, 2);
            this.mainTablePanel.Controls.Add(this.descriptionLabel, 0, 3);
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
            this.conclusionListBox.SelectedIndexChanged += new System.EventHandler(this.conclusionListBox_SelectedIndexChanged);
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
            this.deleteConclusionButton.Enabled = false;
            this.deleteConclusionButton.Location = new System.Drawing.Point(253, 3);
            this.deleteConclusionButton.Name = "deleteConclusionButton";
            this.deleteConclusionButton.Size = new System.Drawing.Size(119, 26);
            this.deleteConclusionButton.TabIndex = 2;
            this.deleteConclusionButton.Text = "Удалить";
            this.deleteConclusionButton.UseVisualStyleBackColor = true;
            this.deleteConclusionButton.Click += new System.EventHandler(this.deleteConclusionButton_Click);
            // 
            // editConclusionButton
            // 
            this.editConclusionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editConclusionButton.Enabled = false;
            this.editConclusionButton.Location = new System.Drawing.Point(128, 3);
            this.editConclusionButton.Name = "editConclusionButton";
            this.editConclusionButton.Size = new System.Drawing.Size(119, 26);
            this.editConclusionButton.TabIndex = 1;
            this.editConclusionButton.Text = "Изменить";
            this.editConclusionButton.UseVisualStyleBackColor = true;
            this.editConclusionButton.Click += new System.EventHandler(this.editConclusionButton_Click);
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
            this.addConclusionButton.Click += new System.EventHandler(this.addConclusionButton_Click);
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
            this.premiseListBox.SelectedIndexChanged += new System.EventHandler(this.premiseListBox_SelectedIndexChanged);
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
            this.deletePremiseButton.Enabled = false;
            this.deletePremiseButton.Location = new System.Drawing.Point(253, 3);
            this.deletePremiseButton.Name = "deletePremiseButton";
            this.deletePremiseButton.Size = new System.Drawing.Size(119, 26);
            this.deletePremiseButton.TabIndex = 2;
            this.deletePremiseButton.Text = "Удалить";
            this.deletePremiseButton.UseVisualStyleBackColor = true;
            this.deletePremiseButton.Click += new System.EventHandler(this.deletePremiseButton_Click);
            // 
            // editPremiseButton
            // 
            this.editPremiseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPremiseButton.Enabled = false;
            this.editPremiseButton.Location = new System.Drawing.Point(128, 3);
            this.editPremiseButton.Name = "editPremiseButton";
            this.editPremiseButton.Size = new System.Drawing.Size(119, 26);
            this.editPremiseButton.TabIndex = 1;
            this.editPremiseButton.Text = "Изменить";
            this.editPremiseButton.UseVisualStyleBackColor = true;
            this.editPremiseButton.Click += new System.EventHandler(this.editPremiseButton_Click);
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
            this.addPremiseButton.Click += new System.EventHandler(this.addPremiseButton_Click);
            // 
            // RuleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.mainTablePanel);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "RuleEditForm";
            this.Text = "Редактирование правила";
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

        private Panel mainPanel;
        private Panel editPanel;
        private TableLayoutPanel okCancelTablePanel;
        private Button saveButton;
        private Button cancelButton;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private Label ruleNameLabel;
        private TextBox ruleNameTextBox;
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