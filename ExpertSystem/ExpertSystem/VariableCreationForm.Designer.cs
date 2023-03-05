namespace ExpertSystem
{
    partial class VariableCreationForm
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
            this.variableNameLabel = new System.Windows.Forms.Label();
            this.domainComboBox = new System.Windows.Forms.ComboBox();
            this.domainLabel = new System.Windows.Forms.Label();
            this.variableTypeLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.variableTypePanel = new System.Windows.Forms.Panel();
            this.inferredRequestedRadioButton = new System.Windows.Forms.RadioButton();
            this.inferredRadioButton = new System.Windows.Forms.RadioButton();
            this.requestedRadioButton = new System.Windows.Forms.RadioButton();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.variableNameTextBox = new System.Windows.Forms.TextBox();
            this.okCancelPremisePanelTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.okAddingPremiseButton = new System.Windows.Forms.Button();
            this.cancelAddingPremiseButton = new System.Windows.Forms.Button();
            this.okCancelAddingPremisePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createDomainButton = new System.Windows.Forms.Button();
            this.variableTypePanel.SuspendLayout();
            this.okCancelPremisePanelTablePanel.SuspendLayout();
            this.okCancelAddingPremisePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // variableNameLabel
            // 
            this.variableNameLabel.AutoSize = true;
            this.variableNameLabel.Location = new System.Drawing.Point(12, 9);
            this.variableNameLabel.Name = "variableNameLabel";
            this.variableNameLabel.Size = new System.Drawing.Size(106, 15);
            this.variableNameLabel.TabIndex = 0;
            this.variableNameLabel.Text = "Имя переменной:";
            // 
            // domainComboBox
            // 
            this.domainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.domainComboBox.FormattingEnabled = true;
            this.domainComboBox.Location = new System.Drawing.Point(12, 84);
            this.domainComboBox.Name = "domainComboBox";
            this.domainComboBox.Size = new System.Drawing.Size(393, 23);
            this.domainComboBox.TabIndex = 1;
            // 
            // domainLabel
            // 
            this.domainLabel.AutoSize = true;
            this.domainLabel.Location = new System.Drawing.Point(12, 66);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(47, 15);
            this.domainLabel.TabIndex = 2;
            this.domainLabel.Text = "Домен:";
            // 
            // variableTypeLabel
            // 
            this.variableTypeLabel.AutoSize = true;
            this.variableTypeLabel.Location = new System.Drawing.Point(12, 124);
            this.variableTypeLabel.Name = "variableTypeLabel";
            this.variableTypeLabel.Size = new System.Drawing.Size(102, 15);
            this.variableTypeLabel.TabIndex = 4;
            this.variableTypeLabel.Text = "Тип переменной:";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(15, 222);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(88, 15);
            this.questionTextLabel.TabIndex = 5;
            this.questionTextLabel.Text = "Текст вопроса:";
            // 
            // variableTypePanel
            // 
            this.variableTypePanel.Controls.Add(this.inferredRequestedRadioButton);
            this.variableTypePanel.Controls.Add(this.inferredRadioButton);
            this.variableTypePanel.Controls.Add(this.requestedRadioButton);
            this.variableTypePanel.Location = new System.Drawing.Point(12, 142);
            this.variableTypePanel.Name = "variableTypePanel";
            this.variableTypePanel.Size = new System.Drawing.Size(248, 77);
            this.variableTypePanel.TabIndex = 6;
            // 
            // inferredRequestedRadioButton
            // 
            this.inferredRequestedRadioButton.AutoSize = true;
            this.inferredRequestedRadioButton.Location = new System.Drawing.Point(3, 53);
            this.inferredRequestedRadioButton.Name = "inferredRequestedRadioButton";
            this.inferredRequestedRadioButton.Size = new System.Drawing.Size(177, 19);
            this.inferredRequestedRadioButton.TabIndex = 2;
            this.inferredRequestedRadioButton.TabStop = true;
            this.inferredRequestedRadioButton.Text = "Выводимо-запрашиваемая";
            this.inferredRequestedRadioButton.UseVisualStyleBackColor = true;
            // 
            // inferredRadioButton
            // 
            this.inferredRadioButton.AutoSize = true;
            this.inferredRadioButton.Location = new System.Drawing.Point(3, 28);
            this.inferredRadioButton.Name = "inferredRadioButton";
            this.inferredRadioButton.Size = new System.Drawing.Size(88, 19);
            this.inferredRadioButton.TabIndex = 1;
            this.inferredRadioButton.TabStop = true;
            this.inferredRadioButton.Text = "Выводимая";
            this.inferredRadioButton.UseVisualStyleBackColor = true;
            // 
            // inquireRadioButton
            // 
            this.requestedRadioButton.AutoSize = true;
            this.requestedRadioButton.Location = new System.Drawing.Point(3, 3);
            this.requestedRadioButton.Name = "requestedRadioButton";
            this.requestedRadioButton.Size = new System.Drawing.Size(115, 19);
            this.requestedRadioButton.TabIndex = 0;
            this.requestedRadioButton.TabStop = true;
            this.requestedRadioButton.Text = "Запрашиваемая";
            this.requestedRadioButton.UseVisualStyleBackColor = true;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(12, 240);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(414, 60);
            this.questionTextBox.TabIndex = 7;
            // 
            // variableNameTextBox
            // 
            this.variableNameTextBox.Location = new System.Drawing.Point(12, 27);
            this.variableNameTextBox.Name = "variableNameTextBox";
            this.variableNameTextBox.Size = new System.Drawing.Size(423, 23);
            this.variableNameTextBox.TabIndex = 8;
            // 
            // okCancelPremisePanelTablePanel
            // 
            this.okCancelPremisePanelTablePanel.ColumnCount = 3;
            this.okCancelPremisePanelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.okCancelPremisePanelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.okCancelPremisePanelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.okCancelPremisePanelTablePanel.Controls.Add(this.okAddingPremiseButton, 1, 0);
            this.okCancelPremisePanelTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okCancelPremisePanelTablePanel.Location = new System.Drawing.Point(0, 0);
            this.okCancelPremisePanelTablePanel.Name = "okCancelPremisePanelTablePanel";
            this.okCancelPremisePanelTablePanel.RowCount = 1;
            this.okCancelPremisePanelTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.okCancelPremisePanelTablePanel.Size = new System.Drawing.Size(200, 100);
            this.okCancelPremisePanelTablePanel.TabIndex = 0;
            // 
            // okAddingPremiseButton
            // 
            this.okAddingPremiseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okAddingPremiseButton.Location = new System.Drawing.Point(43, 3);
            this.okAddingPremiseButton.Name = "okAddingPremiseButton";
            this.okAddingPremiseButton.Size = new System.Drawing.Size(74, 94);
            this.okAddingPremiseButton.TabIndex = 7;
            this.okAddingPremiseButton.Text = "OK";
            this.okAddingPremiseButton.UseVisualStyleBackColor = true;
            // 
            // cancelAddingPremiseButton
            // 
            this.cancelAddingPremiseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelAddingPremiseButton.Location = new System.Drawing.Point(123, 3);
            this.cancelAddingPremiseButton.Name = "cancelAddingPremiseButton";
            this.cancelAddingPremiseButton.Size = new System.Drawing.Size(74, 94);
            this.cancelAddingPremiseButton.TabIndex = 10;
            this.cancelAddingPremiseButton.Text = "Отмена";
            this.cancelAddingPremiseButton.UseVisualStyleBackColor = true;
            // 
            // okCancelAddingPremisePanel
            // 
            this.okCancelAddingPremisePanel.Controls.Add(this.tableLayoutPanel1);
            this.okCancelAddingPremisePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okCancelAddingPremisePanel.Location = new System.Drawing.Point(0, 317);
            this.okCancelAddingPremisePanel.Name = "okCancelAddingPremisePanel";
            this.okCancelAddingPremisePanel.Size = new System.Drawing.Size(447, 34);
            this.okCancelAddingPremisePanel.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 34);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(290, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(74, 28);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(370, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 28);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createDomainButton
            // 
            this.createDomainButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createDomainButton.Location = new System.Drawing.Point(411, 84);
            this.createDomainButton.Name = "createDomainButton";
            this.createDomainButton.Size = new System.Drawing.Size(24, 23);
            this.createDomainButton.TabIndex = 10;
            this.createDomainButton.Text = "+";
            this.createDomainButton.UseVisualStyleBackColor = true;
            this.createDomainButton.Click += new System.EventHandler(this.createDomainButton_Click);
            // 
            // VariableCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 351);
            this.Controls.Add(this.createDomainButton);
            this.Controls.Add(this.okCancelAddingPremisePanel);
            this.Controls.Add(this.variableNameTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.variableTypePanel);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.variableTypeLabel);
            this.Controls.Add(this.domainLabel);
            this.Controls.Add(this.domainComboBox);
            this.Controls.Add(this.variableNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VariableCreationForm";
            this.Text = "Создание переменной";
            this.variableTypePanel.ResumeLayout(false);
            this.variableTypePanel.PerformLayout();
            this.okCancelPremisePanelTablePanel.ResumeLayout(false);
            this.okCancelAddingPremisePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label variableNameLabel;
        private ComboBox domainComboBox;
        private Label domainLabel;
        private Label variableTypeLabel;
        private Label questionTextLabel;
        private Panel variableTypePanel;
        private RadioButton inferredRequestedRadioButton;
        private RadioButton inferredRadioButton;
        private RadioButton requestedRadioButton;
        private TextBox questionTextBox;
        private TextBox variableNameTextBox;
        private TableLayoutPanel okCancelPremisePanelTablePanel;
        private Button okAddingPremiseButton;
        private Button cancelAddingPremiseButton;
        private Panel okCancelAddingPremisePanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button okButton;
        private Button cancelButton;
        private Button createDomainButton;
    }
}