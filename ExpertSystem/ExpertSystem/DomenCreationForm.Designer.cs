namespace ExpertSystem
{
    partial class DomenCreationForm
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
            this.okCancelAddingPremisePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.okDomenCreation = new System.Windows.Forms.Button();
            this.cancelDomenCreation = new System.Windows.Forms.Button();
            this.domenNameTextBox = new System.Windows.Forms.TextBox();
            this.domenValuesLabel = new System.Windows.Forms.Label();
            this.domenNameLabel = new System.Windows.Forms.Label();
            this.domenValues = new System.Windows.Forms.ListBox();
            this.deleteDomenValueButton = new System.Windows.Forms.Button();
            this.domenValueTextBox = new System.Windows.Forms.TextBox();
            this.eddDomenValueButton = new System.Windows.Forms.Button();
            this.editDomenValueButton = new System.Windows.Forms.Button();
            this.okCancelAddingPremisePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okCancelAddingPremisePanel
            // 
            this.okCancelAddingPremisePanel.Controls.Add(this.tableLayoutPanel1);
            this.okCancelAddingPremisePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okCancelAddingPremisePanel.Location = new System.Drawing.Point(0, 288);
            this.okCancelAddingPremisePanel.Name = "okCancelAddingPremisePanel";
            this.okCancelAddingPremisePanel.Size = new System.Drawing.Size(449, 34);
            this.okCancelAddingPremisePanel.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.okDomenCreation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelDomenCreation, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 34);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // okDomenCreation
            // 
            this.okDomenCreation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okDomenCreation.Location = new System.Drawing.Point(292, 3);
            this.okDomenCreation.Name = "okDomenCreation";
            this.okDomenCreation.Size = new System.Drawing.Size(74, 28);
            this.okDomenCreation.TabIndex = 7;
            this.okDomenCreation.Text = "OK";
            this.okDomenCreation.UseVisualStyleBackColor = true;
            // 
            // cancelDomenCreation
            // 
            this.cancelDomenCreation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelDomenCreation.Location = new System.Drawing.Point(372, 3);
            this.cancelDomenCreation.Name = "cancelDomenCreation";
            this.cancelDomenCreation.Size = new System.Drawing.Size(74, 28);
            this.cancelDomenCreation.TabIndex = 10;
            this.cancelDomenCreation.Text = "Отмена";
            this.cancelDomenCreation.UseVisualStyleBackColor = true;
            // 
            // domenNameTextBox
            // 
            this.domenNameTextBox.Location = new System.Drawing.Point(12, 23);
            this.domenNameTextBox.Name = "domenNameTextBox";
            this.domenNameTextBox.Size = new System.Drawing.Size(423, 23);
            this.domenNameTextBox.TabIndex = 18;
            // 
            // domenValuesLabel
            // 
            this.domenValuesLabel.AutoSize = true;
            this.domenValuesLabel.Location = new System.Drawing.Point(12, 62);
            this.domenValuesLabel.Name = "domenValuesLabel";
            this.domenValuesLabel.Size = new System.Drawing.Size(178, 15);
            this.domenValuesLabel.TabIndex = 13;
            this.domenValuesLabel.Text = "Допустимые значения домена:";
            // 
            // domenNameLabel
            // 
            this.domenNameLabel.AutoSize = true;
            this.domenNameLabel.Location = new System.Drawing.Point(12, 5);
            this.domenNameLabel.Name = "domenNameLabel";
            this.domenNameLabel.Size = new System.Drawing.Size(78, 15);
            this.domenNameLabel.TabIndex = 11;
            this.domenNameLabel.Text = "Имя домена:";
            // 
            // domenValues
            // 
            this.domenValues.FormattingEnabled = true;
            this.domenValues.ItemHeight = 15;
            this.domenValues.Location = new System.Drawing.Point(12, 80);
            this.domenValues.Name = "domenValues";
            this.domenValues.Size = new System.Drawing.Size(423, 124);
            this.domenValues.TabIndex = 20;
            // 
            // deleteDomenValueButton
            // 
            this.deleteDomenValueButton.Location = new System.Drawing.Point(12, 210);
            this.deleteDomenValueButton.Name = "deleteDomenValueButton";
            this.deleteDomenValueButton.Size = new System.Drawing.Size(423, 23);
            this.deleteDomenValueButton.TabIndex = 21;
            this.deleteDomenValueButton.Text = "Удалить";
            this.deleteDomenValueButton.UseVisualStyleBackColor = true;
            // 
            // domenValueTextBox
            // 
            this.domenValueTextBox.Location = new System.Drawing.Point(12, 239);
            this.domenValueTextBox.Name = "domenValueTextBox";
            this.domenValueTextBox.Size = new System.Drawing.Size(261, 23);
            this.domenValueTextBox.TabIndex = 22;
            // 
            // eddDomenValueButton
            // 
            this.eddDomenValueButton.Location = new System.Drawing.Point(279, 239);
            this.eddDomenValueButton.Name = "eddDomenValueButton";
            this.eddDomenValueButton.Size = new System.Drawing.Size(75, 23);
            this.eddDomenValueButton.TabIndex = 23;
            this.eddDomenValueButton.Text = "Добавить";
            this.eddDomenValueButton.UseVisualStyleBackColor = true;
            // 
            // editDomenValueButton
            // 
            this.editDomenValueButton.Location = new System.Drawing.Point(360, 239);
            this.editDomenValueButton.Name = "editDomenValueButton";
            this.editDomenValueButton.Size = new System.Drawing.Size(75, 23);
            this.editDomenValueButton.TabIndex = 24;
            this.editDomenValueButton.Text = "Изменить";
            this.editDomenValueButton.UseVisualStyleBackColor = true;
            // 
            // DomenCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 322);
            this.Controls.Add(this.editDomenValueButton);
            this.Controls.Add(this.eddDomenValueButton);
            this.Controls.Add(this.domenValueTextBox);
            this.Controls.Add(this.deleteDomenValueButton);
            this.Controls.Add(this.domenValues);
            this.Controls.Add(this.okCancelAddingPremisePanel);
            this.Controls.Add(this.domenNameTextBox);
            this.Controls.Add(this.domenValuesLabel);
            this.Controls.Add(this.domenNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DomenCreationForm";
            this.Text = "Создание домена";
            this.okCancelAddingPremisePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel okCancelAddingPremisePanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button okDomenCreation;
        private Button cancelDomenCreation;
        private TextBox domenNameTextBox;
        private Label domenValuesLabel;
        private Label domenNameLabel;
        private ListBox domenValues;
        private Button deleteDomenValueButton;
        private TextBox domenValueTextBox;
        private Button eddDomenValueButton;
        private Button editDomenValueButton;
    }
}