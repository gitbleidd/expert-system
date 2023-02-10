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
    public partial class RuleEditForm : Form
    {
        public RuleEditForm()
        {
            InitializeComponent();
            premiseListBox.Items.Add(new { ItemName = "1", Field = "field" });
            premiseListBox.Items.Add(new { ItemName = "2", Field = "field" });
            premiseListBox.Items.Add(new { ItemName = "3", Field = "field" });

            conclusionListBox.Items.Add(new { ItemName = "1", Field = "field" });
            conclusionListBox.Items.Add(new { ItemName = "2", Field = "field" });
            conclusionListBox.Items.Add(new { ItemName = "3", Field = "field" });

            // TODO auto-generated description
        }

        #region Premise buttons
        private void addPremiseButton_Click(object sender, EventArgs e)
        {
            var addingPremiseForm = new PremiseEditForm();
            addingPremiseForm.ShowDialog();
        }

        private void editPremiseButton_Click(object sender, EventArgs e)
        {
            // TODO new PremiseEditForm().ShowDialog(selectedPremise);
        }

        private void deletePremiseButton_Click(object sender, EventArgs e)
        {
            if (premiseListBox.SelectedItems.Count == 0)
                return;

            premiseListBox.Items.RemoveAt(premiseListBox.SelectedIndex);
        }
        #endregion

        #region Conclusion buttons
        private void addConclusionButton_Click(object sender, EventArgs e)
        {
            // TODO new ConclusionEditForm().ShowDialog(selectedPremise);
            // TODO get result from showDialog and add to list
            // TODO update conclusionListView
        }

        private void editConclusionButton_Click(object sender, EventArgs e)
        {
            // TODO new ConclusionEditForm().ShowDialog(selectedPremise);
        }

        private void deleteConclusionButton_Click(object sender, EventArgs e)
        {
            if (conclusionListBox.SelectedItems.Count == 0)
                return;

            conclusionListBox.Items.RemoveAt(conclusionListBox.SelectedIndex);
        }
        #endregion

        private void premiseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (premiseListBox.SelectedItems.Count > 0)
            {
                SetEditAndDeletePremiseButtonStatus(true);
            }
            else
            {
                SetEditAndDeletePremiseButtonStatus(false);
            }
        }

        private void SetEditAndDeletePremiseButtonStatus(bool status)
        {
            editPremiseButton.Enabled = status;
            deletePremiseButton.Enabled = status;
        }

        private void conclusionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conclusionListBox.SelectedItems.Count > 0)
            {
                SetEditAndDeleteConclusionButtonStatus(true);
            }
            else
            {
                SetEditAndDeleteConclusionButtonStatus(false);
            }
        }

        private void SetEditAndDeleteConclusionButtonStatus(bool status)
        {
            editConclusionButton.Enabled = status;
            deleteConclusionButton.Enabled = status;
        }
    }
}
