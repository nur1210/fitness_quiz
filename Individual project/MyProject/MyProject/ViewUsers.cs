using MyProject.ManagerServices;
using MyProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class ViewUsers : Form
    {
        private UserViewManager manager = new UserViewManager();
        private DGVFunctions functions = new DGVFunctions();

        public ViewUsers()
        {
            InitializeComponent();
        }

        public void UpdateGridView()
        {
            BindingSource source = new BindingSource();

            dgvUsers.Rows.Clear();
            source.DataSource = typeof(UserView);
            foreach (var user in manager.GetAllUsersForView())
            {
                source.Add(user);
            }
            dgvUsers.DataSource = source;
            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.Columns.Add(DGVFunctions.Edit());
            dgvUsers.Columns.Add(DGVFunctions.Delete());
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void UsersView_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
