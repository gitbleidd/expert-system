namespace ExpertSystem
{
    partial class RuleEditorForm
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
            this.ruleEditorRuleNamePanel = new System.Windows.Forms.Panel();
            this.ruleEditorRuleNameLabel = new System.Windows.Forms.Label();
            this.ruleEditorRuleNameTextBox = new System.Windows.Forms.TextBox();
            this.ruleEditorPremisePanel = new System.Windows.Forms.Panel();
            this.ruleEditorPremiseGroupBox = new System.Windows.Forms.GroupBox();
            this.ruleEditorExplanationLabel = new System.Windows.Forms.Label();
            this.ruleEditorConclusionPanel = new System.Windows.Forms.Panel();
            this.ruleEditorConclusionGroupBox = new System.Windows.Forms.GroupBox();
            this.ruleEditorSaveButton = new System.Windows.Forms.Button();
            this.ruleEditorExplanationTextBox = new System.Windows.Forms.TextBox();
            this.ruleEditorCancelButton = new System.Windows.Forms.Button();
            this.ruleEditorEditPanel = new System.Windows.Forms.Panel();
            this.ruleEditorRuleNamePanel.SuspendLayout();
            this.ruleEditorPremisePanel.SuspendLayout();
            this.ruleEditorConclusionPanel.SuspendLayout();
            this.ruleEditorEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ruleEditorRuleNamePanel
            // 
            this.ruleEditorRuleNamePanel.Controls.Add(this.ruleEditorRuleNameLabel);
            this.ruleEditorRuleNamePanel.Controls.Add(this.ruleEditorRuleNameTextBox);
            this.ruleEditorRuleNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ruleEditorRuleNamePanel.Location = new System.Drawing.Point(0, 0);
            this.ruleEditorRuleNamePanel.Name = "ruleEditorRuleNamePanel";
            this.ruleEditorRuleNamePanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ruleEditorRuleNamePanel.Size = new System.Drawing.Size(780, 72);
            this.ruleEditorRuleNamePanel.TabIndex = 2;
            // 
            // ruleEditorRuleNameLabel
            // 
            this.ruleEditorRuleNameLabel.AutoSize = true;
            this.ruleEditorRuleNameLabel.Location = new System.Drawing.Point(3, 21);
            this.ruleEditorRuleNameLabel.Name = "ruleEditorRuleNameLabel";
            this.ruleEditorRuleNameLabel.Size = new System.Drawing.Size(83, 15);
            this.ruleEditorRuleNameLabel.TabIndex = 2;
            this.ruleEditorRuleNameLabel.Text = "Имя правила:";
            // 
            // ruleEditorRuleNameTextBox
            // 
            this.ruleEditorRuleNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ruleEditorRuleNameTextBox.Location = new System.Drawing.Point(0, 39);
            this.ruleEditorRuleNameTextBox.Name = "ruleEditorRuleNameTextBox";
            this.ruleEditorRuleNameTextBox.Size = new System.Drawing.Size(780, 23);
            this.ruleEditorRuleNameTextBox.TabIndex = 1;
            // 
            // ruleEditorPremisePanel
            // 
            this.ruleEditorPremisePanel.Controls.Add(this.ruleEditorPremiseGroupBox);
            this.ruleEditorPremisePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ruleEditorPremisePanel.Location = new System.Drawing.Point(0, 72);
            this.ruleEditorPremisePanel.Name = "ruleEditorPremisePanel";
            this.ruleEditorPremisePanel.Padding = new System.Windows.Forms.Padding(10);
            this.ruleEditorPremisePanel.Size = new System.Drawing.Size(339, 371);
            this.ruleEditorPremisePanel.TabIndex = 3;
            // 
            // ruleEditorPremiseGroupBox
            // 
            this.ruleEditorPremiseGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleEditorPremiseGroupBox.Location = new System.Drawing.Point(10, 10);
            this.ruleEditorPremiseGroupBox.Name = "ruleEditorPremiseGroupBox";
            this.ruleEditorPremiseGroupBox.Size = new System.Drawing.Size(319, 351);
            this.ruleEditorPremiseGroupBox.TabIndex = 0;
            this.ruleEditorPremiseGroupBox.TabStop = false;
            this.ruleEditorPremiseGroupBox.Text = "Посылка";
            // 
            // ruleEditorExplanationLabel
            // 
            this.ruleEditorExplanationLabel.AutoSize = true;
            this.ruleEditorExplanationLabel.Location = new System.Drawing.Point(20, 456);
            this.ruleEditorExplanationLabel.Name = "ruleEditorExplanationLabel";
            this.ruleEditorExplanationLabel.Size = new System.Drawing.Size(71, 15);
            this.ruleEditorExplanationLabel.TabIndex = 2;
            this.ruleEditorExplanationLabel.Text = "Пояснение:";
            // 
            // ruleEditorConclusionPanel
            // 
            this.ruleEditorConclusionPanel.Controls.Add(this.ruleEditorConclusionGroupBox);
            this.ruleEditorConclusionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleEditorConclusionPanel.Location = new System.Drawing.Point(339, 72);
            this.ruleEditorConclusionPanel.Name = "ruleEditorConclusionPanel";
            this.ruleEditorConclusionPanel.Padding = new System.Windows.Forms.Padding(10);
            this.ruleEditorConclusionPanel.Size = new System.Drawing.Size(441, 371);
            this.ruleEditorConclusionPanel.TabIndex = 4;
            // 
            // ruleEditorConclusionGroupBox
            // 
            this.ruleEditorConclusionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleEditorConclusionGroupBox.Location = new System.Drawing.Point(10, 10);
            this.ruleEditorConclusionGroupBox.Name = "ruleEditorConclusionGroupBox";
            this.ruleEditorConclusionGroupBox.Size = new System.Drawing.Size(421, 351);
            this.ruleEditorConclusionGroupBox.TabIndex = 0;
            this.ruleEditorConclusionGroupBox.TabStop = false;
            this.ruleEditorConclusionGroupBox.Text = "Заключение";
            // 
            // ruleEditorSaveButton
            // 
            this.ruleEditorSaveButton.Location = new System.Drawing.Point(624, 556);
            this.ruleEditorSaveButton.Name = "ruleEditorSaveButton";
            this.ruleEditorSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ruleEditorSaveButton.TabIndex = 0;
            this.ruleEditorSaveButton.Text = "OK";
            this.ruleEditorSaveButton.UseVisualStyleBackColor = true;
            // 
            // ruleEditorExplanationTextBox
            // 
            this.ruleEditorExplanationTextBox.Location = new System.Drawing.Point(13, 475);
            this.ruleEditorExplanationTextBox.Multiline = true;
            this.ruleEditorExplanationTextBox.Name = "ruleEditorExplanationTextBox";
            this.ruleEditorExplanationTextBox.Size = new System.Drawing.Size(780, 63);
            this.ruleEditorExplanationTextBox.TabIndex = 1;
            // 
            // ruleEditorCancelButton
            // 
            this.ruleEditorCancelButton.Location = new System.Drawing.Point(705, 556);
            this.ruleEditorCancelButton.Name = "ruleEditorCancelButton";
            this.ruleEditorCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ruleEditorCancelButton.TabIndex = 1;
            this.ruleEditorCancelButton.Text = "Отмена";
            this.ruleEditorCancelButton.UseVisualStyleBackColor = true;
            // 
            // ruleEditorEditPanel
            // 
            this.ruleEditorEditPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ruleEditorEditPanel.Controls.Add(this.ruleEditorConclusionPanel);
            this.ruleEditorEditPanel.Controls.Add(this.ruleEditorPremisePanel);
            this.ruleEditorEditPanel.Controls.Add(this.ruleEditorRuleNamePanel);
            this.ruleEditorEditPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ruleEditorEditPanel.Location = new System.Drawing.Point(10, 0);
            this.ruleEditorEditPanel.Name = "ruleEditorEditPanel";
            this.ruleEditorEditPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ruleEditorEditPanel.Size = new System.Drawing.Size(780, 453);
            this.ruleEditorEditPanel.TabIndex = 5;
            // 
            // RuleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.ruleEditorCancelButton);
            this.Controls.Add(this.ruleEditorSaveButton);
            this.Controls.Add(this.ruleEditorExplanationLabel);
            this.Controls.Add(this.ruleEditorExplanationTextBox);
            this.Controls.Add(this.ruleEditorEditPanel);
            this.Name = "RuleEditorForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "RuleEditorForm";
            this.ruleEditorRuleNamePanel.ResumeLayout(false);
            this.ruleEditorRuleNamePanel.PerformLayout();
            this.ruleEditorPremisePanel.ResumeLayout(false);
            this.ruleEditorConclusionPanel.ResumeLayout(false);
            this.ruleEditorEditPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel ruleEditorRuleNamePanel;
        private Label ruleEditorRuleNameLabel;
        private TextBox ruleEditorRuleNameTextBox;
        private Panel ruleEditorPremisePanel;
        private GroupBox ruleEditorPremiseGroupBox;
        private Label ruleEditorExplanationLabel;
        private Panel ruleEditorConclusionPanel;
        private GroupBox ruleEditorConclusionGroupBox;
        private Button ruleEditorSaveButton;
        private TextBox ruleEditorExplanationTextBox;
        private Button ruleEditorCancelButton;
        private Panel ruleEditorEditPanel;
    }
}