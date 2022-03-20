namespace MyProject
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
            this.gbxStatistics = new System.Windows.Forms.GroupBox();
            this.lblFemales = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.lbl60Plus = new System.Windows.Forms.Label();
            this.lbl5060 = new System.Windows.Forms.Label();
            this.lbl4050 = new System.Windows.Forms.Label();
            this.lbl3040 = new System.Windows.Forms.Label();
            this.lbl2030 = new System.Windows.Forms.Label();
            this.lblUnder20 = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.lblTotalPrograms = new System.Windows.Forms.Label();
            this.btnViewQuestion = new MaterialSkin.Controls.MaterialButton();
            this.btnViewPrograms = new MaterialSkin.Controls.MaterialButton();
            this.btnViewUsers = new MaterialSkin.Controls.MaterialButton();
            this.gbxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStatistics
            // 
            this.gbxStatistics.Controls.Add(this.lblFemales);
            this.gbxStatistics.Controls.Add(this.lblMale);
            this.gbxStatistics.Controls.Add(this.lbl60Plus);
            this.gbxStatistics.Controls.Add(this.lbl5060);
            this.gbxStatistics.Controls.Add(this.lbl4050);
            this.gbxStatistics.Controls.Add(this.lbl3040);
            this.gbxStatistics.Controls.Add(this.lbl2030);
            this.gbxStatistics.Controls.Add(this.lblUnder20);
            this.gbxStatistics.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxStatistics.Location = new System.Drawing.Point(659, 118);
            this.gbxStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.gbxStatistics.Name = "gbxStatistics";
            this.gbxStatistics.Padding = new System.Windows.Forms.Padding(2);
            this.gbxStatistics.Size = new System.Drawing.Size(556, 606);
            this.gbxStatistics.TabIndex = 4;
            this.gbxStatistics.TabStop = false;
            this.gbxStatistics.Text = "User statistics";
            // 
            // lblFemales
            // 
            this.lblFemales.AutoSize = true;
            this.lblFemales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFemales.Location = new System.Drawing.Point(311, 366);
            this.lblFemales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFemales.Name = "lblFemales";
            this.lblFemales.Size = new System.Drawing.Size(76, 25);
            this.lblFemales.TabIndex = 13;
            this.lblFemales.Text = "Females";
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMale.Location = new System.Drawing.Point(126, 366);
            this.lblMale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(58, 25);
            this.lblMale.TabIndex = 12;
            this.lblMale.Text = "Males";
            // 
            // lbl60Plus
            // 
            this.lbl60Plus.AutoSize = true;
            this.lbl60Plus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl60Plus.Location = new System.Drawing.Point(311, 230);
            this.lbl60Plus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl60Plus.Name = "lbl60Plus";
            this.lbl60Plus.Size = new System.Drawing.Size(44, 25);
            this.lbl60Plus.TabIndex = 10;
            this.lbl60Plus.Text = "60+";
            // 
            // lbl5060
            // 
            this.lbl5060.AutoSize = true;
            this.lbl5060.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5060.Location = new System.Drawing.Point(126, 230);
            this.lbl5060.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl5060.Name = "lbl5060";
            this.lbl5060.Size = new System.Drawing.Size(69, 25);
            this.lbl5060.TabIndex = 9;
            this.lbl5060.Text = "50 - 60";
            // 
            // lbl4050
            // 
            this.lbl4050.AutoSize = true;
            this.lbl4050.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4050.Location = new System.Drawing.Point(311, 182);
            this.lbl4050.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4050.Name = "lbl4050";
            this.lbl4050.Size = new System.Drawing.Size(69, 25);
            this.lbl4050.TabIndex = 8;
            this.lbl4050.Text = "40 - 50";
            // 
            // lbl3040
            // 
            this.lbl3040.AutoSize = true;
            this.lbl3040.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3040.Location = new System.Drawing.Point(126, 182);
            this.lbl3040.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3040.Name = "lbl3040";
            this.lbl3040.Size = new System.Drawing.Size(69, 25);
            this.lbl3040.TabIndex = 7;
            this.lbl3040.Text = "30 - 40";
            // 
            // lbl2030
            // 
            this.lbl2030.AutoSize = true;
            this.lbl2030.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2030.Location = new System.Drawing.Point(311, 139);
            this.lbl2030.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2030.Name = "lbl2030";
            this.lbl2030.Size = new System.Drawing.Size(69, 25);
            this.lbl2030.TabIndex = 6;
            this.lbl2030.Text = "20 - 30";
            // 
            // lblUnder20
            // 
            this.lblUnder20.AutoSize = true;
            this.lblUnder20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnder20.Location = new System.Drawing.Point(126, 139);
            this.lblUnder20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnder20.Name = "lblUnder20";
            this.lblUnder20.Size = new System.Drawing.Size(85, 25);
            this.lblUnder20.TabIndex = 5;
            this.lblUnder20.Text = "Under 20";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalUsers.Location = new System.Drawing.Point(256, 316);
            this.lblTotalUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(132, 32);
            this.lblTotalUsers.TabIndex = 11;
            this.lblTotalUsers.Text = "Total users:";
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalQuestions.Location = new System.Drawing.Point(256, 155);
            this.lblTotalQuestions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(180, 32);
            this.lblTotalQuestions.TabIndex = 14;
            this.lblTotalQuestions.Text = "Total questions:";
            // 
            // lblTotalPrograms
            // 
            this.lblTotalPrograms.AutoSize = true;
            this.lblTotalPrograms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrograms.Location = new System.Drawing.Point(256, 238);
            this.lblTotalPrograms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrograms.Name = "lblTotalPrograms";
            this.lblTotalPrograms.Size = new System.Drawing.Size(178, 32);
            this.lblTotalPrograms.TabIndex = 15;
            this.lblTotalPrograms.Text = "Total programs:";
            // 
            // btnViewQuestion
            // 
            this.btnViewQuestion.AutoSize = false;
            this.btnViewQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewQuestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnViewQuestion.Depth = 0;
            this.btnViewQuestion.HighEmphasis = true;
            this.btnViewQuestion.Icon = null;
            this.btnViewQuestion.Location = new System.Drawing.Point(9, 154);
            this.btnViewQuestion.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnViewQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewQuestion.Name = "btnViewQuestion";
            this.btnViewQuestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnViewQuestion.Size = new System.Drawing.Size(175, 45);
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
            this.btnViewPrograms.Location = new System.Drawing.Point(8, 236);
            this.btnViewPrograms.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnViewPrograms.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewPrograms.Name = "btnViewPrograms";
            this.btnViewPrograms.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnViewPrograms.Size = new System.Drawing.Size(176, 45);
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
            this.btnViewUsers.Location = new System.Drawing.Point(8, 315);
            this.btnViewUsers.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnViewUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnViewUsers.Size = new System.Drawing.Size(176, 45);
            this.btnViewUsers.TabIndex = 20;
            this.btnViewUsers.Text = "view users";
            this.btnViewUsers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnViewUsers.UseAccentColor = false;
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1371, 748);
            this.Controls.Add(this.btnViewUsers);
            this.Controls.Add(this.btnViewPrograms);
            this.Controls.Add(this.lblTotalUsers);
            this.Controls.Add(this.btnViewQuestion);
            this.Controls.Add(this.lblTotalPrograms);
            this.Controls.Add(this.lblTotalQuestions);
            this.Controls.Add(this.gbxStatistics);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 80, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.gbxStatistics.ResumeLayout(false);
            this.gbxStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox gbxStatistics;
        private Label lblUnder20;
        private Label lbl60Plus;
        private Label lbl5060;
        private Label lbl4050;
        private Label lbl3040;
        private Label lbl2030;
        private Label lblFemales;
        private Label lblMale;
        private Label lblTotalUsers;
        private Label lblTotalQuestions;
        private Label lblTotalPrograms;
        private MaterialSkin.Controls.MaterialButton btnViewQuestion;
        private MaterialSkin.Controls.MaterialButton btnViewPrograms;
        private MaterialSkin.Controls.MaterialButton btnViewUsers;
    }
}