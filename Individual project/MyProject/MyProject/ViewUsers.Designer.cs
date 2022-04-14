namespace WinFormApp
{
    partial class ViewUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnBlock = new MaterialSkin.Controls.MaterialButton();
            this.btnMakeAdmin = new MaterialSkin.Controls.MaterialButton();
            this.tbxFilter = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxFields = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(60, 100);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 29;
            this.dgvUsers.Size = new System.Drawing.Size(868, 385);
            this.dgvUsers.TabIndex = 0;
            // 
            // btnBlock
            // 
            this.btnBlock.AutoEllipsis = true;
            this.btnBlock.AutoSize = false;
            this.btnBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBlock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBlock.Depth = 0;
            this.btnBlock.HighEmphasis = true;
            this.btnBlock.Icon = null;
            this.btnBlock.Location = new System.Drawing.Point(850, 507);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBlock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBlock.Size = new System.Drawing.Size(123, 36);
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Block user";
            this.btnBlock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBlock.UseAccentColor = false;
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnMakeAdmin
            // 
            this.btnMakeAdmin.AutoSize = false;
            this.btnMakeAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMakeAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMakeAdmin.Depth = 0;
            this.btnMakeAdmin.HighEmphasis = true;
            this.btnMakeAdmin.Icon = null;
            this.btnMakeAdmin.Location = new System.Drawing.Point(704, 507);
            this.btnMakeAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMakeAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMakeAdmin.Name = "btnMakeAdmin";
            this.btnMakeAdmin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMakeAdmin.Size = new System.Drawing.Size(123, 36);
            this.btnMakeAdmin.TabIndex = 3;
            this.btnMakeAdmin.Text = "Make Admin";
            this.btnMakeAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMakeAdmin.UseAccentColor = false;
            this.btnMakeAdmin.UseVisualStyleBackColor = true;
            this.btnMakeAdmin.Click += new System.EventHandler(this.btnMakeAdmin_Click);
            // 
            // tbxFilter
            // 
            this.tbxFilter.AnimateReadOnly = false;
            this.tbxFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFilter.Depth = 0;
            this.tbxFilter.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbxFilter.LeadingIcon = null;
            this.tbxFilter.Location = new System.Drawing.Point(258, 500);
            this.tbxFilter.MaxLength = 50;
            this.tbxFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.tbxFilter.Multiline = false;
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(179, 50);
            this.tbxFilter.TabIndex = 4;
            this.tbxFilter.Text = "";
            this.tbxFilter.TrailingIcon = null;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // cbxFields
            // 
            this.cbxFields.AutoResize = false;
            this.cbxFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxFields.Depth = 0;
            this.cbxFields.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxFields.DropDownHeight = 174;
            this.cbxFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFields.DropDownWidth = 121;
            this.cbxFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxFields.FormattingEnabled = true;
            this.cbxFields.IntegralHeight = false;
            this.cbxFields.ItemHeight = 43;
            this.cbxFields.Location = new System.Drawing.Point(59, 499);
            this.cbxFields.MaxDropDownItems = 4;
            this.cbxFields.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxFields.Name = "cbxFields";
            this.cbxFields.Size = new System.Drawing.Size(182, 49);
            this.cbxFields.StartIndex = 0;
            this.cbxFields.TabIndex = 5;
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.cbxFields);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.btnMakeAdmin);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.dgvUsers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewUsers";
            this.Padding = new System.Windows.Forms.Padding(4, 80, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvUsers;
        private MaterialSkin.Controls.MaterialButton btnBlock;
        private MaterialSkin.Controls.MaterialButton btnMakeAdmin;
        private MaterialSkin.Controls.MaterialTextBox tbxFilter;
        private MaterialSkin.Controls.MaterialComboBox cbxFields;
    }
}