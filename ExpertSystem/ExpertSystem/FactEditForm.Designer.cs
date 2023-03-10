namespace ExpertSystem
{
    partial class FactEditForm
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
            this.StartPosition = FormStartPosition.CenterScreen;
            
            this.conclusionTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.deleteConclusionButton = new System.Windows.Forms.Button();
            this.editConclusionButton = new System.Windows.Forms.Button();
            this.okCancelTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ruleEditorSaveButton = new System.Windows.Forms.Button();
            this.ruleEditorCancelButton = new System.Windows.Forms.Button();
            this.okCancelAddingPremisePanel = new System.Windows.Forms.Panel();
            this.okCancelPremisePanelTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainAddindPremisePanel = new System.Windows.Forms.Panel();
            this.domainValueComboBox = new System.Windows.Forms.ComboBox();
            this.createVariableButton = new System.Windows.Forms.Button();
            this.variableComboBox = new System.Windows.Forms.ComboBox();
            this.equalLabel = new System.Windows.Forms.Label();
            this.conclusionTablePanel.SuspendLayout();
            this.okCancelTablePanel.SuspendLayout();
            this.okCancelAddingPremisePanel.SuspendLayout();
            this.okCancelPremisePanelTablePanel.SuspendLayout();
            this.mainAddindPremisePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // conclusionTablePanel
            // 
            this.conclusionTablePanel.ColumnCount = 3;
            this.conclusionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.conclusionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.conclusionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.conclusionTablePanel.Controls.Add(this.deleteConclusionButton, 2, 0);
            this.conclusionTablePanel.Location = new System.Drawing.Point(0, 0);
            this.conclusionTablePanel.Name = "conclusionTablePanel";
            this.conclusionTablePanel.RowCount = 1;
            this.conclusionTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.conclusionTablePanel.Size = new System.Drawing.Size(200, 100);
            this.conclusionTablePanel.TabIndex = 0;
            // 
            // deleteConclusionButton
            // 
            this.deleteConclusionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteConclusionButton.Enabled = false;
            this.deleteConclusionButton.Location = new System.Drawing.Point(135, 3);
            this.deleteConclusionButton.Name = "deleteConclusionButton";
            this.deleteConclusionButton.Size = new System.Drawing.Size(62, 94);
            this.deleteConclusionButton.TabIndex = 2;
            this.deleteConclusionButton.Text = "Удалить";
            this.deleteConclusionButton.UseVisualStyleBackColor = true;
            // 
            // editConclusionButton
            // 
            this.editConclusionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editConclusionButton.Enabled = false;
            this.editConclusionButton.Location = new System.Drawing.Point(69, 3);
            this.editConclusionButton.Name = "editConclusionButton";
            this.editConclusionButton.Size = new System.Drawing.Size(60, 94);
            this.editConclusionButton.TabIndex = 1;
            this.editConclusionButton.Text = "Изменить";
            this.editConclusionButton.UseVisualStyleBackColor = true;
            // 
            // okCancelTablePanel
            // 
            this.okCancelTablePanel.ColumnCount = 3;
            this.okCancelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.okCancelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.okCancelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.okCancelTablePanel.Controls.Add(this.ruleEditorSaveButton, 1, 0);
            this.okCancelTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okCancelTablePanel.Location = new System.Drawing.Point(0, 0);
            this.okCancelTablePanel.Name = "okCancelTablePanel";
            this.okCancelTablePanel.RowCount = 1;
            this.okCancelTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.okCancelTablePanel.Size = new System.Drawing.Size(200, 100);
            this.okCancelTablePanel.TabIndex = 0;
            // 
            // ruleEditorSaveButton
            // 
            this.ruleEditorSaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleEditorSaveButton.Location = new System.Drawing.Point(43, 3);
            this.ruleEditorSaveButton.Name = "ruleEditorSaveButton";
            this.ruleEditorSaveButton.Size = new System.Drawing.Size(74, 94);
            this.ruleEditorSaveButton.TabIndex = 7;
            this.ruleEditorSaveButton.Text = "OK";
            this.ruleEditorSaveButton.UseVisualStyleBackColor = true;
            // 
            // ruleEditorCancelButton
            // 
            this.ruleEditorCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleEditorCancelButton.Location = new System.Drawing.Point(123, 3);
            this.ruleEditorCancelButton.Name = "ruleEditorCancelButton";
            this.ruleEditorCancelButton.Size = new System.Drawing.Size(74, 94);
            this.ruleEditorCancelButton.TabIndex = 10;
            this.ruleEditorCancelButton.Text = "Отмена";
            this.ruleEditorCancelButton.UseVisualStyleBackColor = true;
            // 
            // okCancelAddingPremisePanel
            // 
            this.okCancelAddingPremisePanel.Controls.Add(this.okCancelPremisePanelTablePanel);
            this.okCancelAddingPremisePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okCancelAddingPremisePanel.Location = new System.Drawing.Point(10, 113);
            this.okCancelAddingPremisePanel.Name = "okCancelAddingPremisePanel";
            this.okCancelAddingPremisePanel.Size = new System.Drawing.Size(424, 34);
            this.okCancelAddingPremisePanel.TabIndex = 3;
            // 
            // okCancelPremisePanelTablePanel
            // 
            this.okCancelPremisePanelTablePanel.ColumnCount = 3;
            this.okCancelPremisePanelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.okCancelPremisePanelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.okCancelPremisePanelTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.okCancelPremisePanelTablePanel.Controls.Add(this.okButton, 1, 0);
            this.okCancelPremisePanelTablePanel.Controls.Add(this.cancelButton, 2, 0);
            this.okCancelPremisePanelTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okCancelPremisePanelTablePanel.Location = new System.Drawing.Point(0, 0);
            this.okCancelPremisePanelTablePanel.Name = "okCancelPremisePanelTablePanel";
            this.okCancelPremisePanelTablePanel.RowCount = 1;
            this.okCancelPremisePanelTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.okCancelPremisePanelTablePanel.Size = new System.Drawing.Size(424, 34);
            this.okCancelPremisePanelTablePanel.TabIndex = 16;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(267, 3);
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
            this.cancelButton.Location = new System.Drawing.Point(347, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 28);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mainAddindPremisePanel
            // 
            this.mainAddindPremisePanel.Controls.Add(this.domainValueComboBox);
            this.mainAddindPremisePanel.Controls.Add(this.createVariableButton);
            this.mainAddindPremisePanel.Controls.Add(this.variableComboBox);
            this.mainAddindPremisePanel.Controls.Add(this.equalLabel);
            this.mainAddindPremisePanel.Controls.Add(this.okCancelAddingPremisePanel);
            this.mainAddindPremisePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainAddindPremisePanel.Location = new System.Drawing.Point(0, 0);
            this.mainAddindPremisePanel.Name = "mainAddindPremisePanel";
            this.mainAddindPremisePanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainAddindPremisePanel.Size = new System.Drawing.Size(444, 157);
            this.mainAddindPremisePanel.TabIndex = 0;
            // 
            // domainValueComboBox
            // 
            this.domainValueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.domainValueComboBox.FormattingEnabled = true;
            this.domainValueComboBox.Location = new System.Drawing.Point(13, 86);
            this.domainValueComboBox.Name = "domainValueComboBox";
            this.domainValueComboBox.Size = new System.Drawing.Size(421, 23);
            this.domainValueComboBox.TabIndex = 6;
            // 
            // createVariableButton
            // 
            this.createVariableButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createVariableButton.Location = new System.Drawing.Point(410, 28);
            this.createVariableButton.Name = "createVariableButton";
            this.createVariableButton.Size = new System.Drawing.Size(24, 23);
            this.createVariableButton.TabIndex = 5;
            this.createVariableButton.Text = "+";
            this.createVariableButton.UseVisualStyleBackColor = true;
            this.createVariableButton.Click += new System.EventHandler(this.createVariableButton_Click);
            // 
            // variableComboBox
            // 
            this.variableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.variableComboBox.FormattingEnabled = true;
            this.variableComboBox.Location = new System.Drawing.Point(13, 28);
            this.variableComboBox.Name = "variableComboBox";
            this.variableComboBox.Size = new System.Drawing.Size(391, 23);
            this.variableComboBox.TabIndex = 4;
            this.variableComboBox.SelectedIndexChanged += new System.EventHandler(this.variableComboBox_SelectedIndexChanged);
            // 
            // equalLabel
            // 
            this.equalLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equalLabel.Location = new System.Drawing.Point(13, 54);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(421, 29);
            this.equalLabel.TabIndex = 3;
            this.equalLabel.Text = "=";
            this.equalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FactEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 157);
            this.Controls.Add(this.mainAddindPremisePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(460, 196);
            this.MaximizeBox = false;
            this.Name = "FactEditForm";
            this.Text = "Добавление факта посылки";
            this.conclusionTablePanel.ResumeLayout(false);
            this.okCancelTablePanel.ResumeLayout(false);
            this.okCancelAddingPremisePanel.ResumeLayout(false);
            this.okCancelPremisePanelTablePanel.ResumeLayout(false);
            this.mainAddindPremisePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel conclusionTablePanel;
        private Button deleteConclusionButton;
        private Button editConclusionButton;
        private TableLayoutPanel okCancelTablePanel;
        private Button ruleEditorSaveButton;
        private Button ruleEditorCancelButton;
        private Panel okCancelAddingPremisePanel;
        private TableLayoutPanel okCancelPremisePanelTablePanel;
        private Button okButton;
        private Button cancelButton;
        private Panel mainAddindPremisePanel;
        private ComboBox comboBox2;
        private Button button1;
        private ComboBox comboBox1;
        private Label equalLabel;
        private ComboBox domainValueComboBox;
        private Button createVariableButton;
        private ComboBox variableComboBox;
    }
}