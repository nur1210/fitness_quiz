namespace MyProject
{
    partial class AddProgram
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
            this.lblProgram = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgram.Location = new System.Drawing.Point(89, 104);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(244, 32);
            this.lblProgram.TabIndex = 7;
            this.lblProgram.Text = "Program Number **";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(166, 177);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(195, 27);
            this.tbxDescription.TabIndex = 8;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(166, 230);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(195, 28);
            this.cbxType.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(42, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Program name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(42, 233);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(109, 20);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Program type:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 42);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add exersices";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(428, 383);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblProgram);
            this.Name = "AddProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProgram;
        private TextBox tbxDescription;
        private ComboBox cbxType;
        private Label lblName;
        private Label lblType;
        private Button btnAdd;
    }
}