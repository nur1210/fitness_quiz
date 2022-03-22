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
            this.btnAdd.Location = new System.Drawing.Point(150, 473);
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
            this.dgvPrograms.Size = new System.Drawing.Size(562, 384);
            this.dgvPrograms.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(370, 473);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 34);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(262, 473);
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
            this.lbxExercises.Size = new System.Drawing.Size(216, 384);
            this.lbxExercises.TabIndex = 21;
            // 
            // ViewPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 515);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPrograms);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbxExercises);
            this.Name = "ViewPrograms";
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