namespace MyProject
{
    partial class EditExercise
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
            this.lblSets = new System.Windows.Forms.Label();
            this.lblReps = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.tbxSets = new System.Windows.Forms.TextBox();
            this.tbxReps = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = true;
            this.lblSets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSets.Location = new System.Drawing.Point(52, 239);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(89, 20);
            this.lblSets.TabIndex = 16;
            this.lblSets.Text = "No. of sets:";
            // 
            // lblReps
            // 
            this.lblReps.AutoSize = true;
            this.lblReps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReps.Location = new System.Drawing.Point(52, 180);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(91, 20);
            this.lblReps.TabIndex = 15;
            this.lblReps.Text = "No. of reps:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(52, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 20);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Exercise name:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(143, 323);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(138, 47);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxSets
            // 
            this.tbxSets.Location = new System.Drawing.Point(179, 236);
            this.tbxSets.Name = "tbxSets";
            this.tbxSets.Size = new System.Drawing.Size(196, 27);
            this.tbxSets.TabIndex = 12;
            // 
            // tbxReps
            // 
            this.tbxReps.Location = new System.Drawing.Point(179, 177);
            this.tbxReps.Name = "tbxReps";
            this.tbxReps.Size = new System.Drawing.Size(196, 27);
            this.tbxReps.TabIndex = 11;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(179, 119);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(196, 27);
            this.tbxName.TabIndex = 10;
            // 
            // EditExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.lblSets);
            this.Controls.Add(this.lblReps);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbxSets);
            this.Controls.Add(this.tbxReps);
            this.Controls.Add(this.tbxName);
            this.Name = "EditExercise";
            this.Text = "EditExercise";
            this.Load += new System.EventHandler(this.EditExercise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSets;
        private Label lblReps;
        private Label lblName;
        private Button btnChange;
        private TextBox tbxSets;
        private TextBox tbxReps;
        private TextBox tbxName;
    }
}