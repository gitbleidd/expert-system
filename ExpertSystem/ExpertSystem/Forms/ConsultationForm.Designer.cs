namespace ExpertSystem.Forms
{
    partial class ConsultationForm
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
            this.consultationGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.okConsultButton = new System.Windows.Forms.Button();
            this.consultationComboBox = new System.Windows.Forms.ComboBox();
            this.consultationDgv = new System.Windows.Forms.DataGridView();
            this.ConsultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultationDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // consultationGroupBox
            // 
            this.consultationGroupBox.Controls.Add(this.groupBox1);
            this.consultationGroupBox.Controls.Add(this.consultationComboBox);
            this.consultationGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consultationGroupBox.Location = new System.Drawing.Point(0, 352);
            this.consultationGroupBox.Name = "consultationGroupBox";
            this.consultationGroupBox.Size = new System.Drawing.Size(483, 98);
            this.consultationGroupBox.TabIndex = 2;
            this.consultationGroupBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.okConsultButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(477, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // okConsultButton
            // 
            this.okConsultButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okConsultButton.Location = new System.Drawing.Point(3, 19);
            this.okConsultButton.Name = "okConsultButton";
            this.okConsultButton.Size = new System.Drawing.Size(469, 25);
            this.okConsultButton.TabIndex = 0;
            this.okConsultButton.Text = "OK";
            this.okConsultButton.UseVisualStyleBackColor = true;
            this.okConsultButton.Click += new System.EventHandler(this.okConsultButton_Click);
            // 
            // consultationComboBox
            // 
            this.consultationComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consultationComboBox.FormattingEnabled = true;
            this.consultationComboBox.Location = new System.Drawing.Point(3, 19);
            this.consultationComboBox.Name = "consultationComboBox";
            this.consultationComboBox.Size = new System.Drawing.Size(477, 23);
            this.consultationComboBox.TabIndex = 1;
            // 
            // consultationDgv
            // 
            this.consultationDgv.AllowUserToAddRows = false;
            this.consultationDgv.AllowUserToDeleteRows = false;
            this.consultationDgv.AllowUserToResizeColumns = false;
            this.consultationDgv.AllowUserToResizeRows = false;
            this.consultationDgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.consultationDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consultationDgv.CausesValidation = false;
            this.consultationDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.consultationDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultationDgv.ColumnHeadersVisible = false;
            this.consultationDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsultColumn});
            this.consultationDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultationDgv.Location = new System.Drawing.Point(0, 0);
            this.consultationDgv.MultiSelect = false;
            this.consultationDgv.Name = "consultationDgv";
            this.consultationDgv.ReadOnly = true;
            this.consultationDgv.RowHeadersVisible = false;
            this.consultationDgv.RowTemplate.Height = 25;
            this.consultationDgv.Size = new System.Drawing.Size(483, 352);
            this.consultationDgv.TabIndex = 3;
            // 
            // ConsultColumn
            // 
            this.ConsultColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConsultColumn.HeaderText = "ConsultColumn";
            this.ConsultColumn.Name = "ConsultColumn";
            this.ConsultColumn.ReadOnly = true;
            this.ConsultColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.consultationDgv);
            this.Controls.Add(this.consultationGroupBox);
            this.Name = "ConsultationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Консультация";
            this.consultationGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consultationDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox consultationGroupBox;
        private GroupBox groupBox1;
        private Button okConsultButton;
        private ComboBox consultationComboBox;
        private DataGridView consultationDgv;
        private DataGridViewTextBoxColumn ConsultColumn;
    }
}