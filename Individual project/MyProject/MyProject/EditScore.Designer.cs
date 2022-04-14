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
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.cbxAnswer = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Depth = 0;
            this.lblScore.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblScore.Location = new System.Drawing.Point(158, 295);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(125, 19);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "Coresponding 0-5";
            // 
            // nudScore
            // 
            this.nudScore.Location = new System.Drawing.Point(201, 346);
            this.nudScore.Margin = new System.Windows.Forms.Padding(4);
            this.nudScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudScore.Name = "nudScore";
            this.nudScore.ReadOnly = true;
            this.nudScore.Size = new System.Drawing.Size(204, 35);
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
            this.lblAnswer.Location = new System.Drawing.Point(157, 136);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(108, 19);
            this.lblAnswer.TabIndex = 11;
            this.lblAnswer.Text = "Pick an answer";
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(201, 408);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(204, 68);
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
            this.cbxAnswer.Location = new System.Drawing.Point(157, 192);
            this.cbxAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAnswer.MaxDropDownItems = 4;
            this.cbxAnswer.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxAnswer.Name = "cbxAnswer";
            this.cbxAnswer.Size = new System.Drawing.Size(326, 49);
            this.cbxAnswer.StartIndex = 0;
            this.cbxAnswer.TabIndex = 8;
            this.cbxAnswer.SelectedIndexChanged += new System.EventHandler(this.cbxAnswer_SelectedIndexChanged);
            // 
            // EditScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 528);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.nudScore);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbxAnswer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditScore";
            this.Padding = new System.Windows.Forms.Padding(4, 96, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnassignProgramFromAnswer";
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblScore;
        private NumericUpDown nudScore;
        private MaterialSkin.Controls.MaterialLabel lblAnswer;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialComboBox cbxAnswer;
    }
}