using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.View;
using Logic.Managers;

namespace MyProject
{
    public partial class ViewUsers : MaterialForm
    {
        private UserViewManager manager;
        private UserManager userManager;
        BindingSource source = new BindingSource();


        public ViewUsers(UserViewManager manager, UserManager userManager)
        {
            this.manager = manager;
            this.userManager = userManager;
            InitializeComponent();
            UpdateGridView();
            for (int i = 1; i < dgvUsers.Columns.Count; i++)
            {
                cbxFields.Items.Add(dgvUsers.Columns[i].HeaderText);
            }
            cbxFields.SelectedIndex = 0;
        }

        public void UpdateGridView()
        {
            dgvUsers.Rows.Clear();
            source.DataSource = typeof(UserView);
            foreach (var user in manager.GetAllUsersForView())
            {
                source.Add(user);
            }
            dgvUsers.DataSource = source;
            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void Filter()
        {
            var list = manager.GetAllUsersForView();
            List<UserView> filter;
            switch (cbxFields.SelectedItem.ToString())
            {
                case "FirstName":
                    dgvUsers.DataSource = source.DataSource;
                    filter = list.Where(x =>
                    x.FirstName.ToLower().Contains(tbxFilter.Text.ToLower())).ToList();
                    dgvUsers.DataSource = filter;
                    break;
                case "LastName":
                    dgvUsers.DataSource = source.DataSource;
                    filter = list.Where(x =>
                    x.LastName.ToLower().Contains(tbxFilter.Text.ToLower())).ToList();
                    dgvUsers.DataSource = filter;
                    break;
                case "Email":
                    dgvUsers.DataSource = source.DataSource;
                    filter = list.Where(x =>
                    x.Email.ToLower().Contains(tbxFilter.Text.ToLower())).ToList();
                    dgvUsers.DataSource = filter;
                    break;
                default:
                    dgvUsers.DataSource = source.DataSource;
                    filter = list.Where(x =>
                    x.FirstName.ToLower().Contains(tbxFilter.Text.ToLower())).ToList();
                    dgvUsers.DataSource = filter;
                    break;
            }
        }
        private void btnMakeAdmin_Click(object sender, EventArgs e)
        {
            var i = dgvUsers.CurrentCell.RowIndex;
            if (i != -1)
            {
                int userID = Convert.ToInt32(dgvUsers.Rows[i].Cells[0].Value);
                var user = userManager.GetUserById(userID);
                if (!user.IsAdmin)
                {
                    userManager.MakeAdmin(userID);
                    MessageBox.Show($"{user.FirstName} is now admin");
                }
                else if (user.IsAdmin)
                {
                    MessageBox.Show($"{user.FirstName} is already admin");
                }
                UpdateGridView();
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            var i = dgvUsers.CurrentCell.RowIndex;
            if (i != -1)
            {
                int userID = Convert.ToInt32(dgvUsers.Rows[i].Cells[0].Value);
                var user = userManager.GetUserById(userID);
                if (user.IsAdmin)
                {
                    MessageBox.Show($"{user.FirstName} is admin, Unable to block");
                }
                else
                {
                    if (!user.IsBlocked)
                    {
                        userManager.BlockUser(userID);
                        MessageBox.Show($"{user.FirstName} is now blocked");
                    }
                    else if (user.IsBlocked)
                    {
                        MessageBox.Show($"{user.FirstName} is already blocked");
                    }
                }
                UpdateGridView();
            }
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
