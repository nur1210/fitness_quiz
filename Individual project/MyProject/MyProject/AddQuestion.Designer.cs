namespace MyProject
{
    partial class AddQuestion
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.tbxAnswer4 = new System.Windows.Forms.TextBox();
            this.tbxAnswer3 = new System.Windows.Forms.TextBox();
            this.tbxAnswer2 = new System.Windows.Forms.TextBox();
            this.tbxAnswer1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(88, 109);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(80, 20);
            this.lblQuestion.TabIndex = 44;
            this.lblQuestion.Text = "Question :";
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(167, 106);
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(494, 27);
            this.tbxQuestion.TabIndex = 42;
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer4.Location = new System.Drawing.Point(88, 312);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(79, 20);
            this.lblAnswer4.TabIndex = 41;
            this.lblAnswer4.Text = "Answer 4:";
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer3.Location = new System.Drawing.Point(88, 260);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(79, 20);
            this.lblAnswer3.TabIndex = 40;
            this.lblAnswer3.Text = "Answer 3:";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer2.Location = new System.Drawing.Point(88, 210);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(79, 20);
            this.lblAnswer2.TabIndex = 39;
            this.lblAnswer2.Text = "Answer 2:";
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer1.Location = new System.Drawing.Point(88, 160);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(79, 20);
            this.lblAnswer1.TabIndex = 38;
            this.lblAnswer1.Text = "Answer 1:";
            // 
            // tbxAnswer4
            // 
            this.tbxAnswer4.Location = new System.Drawing.Point(167, 309);
            this.tbxAnswer4.Name = "tbxAnswer4";
            this.tbxAnswer4.Size = new System.Drawing.Size(494, 27);
            this.tbxAnswer4.TabIndex = 36;
            // 
            // tbxAnswer3
            // 
            this.tbxAnswer3.Location = new System.Drawing.Point(167, 257);
            this.tbxAnswer3.Name = "tbxAnswer3";
            this.tbxAnswer3.Size = new System.Drawing.Size(494, 27);
            this.tbxAnswer3.TabIndex = 35;
            // 
            // tbxAnswer2
            // 
            this.tbxAnswer2.Location = new System.Drawing.Point(167, 207);
            this.tbxAnswer2.Name = "tbxAnswer2";
            this.tbxAnswer2.Size = new System.Drawing.Size(494, 27);
            this.tbxAnswer2.TabIndex = 34;
            // 
            // tbxAnswer1
            // 
            this.tbxAnswer1.Location = new System.Drawing.Point(167, 157);
            this.tbxAnswer1.Name = "tbxAnswer1";
            this.tbxAnswer1.Size = new System.Drawing.Size(494, 27);
            this.tbxAnswer1.TabIndex = 33;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.HighEmphasis = true;
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(353, 375);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubmit.Size = new System.Drawing.Size(75, 36);
            this.btnSubmit.TabIndex = 45;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSubmit.UseAccentColor = false;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.tbxQuestion);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.tbxAnswer4);
            this.Controls.Add(this.tbxAnswer3);
            this.Controls.Add(this.tbxAnswer2);
            this.Controls.Add(this.tbxAnswer1);
            this.Name = "AddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblQuestion;
        private TextBox tbxQuestion;
        private Label lblAnswer4;
        private Label lblAnswer3;
        private Label lblAnswer2;
        private Label lblAnswer1;
        private TextBox tbxAnswer4;
        private TextBox tbxAnswer3;
        private TextBox tbxAnswer2;
        private TextBox tbxAnswer1;
        private MaterialSkin.Controls.MaterialButton btnSubmit;
    }
}