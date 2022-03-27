namespace MyProject
{
    partial class AddExercises
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxReps = new System.Windows.Forms.TextBox();
            this.tbxSets = new System.Windows.Forms.TextBox();
            this.lbxExercises = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReps = new System.Windows.Forms.Label();
            this.lblSets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(178, 94);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(196, 27);
            this.tbxName.TabIndex = 0;
            // 
            // tbxReps
            // 
            this.tbxReps.Location = new System.Drawing.Point(178, 152);
            this.tbxReps.Name = "tbxReps";
            this.tbxReps.Size = new System.Drawing.Size(196, 27);
            this.tbxReps.TabIndex = 1;
            // 
            // tbxSets
            // 
            this.tbxSets.Location = new System.Drawing.Point(178, 211);
            this.tbxSets.Name = "tbxSets";
            this.tbxSets.Size = new System.Drawing.Size(196, 27);
            this.tbxSets.TabIndex = 2;
            // 
            // lbxExercises
            // 
            this.lbxExercises.FormattingEnabled = true;
            this.lbxExercises.ItemHeight = 20;
            this.lbxExercises.Location = new System.Drawing.Point(478, 68);
            this.lbxExercises.Name = "lbxExercises";
            this.lbxExercises.Size = new System.Drawing.Size(263, 264);
            this.lbxExercises.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(199, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 47);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add exercise";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(539, 366);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(138, 47);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(51, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Exercise name:";
            // 
            // lblReps
            // 
            this.lblReps.AutoSize = true;
            this.lblReps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReps.Location = new System.Drawing.Point(51, 155);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(91, 20);
            this.lblReps.TabIndex = 8;
            this.lblReps.Text = "No. of reps:";
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = true;
            this.lblSets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSets.Location = new System.Drawing.Point(51, 214);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(89, 20);
            this.lblSets.TabIndex = 9;
            this.lblSets.Text = "No. of sets:";
            // 
            // AddExercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.lblSets);
            this.Controls.Add(this.lblReps);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxExercises);
            this.Controls.Add(this.tbxSets);
            this.Controls.Add(this.tbxReps);
            this.Controls.Add(this.tbxName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddExercises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExercises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxName;
        private TextBox tbxReps;
        private TextBox tbxSets;
        private ListBox lbxExercises;
        private Button btnAdd;
        private Button btnComplete;
        private Label lblName;
        private Label lblReps;
        private Label lblSets;
    }
}