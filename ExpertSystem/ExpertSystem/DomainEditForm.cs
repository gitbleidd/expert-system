using ExpertSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class DomainEditForm : Form
    {
        private Domain Domain { get; }
        private ExpertSystemShell Shell { get; }

        private string _originalName;

        public DomainEditForm(ExpertSystemShell shell) : this(shell, new Domain(""))
        {
            this.Text = "Создание домена";
        }

        public DomainEditForm(ExpertSystemShell shell, Domain domain)
        {
            InitializeComponent();
            this.Text = "Изменение домена";
            _originalName = domain.Name;

            Domain = domain;
            Shell = shell;

            domainNameTextBox.Text = Domain.Name;
            foreach (var value in Domain.Values)
            {
                dgvValues.Rows.Add(value);
            }
        }

        private void addValueButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(domainValueTextBox.Text))
            {
                MessageBox.Show("Заполните поле значения!");
                return;
            }

            if (Domain.GetDomainValue(domainValueTextBox.Text) != null)
            {
                MessageBox.Show("В домене уже существует данное значение!");
                return;
            }

            var domainValue = new DomainValue(domainValueTextBox.Text);
            Domain.Values.Add(domainValue);
            dgvValues.Rows.Add(domainValue);
        }

        private void editValueButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(domainValueTextBox.Text))
            {
                MessageBox.Show("Заполните поле значения!");
                return;
            }

            if (Domain.GetDomainValue(domainValueTextBox.Text) != null)
            {
                MessageBox.Show("В домене уже существует данное значение!");
                return;
            }

            var selectedDomainValue = (DomainValue)dgvValues.SelectedRows[0].Cells[0].Value;
            selectedDomainValue.Value = domainValueTextBox.Text;
            
            dgvValues.Refresh();
        }

        private void deleteValueButton_Click(object sender, EventArgs e)
        {
            if (dgvValues.SelectedRows.Count == 0)
                return;

            int index = dgvValues.SelectedRows[0].Index;
            dgvValues.Rows.RemoveAt(index);
            Domain.Values.RemoveAt(index);
        }

        private void dgvValues_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvValues.SelectedRows.Count > 0)
            {
                var domain = dgvValues.SelectedRows[0].Cells[0].Value as DomainValue;
                if (domain == null)
                    return;
                
                domainValueTextBox.Text = domain.Value;
                SetEditAndDeleteValueButtonStatus(true);
            }
            else
            {
                SetEditAndDeleteValueButtonStatus(false);
            }
        }

        #region DGV - drag and drop
        private void dgvValues_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dgvValues.SelectedRows.Count > 0)
            {
                dgvValues.DoDragDrop(dgvValues.SelectedRows, DragDropEffects.Move);
            }
        }

        private void dgvValues_DragEnter(object sender, DragEventArgs e)
        {
            if (dgvValues.SelectedRows.Count > 0)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void dgvValues_DragDrop(object sender, DragEventArgs e)
        {
            var dragRows = e.Data.GetData(typeof(DataGridViewSelectedRowCollection))
                as DataGridViewSelectedRowCollection;

            if (dragRows == null || dragRows.Count <= 0 || dgvValues.Rows.Count <= 1)
                return;


            Point clientPoint = dgvValues.PointToClient(new Point(e.X, e.Y));
            var hitInfo = dgvValues.HitTest(clientPoint.X, clientPoint.Y);
            if (hitInfo.Type == DataGridViewHitTestType.None)
                return;

            var updatedCopyOfDgvItems = dgvValues.Rows.Cast<DataGridViewRow>().ToArray();

            int dragRowIndex = dragRows[0].Index;
            int swapRowIndex = hitInfo.RowIndex;

            var dragValue = Domain.Values[dragRowIndex];
            var swapValue = Domain.Values[swapRowIndex];

            dgvValues.Rows[dragRowIndex].Cells[0].Value = swapValue;
            dgvValues.Rows[swapRowIndex].Cells[0].Value = dragValue;

            Domain.Values[dragRowIndex] = swapValue;
            Domain.Values[swapRowIndex] = dragValue;
            
            dgvValues.Refresh();

            dgvValues.ClearSelection();
            dgvValues.Rows[swapRowIndex].Selected = true;
        }
        #endregion

        private void domainValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dgvValues.SelectedRows.Count == 0 || 
                (domainValueTextBox.Text.Length == 0 || string.IsNullOrWhiteSpace(domainValueTextBox.Text)))
            {
                editValueButton.Enabled = false;
                return;
            }

            editValueButton.Enabled = true;
        }

        private void SetEditAndDeleteValueButtonStatus(bool status)
        {
            editValueButton.Enabled = status;
            deleteValueButton.Enabled = status;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Domain.Values.Count == 0)
            {
                MessageBox.Show("Домен должен содержать более одного значения!");
                return;
            }

            if (string.IsNullOrWhiteSpace(domainNameTextBox.Text))
            {
                MessageBox.Show("Заполните имя домена!");
                return;
            }

            bool domainExist = _originalName != domainNameTextBox.Text && Shell.GetDomainByName(domainNameTextBox.Text) != null;

            if (domainExist)
            {
                MessageBox.Show("Домен с таким именем уже сущестует!");
                return;
            }

            Domain.Name = domainNameTextBox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
