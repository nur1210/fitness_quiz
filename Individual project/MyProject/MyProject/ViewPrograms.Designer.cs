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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPrograms = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbxExercises = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(188, 591);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 42);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPrograms
            // 
            this.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograms.Location = new System.Drawing.Point(54, 100);
            this.dgvPrograms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.RowHeadersWidth = 51;
            this.dgvPrograms.RowTemplate.Height = 29;
            this.dgvPrograms.Size = new System.Drawing.Size(702, 480);
            this.dgvPrograms.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(462, 591);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 42);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(328, 591);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 42);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbxExercises
            // 
            this.lbxExercises.FormattingEnabled = true;
            this.lbxExercises.ItemHeight = 25;
            this.lbxExercises.Location = new System.Drawing.Point(762, 100);
            this.lbxExercises.Margin = new System.Windows.Forms.Padding(2);
            this.lbxExercises.Name = "lbxExercises";
            this.lbxExercises.Size = new System.Drawing.Size(269, 479);
            this.lbxExercises.TabIndex = 21;
            // 
            // ViewPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPrograms);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbxExercises);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewPrograms";
            this.Padding = new System.Windows.Forms.Padding(4, 80, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPrograms";
            this.Load += new System.EventHandler(this.ViewPrograms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAdd;
        private DataGridView dgvPrograms;
        private Button btnDelete;
        private Button btnEdit;
        private ListBox lbxExercises;
    }
}