namespace ExpertSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.rulesPage = new System.Windows.Forms.TabPage();
            this.variablesPage = new System.Windows.Forms.TabPage();
            this.domensPage = new System.Windows.Forms.TabPage();
            this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripConsult = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.beginConsultToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.explainToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.toolStripConsult});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.rulesPage);
            this.tabControl.Controls.Add(this.variablesPage);
            this.tabControl.Controls.Add(this.domensPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 426);
            this.tabControl.TabIndex = 1;
            // 
            // rulesPage
            // 
            this.rulesPage.Location = new System.Drawing.Point(4, 24);
            this.rulesPage.Name = "rulesPage";
            this.rulesPage.Padding = new System.Windows.Forms.Padding(3);
            this.rulesPage.Size = new System.Drawing.Size(792, 398);
            this.rulesPage.TabIndex = 0;
            this.rulesPage.Text = "Правила";
            this.rulesPage.UseVisualStyleBackColor = true;
            // 
            // variablesPage
            // 
            this.variablesPage.Location = new System.Drawing.Point(4, 24);
            this.variablesPage.Name = "variablesPage";
            this.variablesPage.Padding = new System.Windows.Forms.Padding(3);
            this.variablesPage.Size = new System.Drawing.Size(792, 395);
            this.variablesPage.TabIndex = 1;
            this.variablesPage.Text = "Переменные";
            this.variablesPage.UseVisualStyleBackColor = true;
            // 
            // domensPage
            // 
            this.domensPage.Location = new System.Drawing.Point(4, 24);
            this.domensPage.Name = "domensPage";
            this.domensPage.Padding = new System.Windows.Forms.Padding(3);
            this.domensPage.Size = new System.Drawing.Size(792, 395);
            this.domensPage.TabIndex = 2;
            this.domensPage.Text = "Домены";
            this.domensPage.UseVisualStyleBackColor = true;
            // 
            // toolStripFile
            // 
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStrip,
            this.openToolStrip,
            this.saveToolStrip,
            this.saveAsToolStrip});
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(48, 20);
            this.toolStripFile.Text = "Файл";
            // 
            // toolStripConsult
            // 
            this.toolStripConsult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginConsultToolStrip,
            this.explainToolStrip});
            this.toolStripConsult.Name = "toolStripConsult";
            this.toolStripConsult.Size = new System.Drawing.Size(96, 20);
            this.toolStripConsult.Text = "Консультация";
            // 
            // newToolStrip
            // 
            this.newToolStrip.Name = "newToolStrip";
            this.newToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStrip.Size = new System.Drawing.Size(235, 22);
            this.newToolStrip.Text = "Новый...";
            // 
            // openToolStrip
            // 
            this.openToolStrip.Name = "openToolStrip";
            this.openToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStrip.Size = new System.Drawing.Size(235, 22);
            this.openToolStrip.Text = "Открыть...";
            // 
            // saveToolStrip
            // 
            this.saveToolStrip.Name = "saveToolStrip";
            this.saveToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStrip.Size = new System.Drawing.Size(235, 22);
            this.saveToolStrip.Text = "Сохранить";
            // 
            // saveAsToolStrip
            // 
            this.saveAsToolStrip.Name = "saveAsToolStrip";
            this.saveAsToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStrip.Size = new System.Drawing.Size(235, 22);
            this.saveAsToolStrip.Text = "Сохранить как...";
            // 
            // beginConsultToolStrip
            // 
            this.beginConsultToolStrip.Name = "beginConsultToolStrip";
            this.beginConsultToolStrip.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.beginConsultToolStrip.Size = new System.Drawing.Size(228, 22);
            this.beginConsultToolStrip.Text = "Начать консультацию";
            // 
            // explainToolStrip
            // 
            this.explainToolStrip.Name = "explainToolStrip";
            this.explainToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.explainToolStrip.Size = new System.Drawing.Size(228, 22);
            this.explainToolStrip.Text = "Покать объяснение";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenuStrip;
        private TabControl tabControl;
        private TabPage rulesPage;
        private TabPage variablesPage;
        private TabPage domensPage;
        private ToolStripMenuItem toolStripFile;
        private ToolStripMenuItem toolStripConsult;
        private ToolStripMenuItem newToolStrip;
        private ToolStripMenuItem openToolStrip;
        private ToolStripMenuItem saveToolStrip;
        private ToolStripMenuItem saveAsToolStrip;
        private ToolStripMenuItem beginConsultToolStrip;
        private ToolStripMenuItem explainToolStrip;
    }
}