namespace WindowsFormsUsu.Forms
{
    partial class FormCreateUserr
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
            this.labelCreateUsername = new System.Windows.Forms.Label();
            this.labelCreatePassword = new System.Windows.Forms.Label();
            this.textBoxCreateUsername = new System.Windows.Forms.TextBox();
            this.textBoxCreatePassword = new System.Windows.Forms.TextBox();
            this.labelCreateAge = new System.Windows.Forms.Label();
            this.labelCreateCountry = new System.Windows.Forms.Label();
            this.buttonCreateUserr = new System.Windows.Forms.Button();
            this.numericUpDownCreateAge = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCreateCountry = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreateAge)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCreateUsername
            // 
            this.labelCreateUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCreateUsername.AutoSize = true;
            this.labelCreateUsername.Location = new System.Drawing.Point(223, 110);
            this.labelCreateUsername.Name = "labelCreateUsername";
            this.labelCreateUsername.Size = new System.Drawing.Size(67, 16);
            this.labelCreateUsername.TabIndex = 0;
            this.labelCreateUsername.Text = "username";
            this.labelCreateUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCreatePassword
            // 
            this.labelCreatePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCreatePassword.AutoSize = true;
            this.labelCreatePassword.Location = new System.Drawing.Point(428, 109);
            this.labelCreatePassword.Name = "labelCreatePassword";
            this.labelCreatePassword.Size = new System.Drawing.Size(66, 16);
            this.labelCreatePassword.TabIndex = 1;
            this.labelCreatePassword.Text = "password";
            // 
            // textBoxCreateUsername
            // 
            this.textBoxCreateUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCreateUsername.Location = new System.Drawing.Point(226, 143);
            this.textBoxCreateUsername.Name = "textBoxCreateUsername";
            this.textBoxCreateUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreateUsername.TabIndex = 2;
            // 
            // textBoxCreatePassword
            // 
            this.textBoxCreatePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCreatePassword.Location = new System.Drawing.Point(431, 143);
            this.textBoxCreatePassword.Name = "textBoxCreatePassword";
            this.textBoxCreatePassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreatePassword.TabIndex = 3;
            this.textBoxCreatePassword.UseSystemPasswordChar = true;
            // 
            // labelCreateAge
            // 
            this.labelCreateAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCreateAge.AutoSize = true;
            this.labelCreateAge.Location = new System.Drawing.Point(226, 222);
            this.labelCreateAge.Name = "labelCreateAge";
            this.labelCreateAge.Size = new System.Drawing.Size(31, 16);
            this.labelCreateAge.TabIndex = 4;
            this.labelCreateAge.Text = "age";
            // 
            // labelCreateCountry
            // 
            this.labelCreateCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCreateCountry.AutoSize = true;
            this.labelCreateCountry.Location = new System.Drawing.Point(431, 222);
            this.labelCreateCountry.Name = "labelCreateCountry";
            this.labelCreateCountry.Size = new System.Drawing.Size(50, 16);
            this.labelCreateCountry.TabIndex = 5;
            this.labelCreateCountry.Text = "country";
            // 
            // buttonCreateUserr
            // 
            this.buttonCreateUserr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreateUserr.Location = new System.Drawing.Point(330, 356);
            this.buttonCreateUserr.Name = "buttonCreateUserr";
            this.buttonCreateUserr.Size = new System.Drawing.Size(102, 37);
            this.buttonCreateUserr.TabIndex = 8;
            this.buttonCreateUserr.Text = "Create";
            this.buttonCreateUserr.UseVisualStyleBackColor = true;
            this.buttonCreateUserr.Click += new System.EventHandler(this.buttonCreateUserr_Click);
            // 
            // numericUpDownCreateAge
            // 
            this.numericUpDownCreateAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownCreateAge.Location = new System.Drawing.Point(229, 259);
            this.numericUpDownCreateAge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownCreateAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCreateAge.Name = "numericUpDownCreateAge";
            this.numericUpDownCreateAge.Size = new System.Drawing.Size(61, 22);
            this.numericUpDownCreateAge.TabIndex = 9;
            this.numericUpDownCreateAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxCreateCountry
            // 
            this.comboBoxCreateCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCreateCountry.FormattingEnabled = true;
            this.comboBoxCreateCountry.Items.AddRange(new object[] {
            "Spain",
            "Germany",
            "England",
            "USA"});
            this.comboBoxCreateCountry.Location = new System.Drawing.Point(431, 256);
            this.comboBoxCreateCountry.Name = "comboBoxCreateCountry";
            this.comboBoxCreateCountry.Size = new System.Drawing.Size(100, 24);
            this.comboBoxCreateCountry.TabIndex = 10;
            // 
            // FormCreateUserr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCreateCountry);
            this.Controls.Add(this.numericUpDownCreateAge);
            this.Controls.Add(this.buttonCreateUserr);
            this.Controls.Add(this.labelCreateCountry);
            this.Controls.Add(this.labelCreateAge);
            this.Controls.Add(this.textBoxCreatePassword);
            this.Controls.Add(this.textBoxCreateUsername);
            this.Controls.Add(this.labelCreatePassword);
            this.Controls.Add(this.labelCreateUsername);
            this.Name = "FormCreateUserr";
            this.Text = "Create user";
            this.Load += new System.EventHandler(this.FormCreateUserr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreateAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateUsername;
        private System.Windows.Forms.Label labelCreatePassword;
        private System.Windows.Forms.TextBox textBoxCreateUsername;
        private System.Windows.Forms.TextBox textBoxCreatePassword;
        private System.Windows.Forms.Label labelCreateAge;
        private System.Windows.Forms.Label labelCreateCountry;
        private System.Windows.Forms.Button buttonCreateUserr;
        private System.Windows.Forms.NumericUpDown numericUpDownCreateAge;
        private System.Windows.Forms.ComboBox comboBoxCreateCountry;
    }
}