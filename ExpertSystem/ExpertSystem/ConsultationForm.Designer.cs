namespace ExpertSystem
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
            this.consultationComboBox = new System.Windows.Forms.ComboBox();
            this.consultationListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.okConsultButton = new System.Windows.Forms.Button();
            this.consultationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // consultationComboBox
            // 
            this.consultationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.consultationComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultationComboBox.FormattingEnabled = true;
            this.consultationComboBox.Location = new System.Drawing.Point(3, 19);
            this.consultationComboBox.Name = "consultationComboBox";
            this.consultationComboBox.Size = new System.Drawing.Size(477, 23);
            this.consultationComboBox.TabIndex = 1;
            // 
            // consultationListBox
            // 
            this.consultationListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultationListBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consultationListBox.FormattingEnabled = true;
            this.consultationListBox.ItemHeight = 30;
            this.consultationListBox.Location = new System.Drawing.Point(0, 0);
            this.consultationListBox.Name = "consultationListBox";
            this.consultationListBox.Size = new System.Drawing.Size(483, 352);
            this.consultationListBox.TabIndex = 3;
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
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.consultationListBox);
            this.Controls.Add(this.consultationGroupBox);
            this.Name = "ConsultationForm";
            this.Text = "Консультация";
            this.consultationGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox consultationGroupBox;
        private GroupBox groupBox1;
        private Button okConsultButton;
        private ComboBox consultationComboBox;
        private ListBox consultationListBox;
    }
}