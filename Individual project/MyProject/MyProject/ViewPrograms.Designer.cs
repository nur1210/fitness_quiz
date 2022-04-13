using Logic.Managers;

namespace MyProject
{
    partial class ViewPrograms
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPrograms = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbxExercises = new System.Windows.Forms.ListBox();
            this.btnReference = new MaterialSkin.Controls.MaterialButton();
            this.btnRemoveReference = new MaterialSkin.Controls.MaterialButton();
            this.questionManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAssigned = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(81, 472);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 34);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPrograms
            // 
            this.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograms.Location = new System.Drawing.Point(43, 80);
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.RowHeadersWidth = 51;
            this.dgvPrograms.RowTemplate.Height = 29;
            this.dgvPrograms.Size = new System.Drawing.Size(562, 344);
            this.dgvPrograms.TabIndex = 24;
            this.dgvPrograms.SelectionChanged += new System.EventHandler(this.dgvPrograms_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(301, 472);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 34);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(193, 472);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 34);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbxExercises
            // 
            this.lbxExercises.FormattingEnabled = true;
            this.lbxExercises.ItemHeight = 20;
            this.lbxExercises.Location = new System.Drawing.Point(610, 80);
            this.lbxExercises.Margin = new System.Windows.Forms.Padding(2);
            this.lbxExercises.Name = "lbxExercises";
            this.lbxExercises.Size = new System.Drawing.Size(216, 344);
            this.lbxExercises.TabIndex = 21;
            // 
            // btnReference
            // 
            this.btnReference.AutoSize = false;
            this.btnReference.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReference.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReference.Depth = 0;
            this.btnReference.HighEmphasis = true;
            this.btnReference.Icon = null;
            this.btnReference.Location = new System.Drawing.Point(648, 472);
            this.btnReference.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReference.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReference.Name = "btnReference";
            this.btnReference.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReference.Size = new System.Drawing.Size(162, 34);
            this.btnReference.TabIndex = 26;
            this.btnReference.Text = "Add reference";
            this.btnReference.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReference.UseAccentColor = false;
            this.btnReference.UseVisualStyleBackColor = true;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // btnRemoveReference
            // 
            this.btnRemoveReference.AutoSize = false;
            this.btnRemoveReference.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveReference.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemoveReference.Depth = 0;
            this.btnRemoveReference.HighEmphasis = true;
            this.btnRemoveReference.Icon = null;
            this.btnRemoveReference.Location = new System.Drawing.Point(478, 472);
            this.btnRemoveReference.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveReference.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveReference.Name = "btnRemoveReference";
            this.btnRemoveReference.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemoveReference.Size = new System.Drawing.Size(162, 34);
            this.btnRemoveReference.TabIndex = 27;
            this.btnRemoveReference.Text = "Remove reference";
            this.btnRemoveReference.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemoveReference.UseAccentColor = false;
            this.btnRemoveReference.UseVisualStyleBackColor = true;
            this.btnRemoveReference.Visible = false;
            this.btnRemoveReference.Click += new System.EventHandler(this.btnRemoveReference_Click);
            // 
            // questionManagerBindingSource
            // 
            this.questionManagerBindingSource.DataSource = typeof(QuestionManager);
            // 
            // lblAssigned
            // 
            this.lblAssigned.AutoSize = true;
            this.lblAssigned.Depth = 0;
            this.lblAssigned.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAssigned.Location = new System.Drawing.Point(43, 442);
            this.lblAssigned.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(107, 19);
            this.lblAssigned.TabIndex = 28;
            this.lblAssigned.Text = "materialLabel1";
            this.lblAssigned.Visible = false;
            // 
            // ViewPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 515);
            this.Controls.Add(this.lblAssigned);
            this.Controls.Add(this.btnRemoveReference);
            this.Controls.Add(this.btnReference);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPrograms);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbxExercises);
            this.Name = "ViewPrograms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPrograms";
            this.Load += new System.EventHandler(this.ViewPrograms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private DataGridView dgvPrograms;
        private Button btnDelete;
        private Button btnEdit;
        private ListBox lbxExercises;
        private MaterialSkin.Controls.MaterialButton btnReference;
        private MaterialSkin.Controls.MaterialButton btnRemoveReference;
        private BindingSource questionManagerBindingSource;
        private MaterialSkin.Controls.MaterialLabel lblAssigned;
    }
}