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
    public partial class VariableCreationForm : Form
    {
        public VariableCreationForm()
        {
            InitializeComponent();
            // TODO auto generate question text
        }

        private void createDomenButton_Click(object sender, EventArgs e)
        {
            var domenCreationForm = new DomenCreationForm();
            domenCreationForm.ShowDialog();
        }

        private void domenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void questionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void variableNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void okCancelAddingPremisePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
