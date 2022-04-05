namespace MyProject
{
    partial class UnassignProgramFromAnswer
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
            this.btnUnassign = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.lbxAssignedAnswers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUnassign
            // 
            this.btnUnassign.AutoSize = false;
            this.btnUnassign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUnassign.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUnassign.Depth = 0;
            this.btnUnassign.HighEmphasis = true;
            this.btnUnassign.Icon = null;
            this.btnUnassign.Location = new System.Drawing.Point(60, 388);
            this.btnUnassign.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUnassign.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUnassign.Size = new System.Drawing.Size(127, 45);
            this.btnUnassign.TabIndex = 1;
            this.btnUnassign.Text = "Unassiign";
            this.btnUnassign.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUnassign.UseAccentColor = false;
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(216, 388);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(127, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbxAssignedAnswers
            // 
            this.lbxAssignedAnswers.FormattingEnabled = true;
            this.lbxAssignedAnswers.ItemHeight = 20;
            this.lbxAssignedAnswers.Location = new System.Drawing.Point(49, 81);
            this.lbxAssignedAnswers.Name = "lbxAssignedAnswers";
            this.lbxAssignedAnswers.Size = new System.Drawing.Size(306, 284);
            this.lbxAssignedAnswers.TabIndex = 3;
            // 
            // UnassignProgramFromAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.lbxAssignedAnswers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUnassign);
            this.Name = "UnassignProgramFromAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnassignProgramFromAnswer";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnUnassign;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private ListBox lbxAssignedAnswers;
    }
}