namespace ExpertSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dgvRules.Rows.Add(new string[] { "Orange-Salsa Pork Chops", "Main Dish" });
            dgvRules.Rows.Add(new string[] { "Other", "Stuff" });
            dgvRules.Rows.Add(new string[] { "Hmm", "Testing datagrid view rules" });

            listViewRules.Items.Add(new ListViewItem(new string[] { "1", "1" }));
            listViewRules.Items.Add(new ListViewItem(new string[] { "2", "2" }));
            listViewRules.Items.Add(new ListViewItem(new string[] { "3", "3" }));
        }

        private void addRuleButton_Click(object sender, EventArgs e)
        {
            var ruleEditForm = new RuleEditForm();
            ruleEditForm.ShowDialog();
        }

        private void listViewRules_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (listViewRules.SelectedItems.Count > 0)
            {
                var listViewItem = listViewRules.SelectedItems[0];
                listViewRules.DoDragDrop(listViewItem, DragDropEffects.Move);
            }
        }

        private void listViewRules_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var selectedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

                Point clientPoint = listViewRules.PointToClient(new Point(e.X, e.Y));
                ListViewItem itemAtMouse = listViewRules.GetItemAt(clientPoint.X, clientPoint.Y);

                if (itemAtMouse == null || e.Effect != DragDropEffects.Move)
                {
                    return;
                }

                int selectedItemIndex = selectedItem.Index;
                int itemAtMouseIndex = itemAtMouse.Index;

                var listWithSwappedItems = listViewRules.Items.Cast<ListViewItem>().ToArray();
                listWithSwappedItems[selectedItemIndex] = itemAtMouse;
                listWithSwappedItems[itemAtMouseIndex] = selectedItem;
                listViewRules.Items.Clear();
                listViewRules.Items.AddRange(listWithSwappedItems);
            }
        }

        private void listViewRules_DragEnter(object sender, DragEventArgs e)
        {
            if (listViewRules.SelectedItems.Count > 0)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void dgvRules_DragEnter(object sender, DragEventArgs e)
        {
            if (dgvRules.SelectedRows.Count > 0)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void dgvRules_DragDrop(object sender, DragEventArgs e)
        {

            var dragRows = e.Data.GetData(typeof(DataGridViewSelectedRowCollection))
                as DataGridViewSelectedRowCollection;

            if (dragRows == null || dragRows.Count <= 0 || dgvRules.Rows.Count <= 1)
                return;


            Point clientPoint = dgvRules.PointToClient(new Point(e.X, e.Y));
            //var hitInfo = dgvRules.HitTest(e.X, e.Y);
            var hitInfo = dgvRules.HitTest(clientPoint.X, clientPoint.Y);
            if (hitInfo.Type == DataGridViewHitTestType.None)
                return;

            var updatedCopyOfDgvItems = dgvRules.Rows.Cast<DataGridViewRow>().ToArray();

            int dragRow = dragRows[0].Index;
            int swapRow = hitInfo.RowIndex;

            updatedCopyOfDgvItems[dragRow] = dgvRules.Rows[swapRow];
            updatedCopyOfDgvItems[swapRow] = dgvRules.Rows[dragRow];
            dgvRules.Rows.Clear();
            dgvRules.Rows.AddRange(updatedCopyOfDgvItems);

            dgvRules.ClearSelection();
            dgvRules.Rows[swapRow].Selected = true;
        }

        private void dgvRules_DragOver(object sender, DragEventArgs e) { }

        private void dgvRules_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dgvRules.SelectedRows.Count > 0)
            {
                dgvRules.DoDragDrop(dgvRules.SelectedRows, DragDropEffects.Move);
            }
        }
    }
}