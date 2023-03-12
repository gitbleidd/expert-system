namespace ExpertSystem.Forms
{
    partial class ExplanationForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.menuStripLeft = new System.Windows.Forms.MenuStrip();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderVariable = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderValue = new System.Windows.Forms.ColumnHeader();
            this.menuStripRight = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            this.splitContainer1.Panel1.Controls.Add(this.menuStripLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.listView);
            this.splitContainer1.Panel2.Controls.Add(this.menuStripRight);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 472;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 24);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(472, 426);
            this.treeView.TabIndex = 0;
            // 
            // menuStripLeft
            // 
            this.menuStripLeft.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripLeft.Location = new System.Drawing.Point(0, 0);
            this.menuStripLeft.Name = "menuStripLeft";
            this.menuStripLeft.Size = new System.Drawing.Size(472, 24);
            this.menuStripLeft.TabIndex = 1;
            this.menuStripLeft.Text = "menuStrip1";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderVariable,
            this.columnHeaderValue});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Location = new System.Drawing.Point(0, 24);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(324, 426);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderVariable
            // 
            this.columnHeaderVariable.Text = "Переменная";
            this.columnHeaderVariable.Width = 150;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Значение";
            this.columnHeaderValue.Width = 300;
            // 
            // menuStripRight
            // 
            this.menuStripRight.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripRight.Location = new System.Drawing.Point(0, 0);
            this.menuStripRight.Name = "menuStripRight";
            this.menuStripRight.Size = new System.Drawing.Size(324, 24);
            this.menuStripRight.TabIndex = 2;
            this.menuStripRight.Text = "menuStrip2";
            // 
            // ExplanationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ExplanationForm";
            this.Text = "ExplanationForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SplitContainer splitContainer1;
        private TreeView treeView;
        private MenuStrip menuStripLeft;
        private MenuStrip menuStripRight;
        private ListView listView;
        private ColumnHeader columnHeaderVariable;
        private ColumnHeader columnHeaderValue;
    }
}