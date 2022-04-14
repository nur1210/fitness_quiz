namespace WinFormApp
{
    partial class EditScore
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
            this.lblScore = new MaterialSkin.Controls.MaterialLabel();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.lblAnswer = new MaterialSkin.Controls.MaterialLabel();
            this.lblQuestion = new MaterialSkin.Controls.MaterialLabel();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.cbxAnswer = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxQuestion = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Depth = 0;
            this.lblScore.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblScore.Location = new System.Drawing.Point(98, 302);
            this.lblScore.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(125, 19);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "Coresponding 1-5";
            // 
            // nudScore
            // 
            this.nudScore.Location = new System.Drawing.Point(127, 336);
            this.nudScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScore.Name = "nudScore";
            this.nudScore.ReadOnly = true;
            this.nudScore.Size = new System.Drawing.Size(136, 27);
            this.nudScore.TabIndex = 12;
            this.nudScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Depth = 0;
            this.lblAnswer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAnswer.Location = new System.Drawing.Point(97, 196);
            this.lblAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(108, 19);
            this.lblAnswer.TabIndex = 11;
            this.lblAnswer.Text = "Pick an answer";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Depth = 0;
            this.lblQuestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblQuestion.Location = new System.Drawing.Point(97, 89);
            this.lblQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(109, 19);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "Pick a question";
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(127, 372);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(136, 45);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbxAnswer
            // 
            this.cbxAnswer.AutoResize = false;
            this.cbxAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxAnswer.Depth = 0;
            this.cbxAnswer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxAnswer.DropDownHeight = 174;
            this.cbxAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnswer.DropDownWidth = 121;
            this.cbxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxAnswer.FormattingEnabled = true;
            this.cbxAnswer.IntegralHeight = false;
            this.cbxAnswer.ItemHeight = 43;
            this.cbxAnswer.Location = new System.Drawing.Point(97, 233);
            this.cbxAnswer.MaxDropDownItems = 4;
            this.cbxAnswer.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxAnswer.Name = "cbxAnswer";
            this.cbxAnswer.Size = new System.Drawing.Size(219, 49);
            this.cbxAnswer.StartIndex = 0;
            this.cbxAnswer.TabIndex = 8;
            // 
            // cbxQuestion
            // 
            this.cbxQuestion.AutoResize = false;
            this.cbxQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxQuestion.Depth = 0;
            this.cbxQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxQuestion.DropDownHeight = 174;
            this.cbxQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuestion.DropDownWidth = 121;
            this.cbxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxQuestion.FormattingEnabled = true;
            this.cbxQuestion.IntegralHeight = false;
            this.cbxQuestion.ItemHeight = 43;
            this.cbxQuestion.Location = new System.Drawing.Point(97, 127);
            this.cbxQuestion.MaxDropDownItems = 4;
            this.cbxQuestion.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxQuestion.Name = "cbxQuestion";
            this.cbxQuestion.Size = new System.Drawing.Size(219, 49);
            this.cbxQuestion.StartIndex = 0;
            this.cbxQuestion.TabIndex = 7;
            // 
            // EditScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.nudScore);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbxAnswer);
            this.Controls.Add(this.cbxQuestion);
            this.Name = "EditScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnassignProgramFromAnswer";
            this.Load += new System.EventHandler(this.EditScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblScore;
        private NumericUpDown nudScore;
        private MaterialSkin.Controls.MaterialLabel lblAnswer;
        private MaterialSkin.Controls.MaterialLabel lblQuestion;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialComboBox cbxAnswer;
        private MaterialSkin.Controls.MaterialComboBox cbxQuestion;
    }
}