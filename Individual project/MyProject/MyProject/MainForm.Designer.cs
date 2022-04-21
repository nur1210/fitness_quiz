namespace WinFormApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewQuestion = new MaterialSkin.Controls.MaterialButton();
            this.btnViewPrograms = new MaterialSkin.Controls.MaterialButton();
            this.btnViewUsers = new MaterialSkin.Controls.MaterialButton();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.lblTotalPrograms = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewQuestion
            // 
            this.btnViewQuestion.AutoSize = false;
            this.btnViewQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewQuestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnViewQuestion.Depth = 0;
            this.btnViewQuestion.HighEmphasis = true;
            this.btnViewQuestion.Icon = null;
            this.btnViewQuestion.Location = new System.Drawing.Point(22, 57);
            this.btnViewQuestion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewQuestion.Name = "btnViewQuestion";
            this.btnViewQuestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnViewQuestion.Size = new System.Drawing.Size(140, 36);
            this.btnViewQuestion.TabIndex = 18;
            this.btnViewQuestion.Text = "view questions";
            this.btnViewQuestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnViewQuestion.UseAccentColor = false;
            this.btnViewQuestion.UseVisualStyleBackColor = true;
            this.btnViewQuestion.Click += new System.EventHandler(this.btnViewQuestion_Click);
            // 
            // btnViewPrograms
            // 
            this.btnViewPrograms.AutoSize = false;
            this.btnViewPrograms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewPrograms.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnViewPrograms.Depth = 0;
            this.btnViewPrograms.HighEmphasis = true;
            this.btnViewPrograms.Icon = null;
            this.btnViewPrograms.Location = new System.Drawing.Point(21, 123);
            this.btnViewPrograms.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewPrograms.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewPrograms.Name = "btnViewPrograms";
            this.btnViewPrograms.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnViewPrograms.Size = new System.Drawing.Size(141, 36);
            this.btnViewPrograms.TabIndex = 19;
            this.btnViewPrograms.Text = "view programs";
            this.btnViewPrograms.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnViewPrograms.UseAccentColor = false;
            this.btnViewPrograms.UseVisualStyleBackColor = true;
            this.btnViewPrograms.Click += new System.EventHandler(this.btnViewPrograms_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.AutoSize = false;
            this.btnViewUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewUsers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnViewUsers.Depth = 0;
            this.btnViewUsers.HighEmphasis = true;
            this.btnViewUsers.Icon = null;
            this.btnViewUsers.Location = new System.Drawing.Point(21, 186);
            this.btnViewUsers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnViewUsers.Size = new System.Drawing.Size(141, 36);
            this.btnViewUsers.TabIndex = 20;
            this.btnViewUsers.Text = "view users";
            this.btnViewUsers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnViewUsers.UseAccentColor = false;
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click_1);
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalQuestions.Location = new System.Drawing.Point(48, 478);
            this.lblTotalQuestions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(147, 28);
            this.lblTotalQuestions.TabIndex = 14;
            this.lblTotalQuestions.Text = "Total questions:";
            // 
            // lblTotalPrograms
            // 
            this.lblTotalPrograms.AutoSize = true;
            this.lblTotalPrograms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrograms.Location = new System.Drawing.Point(345, 478);
            this.lblTotalPrograms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrograms.Name = "lblTotalPrograms";
            this.lblTotalPrograms.Size = new System.Drawing.Size(148, 28);
            this.lblTotalPrograms.TabIndex = 15;
            this.lblTotalPrograms.Text = "Total programs:";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalUsers.Location = new System.Drawing.Point(678, 478);
            this.lblTotalUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(107, 28);
            this.lblTotalUsers.TabIndex = 11;
            this.lblTotalUsers.Text = "Total users:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnViewUsers);
            this.panel1.Controls.Add(this.btnViewQuestion);
            this.panel1.Controls.Add(this.btnViewPrograms);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 531);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalUsers);
            this.panel2.Controls.Add(this.lblTotalQuestions);
            this.panel2.Controls.Add(this.lblTotalPrograms);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(189, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 531);
            this.panel2.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1097, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnViewQuestion;
        private MaterialSkin.Controls.MaterialButton btnViewPrograms;
        private MaterialSkin.Controls.MaterialButton btnViewUsers;
        private Label lblTotalQuestions;
        private Label lblTotalPrograms;
        private Label lblTotalUsers;
        private Panel panel1;
        private Panel panel2;
    }
}