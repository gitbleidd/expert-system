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
            this.domenComboBox = new System.Windows.Forms.ComboBox();
            this.domenLabel = new System.Windows.Forms.Label();
            this.variableTypeLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.variableTypePanel = new System.Windows.Forms.Panel();
            this.inquireProduceRadioButton = new System.Windows.Forms.RadioButton();
            this.produceRadioButton = new System.Windows.Forms.RadioButton();
            this.inquireRadioButton = new System.Windows.Forms.RadioButton();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.variableNameTextBox = new System.Windows.Forms.TextBox();
            this.okCancelPremisePanelTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.okAddingPremiseButton = new System.Windows.Forms.Button();
            this.cancelAddingPremiseButton = new System.Windows.Forms.Button();
            this.okCancelAddingPremisePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createDomenButton = new System.Windows.Forms.Button();
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
            // domenComboBox
            // 
            this.domenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.domenComboBox.FormattingEnabled = true;
            this.domenComboBox.Location = new System.Drawing.Point(12, 84);
            this.domenComboBox.Name = "domenComboBox";
            this.domenComboBox.Size = new System.Drawing.Size(393, 23);
            this.domenComboBox.TabIndex = 1;
            this.domenComboBox.SelectedIndexChanged += new System.EventHandler(this.domenComboBox_SelectedIndexChanged);
            // 
            // domenLabel
            // 
            this.domenLabel.AutoSize = true;
            this.domenLabel.Location = new System.Drawing.Point(12, 66);
            this.domenLabel.Name = "domenLabel";
            this.domenLabel.Size = new System.Drawing.Size(47, 15);
            this.domenLabel.TabIndex = 2;
            this.domenLabel.Text = "Домен:";
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
            this.variableTypePanel.Controls.Add(this.inquireProduceRadioButton);
            this.variableTypePanel.Controls.Add(this.produceRadioButton);
            this.variableTypePanel.Controls.Add(this.inquireRadioButton);
            this.variableTypePanel.Location = new System.Drawing.Point(12, 142);
            this.variableTypePanel.Name = "variableTypePanel";
            this.variableTypePanel.Size = new System.Drawing.Size(248, 77);
            this.variableTypePanel.TabIndex = 6;
            // 
            // inquireProduceRadioButton
            // 
            this.inquireProduceRadioButton.AutoSize = true;
            this.inquireProduceRadioButton.Location = new System.Drawing.Point(3, 53);
            this.inquireProduceRadioButton.Name = "inquireProduceRadioButton";
            this.inquireProduceRadioButton.Size = new System.Drawing.Size(177, 19);
            this.inquireProduceRadioButton.TabIndex = 2;
            this.inquireProduceRadioButton.TabStop = true;
            this.inquireProduceRadioButton.Text = "Запрашиваемо-выводимая";
            this.inquireProduceRadioButton.UseVisualStyleBackColor = true;
            // 
            // produceRadioButton
            // 
            this.produceRadioButton.AutoSize = true;
            this.produceRadioButton.Location = new System.Drawing.Point(3, 28);
            this.produceRadioButton.Name = "produceRadioButton";
            this.produceRadioButton.Size = new System.Drawing.Size(88, 19);
            this.produceRadioButton.TabIndex = 1;
            this.produceRadioButton.TabStop = true;
            this.produceRadioButton.Text = "Выводимая";
            this.produceRadioButton.UseVisualStyleBackColor = true;
            // 
            // inquireRadioButton
            // 
            this.inquireRadioButton.AutoSize = true;
            this.inquireRadioButton.Location = new System.Drawing.Point(3, 3);
            this.inquireRadioButton.Name = "inquireRadioButton";
            this.inquireRadioButton.Size = new System.Drawing.Size(115, 19);
            this.inquireRadioButton.TabIndex = 0;
            this.inquireRadioButton.TabStop = true;
            this.inquireRadioButton.Text = "Запрашиваемая";
            this.inquireRadioButton.UseVisualStyleBackColor = true;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(12, 240);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(414, 60);
            this.questionTextBox.TabIndex = 7;
            this.questionTextBox.TextChanged += new System.EventHandler(this.questionTextBox_TextChanged);
            // 
            // variableNameTextBox
            // 
            this.variableNameTextBox.Location = new System.Drawing.Point(12, 27);
            this.variableNameTextBox.Name = "variableNameTextBox";
            this.variableNameTextBox.Size = new System.Drawing.Size(423, 23);
            this.variableNameTextBox.TabIndex = 8;
            this.variableNameTextBox.TextChanged += new System.EventHandler(this.variableNameTextBox_TextChanged);
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
            this.okCancelAddingPremisePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.okCancelAddingPremisePanel_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 34);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(290, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(370, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // createDomenButton
            // 
            this.createDomenButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createDomenButton.Location = new System.Drawing.Point(411, 84);
            this.createDomenButton.Name = "createDomenButton";
            this.createDomenButton.Size = new System.Drawing.Size(24, 23);
            this.createDomenButton.TabIndex = 10;
            this.createDomenButton.Text = "+";
            this.createDomenButton.UseVisualStyleBackColor = true;
            this.createDomenButton.Click += new System.EventHandler(this.createDomenButton_Click);
            // 
            // VariableCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 351);
            this.Controls.Add(this.createDomenButton);
            this.Controls.Add(this.okCancelAddingPremisePanel);
            this.Controls.Add(this.variableNameTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.variableTypePanel);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.variableTypeLabel);
            this.Controls.Add(this.domenLabel);
            this.Controls.Add(this.domenComboBox);
            this.Controls.Add(this.variableNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private ComboBox domenComboBox;
        private Label domenLabel;
        private Label variableTypeLabel;
        private Label questionTextLabel;
        private Panel variableTypePanel;
        private RadioButton inquireProduceRadioButton;
        private RadioButton produceRadioButton;
        private RadioButton inquireRadioButton;
        private TextBox questionTextBox;
        private TextBox variableNameTextBox;
        private TableLayoutPanel okCancelPremisePanelTablePanel;
        private Button okAddingPremiseButton;
        private Button cancelAddingPremiseButton;
        private Panel okCancelAddingPremisePanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button createDomenButton;
    }
}