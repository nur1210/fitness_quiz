using MaterialSkin.Controls;
using ClassLibrary.Logic;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.View;

namespace MyProject
{
    public partial class ViewUsers : MaterialForm
    {
        private UserViewManager manager = new UserViewManager();
        private UserManager userManager = new UserManager();
        private DGVFunctions functions = new DGVFunctions();
        BindingSource source = new BindingSource();


        public ViewUsers()
        {
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
                if (!userManager.GetUserById(userID).IsAdmin)
                {
                    userManager.MakeAdmin(userID);
                    MessageBox.Show($"{userManager.GetUserById(userID).FirstName} is now admin");
                }
                else if (userManager.GetUserById(userID).IsAdmin)
                {
                    MessageBox.Show($"{userManager.GetUserById(userID).FirstName} is already admin");
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
                if (userManager.GetUserById(userID).IsAdmin)
                {
                    MessageBox.Show($"{userManager.GetUserById(userID).FirstName} is admin, Unable to block");
                }
                else
                {
                    if (!userManager.GetUserById(userID).IsBlocked)
                    {
                        userManager.BlockUser(userID);
                        MessageBox.Show($"{userManager.GetUserById(userID).FirstName} is now blocked");
                    }
                    else if (userManager.GetUserById(userID).IsBlocked)
                    {
                        MessageBox.Show($"{userManager.GetUserById(userID).FirstName} is already blocked");
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
