﻿namespace MyProject
{
    partial class AssignProgramToAnswer
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
            this.components = new System.ComponentModel.Container();
            this.cbxQuestion = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxAnswer = new MaterialSkin.Controls.MaterialComboBox();
            this.questionManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAssign = new MaterialSkin.Controls.MaterialButton();
            this.lblQuestion = new MaterialSkin.Controls.MaterialLabel();
            this.lblAnswer = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.questionManagerBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.cbxQuestion.Location = new System.Drawing.Point(75, 137);
            this.cbxQuestion.MaxDropDownItems = 4;
            this.cbxQuestion.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxQuestion.Name = "cbxQuestion";
            this.cbxQuestion.Size = new System.Drawing.Size(219, 49);
            this.cbxQuestion.StartIndex = 0;
            this.cbxQuestion.TabIndex = 0;
            this.cbxQuestion.SelectedIndexChanged += new System.EventHandler(this.cbxQuestion_SelectedIndexChanged);
            // 
            // cbxAnswer
            // 
            this.cbxAnswer.AutoResize = false;
            this.cbxAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxAnswer.DataSource = this.questionManagerBindingSource;
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
            this.cbxAnswer.Location = new System.Drawing.Point(75, 243);
            this.cbxAnswer.MaxDropDownItems = 4;
            this.cbxAnswer.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxAnswer.Name = "cbxAnswer";
            this.cbxAnswer.Size = new System.Drawing.Size(219, 49);
            this.cbxAnswer.StartIndex = 0;
            this.cbxAnswer.TabIndex = 1;
            // 
            // questionManagerBindingSource
            // 
            this.questionManagerBindingSource.AllowNew = true;
            this.questionManagerBindingSource.DataSource = typeof(ClassLibrary.Logic.QuestionManager);
            // 
            // btnAssign
            // 
            this.btnAssign.AutoSize = false;
            this.btnAssign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAssign.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAssign.Depth = 0;
            this.btnAssign.HighEmphasis = true;
            this.btnAssign.Icon = null;
            this.btnAssign.Location = new System.Drawing.Point(117, 326);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAssign.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAssign.Size = new System.Drawing.Size(136, 45);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign";
            this.btnAssign.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAssign.UseAccentColor = false;
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Depth = 0;
            this.lblQuestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblQuestion.Location = new System.Drawing.Point(75, 99);
            this.lblQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(109, 19);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Pick a question";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Depth = 0;
            this.lblAnswer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAnswer.Location = new System.Drawing.Point(75, 206);
            this.lblAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(108, 19);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Pick an answer";
            // 
            // AssignProgramToAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cbxAnswer);
            this.Controls.Add(this.cbxQuestion);
            this.Name = "AssignProgramToAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignPragramToAnswer";
            ((System.ComponentModel.ISupportInitialize)(this.questionManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbxQuestion;
        private MaterialSkin.Controls.MaterialComboBox cbxAnswer;
        private BindingSource questionManagerBindingSource;
        private MaterialSkin.Controls.MaterialButton btnAssign;
        private MaterialSkin.Controls.MaterialLabel lblQuestion;
        private MaterialSkin.Controls.MaterialLabel lblAnswer;
    }
}