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
        }

        private void addPremiseButton_Click(object sender, EventArgs e)
        {
            var addingPremiseForm = new PremiseAddForm();
            addingPremiseForm.ShowDialog();
        }
    }
}
