using System;
using System.Data;
using System.Windows.Forms;
using Contact.Model;
using Contact.CRUD;

namespace Contact.UserControls
{
    public partial class ctrlGroup : UserControl
    {
        GroupCRUD gc = new GroupCRUD();
        public ctrlGroup()
        {
            InitializeComponent();
            LoadGroup();
            dgvGroup.Columns[2].Width = 70;
            dgvGroup.MultiSelect = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGroup.Text))
            {
                Group g = new Group
                {
                    Name = txtGroup.Text
                };
                gc.Add(g);
                LoadGroup();
                txtGroup.Text = "";
                txtGroup.Focus();
            }
        }

        private void LoadGroup()
        {
            DataTable tbl = gc.GetAllGroup();
            dgvGroup.DataSource = tbl;
            dgvGroup.Columns["Id"].Visible = false;
        }

        private void dgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex == 2)
            {
                string group = dgvGroup.Rows[e.RowIndex].Cells[1].Value.ToString();
                string msg = string.Format("Are you sure? {0}You want to delete {1} group?", Environment.NewLine, group);
                if (MessageBox.Show(msg, "My Contact", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvGroup.Rows[e.RowIndex].Cells[0].Value.ToString());
                    gc.Delete(id);
                    MessageBox.Show("Group Delete", "My Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGroup();
                }
            }
        }

        private void txtGroup_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
