namespace ExpertSystem
{
    partial class DomainEditForm
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
            this.exitPanel = new System.Windows.Forms.Panel();
            this.exitTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.domainNameTextBox = new System.Windows.Forms.TextBox();
            this.domainValuesLabel = new System.Windows.Forms.Label();
            this.domainNameLabel = new System.Windows.Forms.Label();
            this.deleteValueButton = new System.Windows.Forms.Button();
            this.domainValueTextBox = new System.Windows.Forms.TextBox();
            this.addValueButton = new System.Windows.Forms.Button();
            this.editValueButton = new System.Windows.Forms.Button();
            this.dgvValues = new System.Windows.Forms.DataGridView();
            this.ValuesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitPanel.SuspendLayout();
            this.exitTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValues)).BeginInit();
            this.SuspendLayout();
            // 
            // exitPanel
            // 
            this.exitPanel.Controls.Add(this.exitTablePanel);
            this.exitPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitPanel.Location = new System.Drawing.Point(0, 288);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(449, 34);
            this.exitPanel.TabIndex = 19;
            // 
            // exitTablePanel
            // 
            this.exitTablePanel.ColumnCount = 3;
            this.exitTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.exitTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.exitTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.exitTablePanel.Controls.Add(this.saveButton, 1, 0);
            this.exitTablePanel.Controls.Add(this.cancelButton, 2, 0);
            this.exitTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitTablePanel.Location = new System.Drawing.Point(0, 0);
            this.exitTablePanel.Name = "exitTablePanel";
            this.exitTablePanel.RowCount = 1;
            this.exitTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.exitTablePanel.Size = new System.Drawing.Size(449, 34);
            this.exitTablePanel.TabIndex = 16;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(292, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(74, 28);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "OK";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(372, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 28);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // domainNameTextBox
            // 
            this.domainNameTextBox.Location = new System.Drawing.Point(12, 23);
            this.domainNameTextBox.Name = "domainNameTextBox";
            this.domainNameTextBox.Size = new System.Drawing.Size(423, 23);
            this.domainNameTextBox.TabIndex = 18;
            // 
            // domainValuesLabel
            // 
            this.domainValuesLabel.AutoSize = true;
            this.domainValuesLabel.Location = new System.Drawing.Point(12, 62);
            this.domainValuesLabel.Name = "domainValuesLabel";
            this.domainValuesLabel.Size = new System.Drawing.Size(178, 15);
            this.domainValuesLabel.TabIndex = 13;
            this.domainValuesLabel.Text = "Допустимые значения домена:";
            // 
            // domainNameLabel
            // 
            this.domainNameLabel.AutoSize = true;
            this.domainNameLabel.Location = new System.Drawing.Point(12, 5);
            this.domainNameLabel.Name = "domainNameLabel";
            this.domainNameLabel.Size = new System.Drawing.Size(78, 15);
            this.domainNameLabel.TabIndex = 11;
            this.domainNameLabel.Text = "Имя домена:";
            // 
            // deleteValueButton
            // 
            this.deleteValueButton.Enabled = false;
            this.deleteValueButton.Location = new System.Drawing.Point(12, 210);
            this.deleteValueButton.Name = "deleteValueButton";
            this.deleteValueButton.Size = new System.Drawing.Size(423, 23);
            this.deleteValueButton.TabIndex = 21;
            this.deleteValueButton.Text = "Удалить";
            this.deleteValueButton.UseVisualStyleBackColor = true;
            this.deleteValueButton.Click += new System.EventHandler(this.deleteValueButton_Click);
            // 
            // domainValueTextBox
            // 
            this.domainValueTextBox.Location = new System.Drawing.Point(12, 239);
            this.domainValueTextBox.Name = "domainValueTextBox";
            this.domainValueTextBox.Size = new System.Drawing.Size(261, 23);
            this.domainValueTextBox.TabIndex = 22;
            this.domainValueTextBox.TextChanged += new System.EventHandler(this.domainValueTextBox_TextChanged);
            // 
            // addValueButton
            // 
            this.addValueButton.Location = new System.Drawing.Point(279, 239);
            this.addValueButton.Name = "addValueButton";
            this.addValueButton.Size = new System.Drawing.Size(75, 23);
            this.addValueButton.TabIndex = 23;
            this.addValueButton.Text = "Добавить";
            this.addValueButton.UseVisualStyleBackColor = true;
            this.addValueButton.Click += new System.EventHandler(this.addValueButton_Click);
            // 
            // editValueButton
            // 
            this.editValueButton.Enabled = false;
            this.editValueButton.Location = new System.Drawing.Point(360, 239);
            this.editValueButton.Name = "editValueButton";
            this.editValueButton.Size = new System.Drawing.Size(75, 23);
            this.editValueButton.TabIndex = 24;
            this.editValueButton.Text = "Изменить";
            this.editValueButton.UseVisualStyleBackColor = true;
            this.editValueButton.Click += new System.EventHandler(this.editValueButton_Click);
            // 
            // dgvValues
            // 
            this.dgvValues.AllowDrop = true;
            this.dgvValues.AllowUserToAddRows = false;
            this.dgvValues.AllowUserToDeleteRows = false;
            this.dgvValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValues.ColumnHeadersVisible = false;
            this.dgvValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValuesColumn});
            this.dgvValues.Location = new System.Drawing.Point(12, 80);
            this.dgvValues.MultiSelect = false;
            this.dgvValues.Name = "dgvValues";
            this.dgvValues.ReadOnly = true;
            this.dgvValues.RowHeadersVisible = false;
            this.dgvValues.RowTemplate.Height = 25;
            this.dgvValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvValues.Size = new System.Drawing.Size(423, 124);
            this.dgvValues.TabIndex = 25;
            this.dgvValues.SelectionChanged += new System.EventHandler(this.dgvValues_SelectionChanged);
            this.dgvValues.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvValues_DragDrop);
            this.dgvValues.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvValues_DragEnter);
            this.dgvValues.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvValues_MouseMove);
            // 
            // ValuesColumn
            // 
            this.ValuesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValuesColumn.FillWeight = 30F;
            this.ValuesColumn.HeaderText = "Значения";
            this.ValuesColumn.Name = "ValuesColumn";
            this.ValuesColumn.ReadOnly = true;
            this.ValuesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DomainEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 322);
            this.Controls.Add(this.dgvValues);
            this.Controls.Add(this.editValueButton);
            this.Controls.Add(this.addValueButton);
            this.Controls.Add(this.domainValueTextBox);
            this.Controls.Add(this.deleteValueButton);
            this.Controls.Add(this.exitPanel);
            this.Controls.Add(this.domainNameTextBox);
            this.Controls.Add(this.domainValuesLabel);
            this.Controls.Add(this.domainNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DomainEditForm";
            this.Text = "Создание домена";
            this.exitPanel.ResumeLayout(false);
            this.exitTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel exitPanel;
        private TableLayoutPanel exitTablePanel;
        private Button saveButton;
        private Button cancelButton;
        private TextBox domainNameTextBox;
        private Label domainValuesLabel;
        private Label domainNameLabel;
        private Button deleteValueButton;
        private TextBox domainValueTextBox;
        private Button addValueButton;
        private Button editValueButton;
        private DataGridView dgvValues;
        private DataGridViewTextBoxColumn ValuesColumn;
    }
}