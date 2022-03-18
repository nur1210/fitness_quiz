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

namespace MyProject
{
    public partial class EditProgram : MaterialForm
    {
        public EditProgram()
        {
            InitializeComponent();
        }

        private void lbxPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxPrograms.SelectedIndex == -1)
            {
                btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
            }
        }

        private void EditProgram_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
