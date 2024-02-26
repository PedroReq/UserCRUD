namespace WindowsFormsUsu.Forms
{
    partial class FormUpdateUsername
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
            this.labelUsernameOld = new System.Windows.Forms.Label();
            this.textBoxUsernameOld = new System.Windows.Forms.TextBox();
            this.labelUsernameNew = new System.Windows.Forms.Label();
            this.textBoxUsernameNew = new System.Windows.Forms.TextBox();
            this.buttonUpdateUsername = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsernameOld
            // 
            this.labelUsernameOld.AutoSize = true;
            this.labelUsernameOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameOld.Location = new System.Drawing.Point(265, 107);
            this.labelUsernameOld.Name = "labelUsernameOld";
            this.labelUsernameOld.Size = new System.Drawing.Size(77, 18);
            this.labelUsernameOld.TabIndex = 3;
            this.labelUsernameOld.Text = "Username";
            // 
            // textBoxUsernameOld
            // 
            this.textBoxUsernameOld.Enabled = false;
            this.textBoxUsernameOld.Location = new System.Drawing.Point(371, 107);
            this.textBoxUsernameOld.Name = "textBoxUsernameOld";
            this.textBoxUsernameOld.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsernameOld.TabIndex = 4;
            // 
            // labelUsernameNew
            // 
            this.labelUsernameNew.AutoSize = true;
            this.labelUsernameNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameNew.Location = new System.Drawing.Point(231, 168);
            this.labelUsernameNew.Name = "labelUsernameNew";
            this.labelUsernameNew.Size = new System.Drawing.Size(111, 18);
            this.labelUsernameNew.TabIndex = 5;
            this.labelUsernameNew.Text = "New Username";
            // 
            // textBoxUsernameNew
            // 
            this.textBoxUsernameNew.Location = new System.Drawing.Point(371, 164);
            this.textBoxUsernameNew.Name = "textBoxUsernameNew";
            this.textBoxUsernameNew.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsernameNew.TabIndex = 6;
            // 
            // buttonUpdateUsername
            // 
            this.buttonUpdateUsername.Location = new System.Drawing.Point(323, 225);
            this.buttonUpdateUsername.Name = "buttonUpdateUsername";
            this.buttonUpdateUsername.Size = new System.Drawing.Size(119, 33);
            this.buttonUpdateUsername.TabIndex = 7;
            this.buttonUpdateUsername.Text = "Update";
            this.buttonUpdateUsername.UseVisualStyleBackColor = true;
            this.buttonUpdateUsername.Click += new System.EventHandler(this.buttonUpdateUsername_Click);
            // 
            // FormUpdateUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateUsername);
            this.Controls.Add(this.textBoxUsernameNew);
            this.Controls.Add(this.labelUsernameNew);
            this.Controls.Add(this.textBoxUsernameOld);
            this.Controls.Add(this.labelUsernameOld);
            this.Name = "FormUpdateUsername";
            this.Text = "Update username";
            this.Load += new System.EventHandler(this.FormUpdateUsername_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsernameOld;
        private System.Windows.Forms.TextBox textBoxUsernameOld;
        private System.Windows.Forms.Label labelUsernameNew;
        private System.Windows.Forms.TextBox textBoxUsernameNew;
        private System.Windows.Forms.Button buttonUpdateUsername;
    }
}