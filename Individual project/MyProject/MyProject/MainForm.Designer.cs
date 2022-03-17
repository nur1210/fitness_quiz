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
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.btnEditProgram = new System.Windows.Forms.Button();
            this.gbxStatistics = new System.Windows.Forms.GroupBox();
            this.lblFemales = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lbl60Plus = new System.Windows.Forms.Label();
            this.lbl5060 = new System.Windows.Forms.Label();
            this.lbl4050 = new System.Windows.Forms.Label();
            this.lbl3040 = new System.Windows.Forms.Label();
            this.lbl2030 = new System.Windows.Forms.Label();
            this.lblUnder20 = new System.Windows.Forms.Label();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.lblTotalPrograms = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.gbxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(646, 138);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(166, 41);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "Add question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(646, 202);
            this.btnEditQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(166, 41);
            this.btnEditQuestion.TabIndex = 1;
            this.btnEditQuestion.Text = "Edit question";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.Location = new System.Drawing.Point(646, 374);
            this.btnAddProgram.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(166, 41);
            this.btnAddProgram.TabIndex = 2;
            this.btnAddProgram.Text = "Add program";
            this.btnAddProgram.UseVisualStyleBackColor = true;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // btnEditProgram
            // 
            this.btnEditProgram.Location = new System.Drawing.Point(646, 438);
            this.btnEditProgram.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditProgram.Name = "btnEditProgram";
            this.btnEditProgram.Size = new System.Drawing.Size(166, 41);
            this.btnEditProgram.TabIndex = 3;
            this.btnEditProgram.Text = "Edit program";
            this.btnEditProgram.UseVisualStyleBackColor = true;
            this.btnEditProgram.Click += new System.EventHandler(this.btnEditProgram_Click);
            // 
            // gbxStatistics
            // 
            this.gbxStatistics.Controls.Add(this.btnViewUsers);
            this.gbxStatistics.Controls.Add(this.lblFemales);
            this.gbxStatistics.Controls.Add(this.lblMale);
            this.gbxStatistics.Controls.Add(this.lblTotalUsers);
            this.gbxStatistics.Controls.Add(this.lbl60Plus);
            this.gbxStatistics.Controls.Add(this.lbl5060);
            this.gbxStatistics.Controls.Add(this.lbl4050);
            this.gbxStatistics.Controls.Add(this.lbl3040);
            this.gbxStatistics.Controls.Add(this.lbl2030);
            this.gbxStatistics.Controls.Add(this.lblUnder20);
            this.gbxStatistics.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxStatistics.Location = new System.Drawing.Point(69, 42);
            this.gbxStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.gbxStatistics.Name = "gbxStatistics";
            this.gbxStatistics.Padding = new System.Windows.Forms.Padding(2);
            this.gbxStatistics.Size = new System.Drawing.Size(445, 485);
            this.gbxStatistics.TabIndex = 4;
            this.gbxStatistics.TabStop = false;
            this.gbxStatistics.Text = "User statistics";
            // 
            // lblFemales
            // 
            this.lblFemales.AutoSize = true;
            this.lblFemales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFemales.Location = new System.Drawing.Point(249, 293);
            this.lblFemales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFemales.Name = "lblFemales";
            this.lblFemales.Size = new System.Drawing.Size(63, 20);
            this.lblFemales.TabIndex = 13;
            this.lblFemales.Text = "Females";
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMale.Location = new System.Drawing.Point(101, 293);
            this.lblMale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(48, 20);
            this.lblMale.TabIndex = 12;
            this.lblMale.Text = "Males";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalUsers.Location = new System.Drawing.Point(50, 61);
            this.lblTotalUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(107, 28);
            this.lblTotalUsers.TabIndex = 11;
            this.lblTotalUsers.Text = "Total users:";
            // 
            // lbl60Plus
            // 
            this.lbl60Plus.AutoSize = true;
            this.lbl60Plus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl60Plus.Location = new System.Drawing.Point(249, 184);
            this.lbl60Plus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl60Plus.Name = "lbl60Plus";
            this.lbl60Plus.Size = new System.Drawing.Size(35, 20);
            this.lbl60Plus.TabIndex = 10;
            this.lbl60Plus.Text = "60+";
            // 
            // lbl5060
            // 
            this.lbl5060.AutoSize = true;
            this.lbl5060.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5060.Location = new System.Drawing.Point(101, 184);
            this.lbl5060.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl5060.Name = "lbl5060";
            this.lbl5060.Size = new System.Drawing.Size(55, 20);
            this.lbl5060.TabIndex = 9;
            this.lbl5060.Text = "50 - 60";
            // 
            // lbl4050
            // 
            this.lbl4050.AutoSize = true;
            this.lbl4050.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4050.Location = new System.Drawing.Point(249, 146);
            this.lbl4050.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4050.Name = "lbl4050";
            this.lbl4050.Size = new System.Drawing.Size(55, 20);
            this.lbl4050.TabIndex = 8;
            this.lbl4050.Text = "40 - 50";
            // 
            // lbl3040
            // 
            this.lbl3040.AutoSize = true;
            this.lbl3040.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3040.Location = new System.Drawing.Point(101, 146);
            this.lbl3040.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3040.Name = "lbl3040";
            this.lbl3040.Size = new System.Drawing.Size(55, 20);
            this.lbl3040.TabIndex = 7;
            this.lbl3040.Text = "30 - 40";
            // 
            // lbl2030
            // 
            this.lbl2030.AutoSize = true;
            this.lbl2030.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2030.Location = new System.Drawing.Point(249, 111);
            this.lbl2030.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2030.Name = "lbl2030";
            this.lbl2030.Size = new System.Drawing.Size(55, 20);
            this.lbl2030.TabIndex = 6;
            this.lbl2030.Text = "20 - 30";
            // 
            // lblUnder20
            // 
            this.lblUnder20.AutoSize = true;
            this.lblUnder20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnder20.Location = new System.Drawing.Point(101, 111);
            this.lblUnder20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnder20.Name = "lblUnder20";
            this.lblUnder20.Size = new System.Drawing.Size(69, 20);
            this.lblUnder20.TabIndex = 5;
            this.lblUnder20.Text = "Under 20";
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalQuestions.Location = new System.Drawing.Point(646, 67);
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
            this.lblTotalPrograms.Location = new System.Drawing.Point(646, 311);
            this.lblTotalPrograms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrograms.Name = "lblTotalPrograms";
            this.lblTotalPrograms.Size = new System.Drawing.Size(148, 28);
            this.lblTotalPrograms.TabIndex = 15;
            this.lblTotalPrograms.Text = "Total programs:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(991, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewUsers.Location = new System.Drawing.Point(50, 410);
            this.btnViewUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(166, 41);
            this.btnViewUsers.TabIndex = 17;
            this.btnViewUsers.Text = "View users";
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1097, 598);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalPrograms);
            this.Controls.Add(this.lblTotalQuestions);
            this.Controls.Add(this.gbxStatistics);
            this.Controls.Add(this.btnEditProgram);
            this.Controls.Add(this.btnAddProgram);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.btnAddQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbxStatistics.ResumeLayout(false);
            this.gbxStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddQuestion;
        private Button btnEditQuestion;
        private Button btnAddProgram;
        private Button btnEditProgram;
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
        private Button btnClose;
        private Button btnViewUsers;
    }
}