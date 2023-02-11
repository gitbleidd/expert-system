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
    public partial class DomainCreationForm : Form
    {
        public DomainCreationForm()
        {
            InitializeComponent();
        }

        private void addValueButton_Click(object sender, EventArgs e)
        {
            // TODO new value instance
        }

        private void editValueButton_Click(object sender, EventArgs e)
        {
            // TODO update domain's value string value
        }

        private void deleteValueButton_Click(object sender, EventArgs e)
        {
            if (dgvValues.SelectedRows.Count == 0)
                return;
            dgvValues.Rows.RemoveAt(dgvValues.SelectedRows[0].Index);
        }

        private void dgvValues_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvValues.SelectedRows.Count > 0)
            {
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

            int dragRow = dragRows[0].Index;
            int swapRow = hitInfo.RowIndex;

            updatedCopyOfDgvItems[dragRow] = dgvValues.Rows[swapRow];
            updatedCopyOfDgvItems[swapRow] = dgvValues.Rows[dragRow];
            dgvValues.Rows.Clear();
            dgvValues.Rows.AddRange(updatedCopyOfDgvItems);

            dgvValues.ClearSelection();
            dgvValues.Rows[swapRow].Selected = true;
        }
        #endregion

        private void domainValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dgvValues.SelectedRows.Count > 0 && 
                (domainValueTextBox.Text.Length == 0 || string.IsNullOrWhiteSpace(domainValueTextBox.Text)))
            {
                editValueButton.Enabled = false;
            }

            editValueButton.Enabled = true;
        }

        private void SetEditAndDeleteValueButtonStatus(bool status)
        {
            editValueButton.Enabled = status;
            deleteValueButton.Enabled = status;
        }
    }
}
