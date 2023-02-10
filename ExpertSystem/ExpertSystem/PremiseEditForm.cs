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
    public partial class PremiseEditForm : Form
    {
        public PremiseEditForm()
        {
            InitializeComponent();
        }

        private void createFactButton_Click(object sender, EventArgs e)
        {
            var variableCreationForm = new VariableCreationForm();
            variableCreationForm.ShowDialog();
        }
    }
}
