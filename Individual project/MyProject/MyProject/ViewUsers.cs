using Logic.Managers;
using Logic.View;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class ViewUsers : MaterialForm
    {
        private readonly UserViewManager _manager;
        private readonly UserManager _userManager;
        private readonly BindingSource _source = new();


        public ViewUsers(UserViewManager manager, UserManager userManager)
        {
            _manager = manager;
            _userManager = userManager;
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
            _source.DataSource = typeof(UserView);
            foreach (var user in _manager.GetAllUsersForView())
            {
                _source.Add(user);
            }
            dgvUsers.DataSource = _source;
            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void Filter()
        {
            var list = _manager.GetAllUsersForView();
            List<UserView> filter;
            switch (cbxFields.SelectedItem.ToString())
            {
                case "FirstName":
                    dgvUsers.DataSource = _source.DataSource;
                    filter = list.Where(x =>
                    x.FirstName.ToLower().Contains(tbxFilter.Text.ToLower())).ToList();
                    dgvUsers.DataSource = filter;
                    break;
                case "LastName":
                    dgvUsers.DataSource = _source.DataSource;
                    filter = list.Where(x =>
                    x.LastName.ToLower().Contains(tbxFilter.Text.ToLower())).ToList();
                    dgvUsers.DataSource = filter;
                    break;
                case "Email":
                    dgvUsers.DataSource = _source.DataSource;
                    filter = list.Where(x =>
                    x.Email.ToLower().Contains(tbxFilter.Text.ToLower())).ToList();
                    dgvUsers.DataSource = filter;
                    break;
                default:
                    dgvUsers.DataSource = _source.DataSource;
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
                var user = _userManager.GetUserById(userID);
                if (!user.IsAdmin)
                {
                    _userManager.MakeAdmin(userID);
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
                var user = _userManager.GetUserById(userID);
                if (user.IsAdmin)
                {
                    MessageBox.Show($"{user.FirstName} is admin, Unable to block");
                }
                else
                {
                    if (!user.IsBlocked)
                    {
                        _userManager.BlockUser(userID);
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
