namespace WindowsFormsUsu.Forms
{
    partial class FormUpdatePassword
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
            this.textBoxPasswordNew = new System.Windows.Forms.TextBox();
            this.labelPasswordNew = new System.Windows.Forms.Label();
            this.buttonUpdatePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPasswordNew
            // 
            this.textBoxPasswordNew.Location = new System.Drawing.Point(365, 125);
            this.textBoxPasswordNew.Name = "textBoxPasswordNew";
            this.textBoxPasswordNew.Size = new System.Drawing.Size(100, 22);
            this.textBoxPasswordNew.TabIndex = 6;
            this.textBoxPasswordNew.UseSystemPasswordChar = true;
            this.textBoxPasswordNew.TextChanged += new System.EventHandler(this.textBoxPasswordNew_TextChanged);
            // 
            // labelPasswordNew
            // 
            this.labelPasswordNew.AutoSize = true;
            this.labelPasswordNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordNew.Location = new System.Drawing.Point(234, 127);
            this.labelPasswordNew.Name = "labelPasswordNew";
            this.labelPasswordNew.Size = new System.Drawing.Size(109, 18);
            this.labelPasswordNew.TabIndex = 5;
            this.labelPasswordNew.Text = "New Password";
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.Location = new System.Drawing.Point(296, 206);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.Size = new System.Drawing.Size(111, 34);
            this.buttonUpdatePassword.TabIndex = 7;
            this.buttonUpdatePassword.Text = " Update";
            this.buttonUpdatePassword.UseVisualStyleBackColor = true;
            this.buttonUpdatePassword.Click += new System.EventHandler(this.buttonUpdatePassword_Click);
            // 
            // FormUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdatePassword);
            this.Controls.Add(this.textBoxPasswordNew);
            this.Controls.Add(this.labelPasswordNew);
            this.Name = "FormUpdatePassword";
            this.Text = "Update Password";
            this.Load += new System.EventHandler(this.FormUpdatePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPasswordNew;
        private System.Windows.Forms.Label labelPasswordNew;
        private System.Windows.Forms.Button buttonUpdatePassword;
    }
}