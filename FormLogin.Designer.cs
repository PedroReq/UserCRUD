namespace WindowsFormsUsu
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonUpdateCountry = new System.Windows.Forms.Button();
            this.buttonUpdateAge = new System.Windows.Forms.Button();
            this.buttonUpdatePassword = new System.Windows.Forms.Button();
            this.buttonUpdateUsername = new System.Windows.Forms.Button();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonCloseChildForm = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMenu.Controls.Add(this.buttonUpdateCountry);
            this.panelMenu.Controls.Add(this.buttonUpdateAge);
            this.panelMenu.Controls.Add(this.buttonUpdatePassword);
            this.panelMenu.Controls.Add(this.buttonUpdateUsername);
            this.panelMenu.Controls.Add(this.buttonCreateUser);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(170, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonUpdateCountry
            // 
            this.buttonUpdateCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdateCountry.FlatAppearance.BorderSize = 0;
            this.buttonUpdateCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateCountry.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateCountry.Location = new System.Drawing.Point(0, 240);
            this.buttonUpdateCountry.Name = "buttonUpdateCountry";
            this.buttonUpdateCountry.Size = new System.Drawing.Size(170, 40);
            this.buttonUpdateCountry.TabIndex = 5;
            this.buttonUpdateCountry.Text = "Update Country";
            this.buttonUpdateCountry.UseVisualStyleBackColor = true;
            this.buttonUpdateCountry.Click += new System.EventHandler(this.buttonUpdateCountry_Click);
            // 
            // buttonUpdateAge
            // 
            this.buttonUpdateAge.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdateAge.FlatAppearance.BorderSize = 0;
            this.buttonUpdateAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateAge.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateAge.Location = new System.Drawing.Point(0, 200);
            this.buttonUpdateAge.Name = "buttonUpdateAge";
            this.buttonUpdateAge.Size = new System.Drawing.Size(170, 40);
            this.buttonUpdateAge.TabIndex = 4;
            this.buttonUpdateAge.Text = "Update age";
            this.buttonUpdateAge.UseVisualStyleBackColor = true;
            this.buttonUpdateAge.Click += new System.EventHandler(this.buttonUpdateAge_Click);
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdatePassword.FlatAppearance.BorderSize = 0;
            this.buttonUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdatePassword.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdatePassword.Location = new System.Drawing.Point(0, 160);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.Size = new System.Drawing.Size(170, 40);
            this.buttonUpdatePassword.TabIndex = 3;
            this.buttonUpdatePassword.Text = "Update password";
            this.buttonUpdatePassword.UseVisualStyleBackColor = true;
            this.buttonUpdatePassword.Click += new System.EventHandler(this.buttonUpdatePassword_Click);
            // 
            // buttonUpdateUsername
            // 
            this.buttonUpdateUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdateUsername.FlatAppearance.BorderSize = 0;
            this.buttonUpdateUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateUsername.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateUsername.Location = new System.Drawing.Point(0, 120);
            this.buttonUpdateUsername.Name = "buttonUpdateUsername";
            this.buttonUpdateUsername.Size = new System.Drawing.Size(170, 40);
            this.buttonUpdateUsername.TabIndex = 2;
            this.buttonUpdateUsername.Text = "Update username";
            this.buttonUpdateUsername.UseVisualStyleBackColor = true;
            this.buttonUpdateUsername.Click += new System.EventHandler(this.buttonUpdateUsername_Click);
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateUser.FlatAppearance.BorderSize = 0;
            this.buttonCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateUser.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateUser.Location = new System.Drawing.Point(0, 80);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(170, 40);
            this.buttonCreateUser.TabIndex = 1;
            this.buttonCreateUser.Text = "Create user";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.SkyBlue;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelTitleBar.Controls.Add(this.buttonCloseChildForm);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(170, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(683, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // buttonCloseChildForm
            // 
            this.buttonCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCloseChildForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseChildForm.Image = global::WindowsFormsUsu.Properties.Resources.arrow;
            this.buttonCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.buttonCloseChildForm.Name = "buttonCloseChildForm";
            this.buttonCloseChildForm.Size = new System.Drawing.Size(87, 80);
            this.buttonCloseChildForm.TabIndex = 1;
            this.buttonCloseChildForm.UseVisualStyleBackColor = true;
            this.buttonCloseChildForm.Click += new System.EventHandler(this.buttonCloseChildForm_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Dubai", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(282, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(96, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "LOGIN";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(215, 102);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(77, 18);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(217, 151);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 18);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(315, 102);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(315, 151);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.buttonEnter);
            this.panelDesktopPanel.Controls.Add(this.labelUsername);
            this.panelDesktopPanel.Controls.Add(this.textBoxUsername);
            this.panelDesktopPanel.Controls.Add(this.labelPassword);
            this.panelDesktopPanel.Controls.Add(this.textBoxPassword);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(170, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(683, 370);
            this.panelDesktopPanel.TabIndex = 6;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(255, 205);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(123, 37);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormLogin";
            this.Text = "SS";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button buttonCloseChildForm;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonUpdateCountry;
        private System.Windows.Forms.Button buttonUpdateAge;
        private System.Windows.Forms.Button buttonUpdatePassword;
        private System.Windows.Forms.Button buttonUpdateUsername;
    }
}

