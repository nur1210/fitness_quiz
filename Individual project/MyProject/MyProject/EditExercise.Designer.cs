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
            this.lblSets.Location = new System.Drawing.Point(65, 299);
            this.lblSets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(108, 25);
            this.lblSets.TabIndex = 16;
            this.lblSets.Text = "No. of sets:";
            // 
            // lblReps
            // 
            this.lblReps.AutoSize = true;
            this.lblReps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReps.Location = new System.Drawing.Point(65, 225);
            this.lblReps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(111, 25);
            this.lblReps.TabIndex = 15;
            this.lblReps.Text = "No. of reps:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(65, 152);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 25);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Exercise name:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(179, 404);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(172, 59);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxSets
            // 
            this.tbxSets.Location = new System.Drawing.Point(224, 295);
            this.tbxSets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSets.Name = "tbxSets";
            this.tbxSets.Size = new System.Drawing.Size(244, 31);
            this.tbxSets.TabIndex = 12;
            // 
            // tbxReps
            // 
            this.tbxReps.Location = new System.Drawing.Point(224, 221);
            this.tbxReps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxReps.Name = "tbxReps";
            this.tbxReps.Size = new System.Drawing.Size(244, 31);
            this.tbxReps.TabIndex = 11;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(224, 149);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(244, 31);
            this.tbxName.TabIndex = 10;
            // 
            // EditExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 562);
            this.Controls.Add(this.lblSets);
            this.Controls.Add(this.lblReps);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbxSets);
            this.Controls.Add(this.tbxReps);
            this.Controls.Add(this.tbxName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditExercise";
            this.Padding = new System.Windows.Forms.Padding(4, 80, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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