namespace WindowsFormsUsu.Forms
{
    partial class FormProfile
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
            this.labelWelkome = new System.Windows.Forms.Label();
            this.labelViewUsername = new System.Windows.Forms.Label();
            this.textBoxViewUsername = new System.Windows.Forms.TextBox();
            this.textBoxViewPassword = new System.Windows.Forms.TextBox();
            this.labelViewPassword = new System.Windows.Forms.Label();
            this.labelViewAge = new System.Windows.Forms.Label();
            this.textBoxViewAge = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxViewCountry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWelkome
            // 
            this.labelWelkome.AutoSize = true;
            this.labelWelkome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelkome.Location = new System.Drawing.Point(229, 55);
            this.labelWelkome.Name = "labelWelkome";
            this.labelWelkome.Size = new System.Drawing.Size(121, 27);
            this.labelWelkome.TabIndex = 1;
            this.labelWelkome.Text = "Welkome: ";
            // 
            // labelViewUsername
            // 
            this.labelViewUsername.AutoSize = true;
            this.labelViewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewUsername.Location = new System.Drawing.Point(99, 152);
            this.labelViewUsername.Name = "labelViewUsername";
            this.labelViewUsername.Size = new System.Drawing.Size(77, 18);
            this.labelViewUsername.TabIndex = 3;
            this.labelViewUsername.Text = "Username";
            // 
            // textBoxViewUsername
            // 
            this.textBoxViewUsername.Enabled = false;
            this.textBoxViewUsername.Location = new System.Drawing.Point(182, 152);
            this.textBoxViewUsername.Name = "textBoxViewUsername";
            this.textBoxViewUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxViewUsername.TabIndex = 4;
            // 
            // textBoxViewPassword
            // 
            this.textBoxViewPassword.Enabled = false;
            this.textBoxViewPassword.Location = new System.Drawing.Point(463, 152);
            this.textBoxViewPassword.Name = "textBoxViewPassword";
            this.textBoxViewPassword.PasswordChar = '●';
            this.textBoxViewPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxViewPassword.TabIndex = 6;
            // 
            // labelViewPassword
            // 
            this.labelViewPassword.AutoSize = true;
            this.labelViewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewPassword.Location = new System.Drawing.Point(380, 152);
            this.labelViewPassword.Name = "labelViewPassword";
            this.labelViewPassword.Size = new System.Drawing.Size(75, 18);
            this.labelViewPassword.TabIndex = 5;
            this.labelViewPassword.Text = "Password";
            // 
            // labelViewAge
            // 
            this.labelViewAge.AutoSize = true;
            this.labelViewAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewAge.Location = new System.Drawing.Point(99, 242);
            this.labelViewAge.Name = "labelViewAge";
            this.labelViewAge.Size = new System.Drawing.Size(33, 18);
            this.labelViewAge.TabIndex = 7;
            this.labelViewAge.Text = "Age";
            // 
            // textBoxViewAge
            // 
            this.textBoxViewAge.Enabled = false;
            this.textBoxViewAge.Location = new System.Drawing.Point(182, 242);
            this.textBoxViewAge.Name = "textBoxViewAge";
            this.textBoxViewAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxViewAge.TabIndex = 8;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(380, 246);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(60, 18);
            this.labelCountry.TabIndex = 9;
            this.labelCountry.Text = "Country";
            // 
            // textBoxViewCountry
            // 
            this.textBoxViewCountry.Enabled = false;
            this.textBoxViewCountry.Location = new System.Drawing.Point(475, 244);
            this.textBoxViewCountry.Name = "textBoxViewCountry";
            this.textBoxViewCountry.Size = new System.Drawing.Size(100, 22);
            this.textBoxViewCountry.TabIndex = 10;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxViewCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.textBoxViewAge);
            this.Controls.Add(this.labelViewAge);
            this.Controls.Add(this.textBoxViewPassword);
            this.Controls.Add(this.labelViewPassword);
            this.Controls.Add(this.textBoxViewUsername);
            this.Controls.Add(this.labelViewUsername);
            this.Controls.Add(this.labelWelkome);
            this.Name = "FormProfile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelkome;
        private System.Windows.Forms.Label labelViewUsername;
        private System.Windows.Forms.TextBox textBoxViewUsername;
        private System.Windows.Forms.TextBox textBoxViewPassword;
        private System.Windows.Forms.Label labelViewPassword;
        private System.Windows.Forms.Label labelViewAge;
        private System.Windows.Forms.TextBox textBoxViewAge;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxViewCountry;
    }
}