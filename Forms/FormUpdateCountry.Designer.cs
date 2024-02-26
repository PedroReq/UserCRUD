namespace WindowsFormsUsu.Forms
{
    partial class FormUpdateCountry
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
            this.buttonUpdateCountry = new System.Windows.Forms.Button();
            this.labelCountryNew = new System.Windows.Forms.Label();
            this.textBoxCountryOld = new System.Windows.Forms.TextBox();
            this.labelCountryOld = new System.Windows.Forms.Label();
            this.comboBoxUpdateCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonUpdateCountry
            // 
            this.buttonUpdateCountry.Location = new System.Drawing.Point(293, 225);
            this.buttonUpdateCountry.Name = "buttonUpdateCountry";
            this.buttonUpdateCountry.Size = new System.Drawing.Size(119, 33);
            this.buttonUpdateCountry.TabIndex = 12;
            this.buttonUpdateCountry.Text = "Update";
            this.buttonUpdateCountry.UseVisualStyleBackColor = true;
            this.buttonUpdateCountry.Click += new System.EventHandler(this.buttonUpdateCountry_Click);
            // 
            // labelCountryNew
            // 
            this.labelCountryNew.AutoSize = true;
            this.labelCountryNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryNew.Location = new System.Drawing.Point(201, 168);
            this.labelCountryNew.Name = "labelCountryNew";
            this.labelCountryNew.Size = new System.Drawing.Size(94, 18);
            this.labelCountryNew.TabIndex = 10;
            this.labelCountryNew.Text = "New Country";
            // 
            // textBoxCountryOld
            // 
            this.textBoxCountryOld.Enabled = false;
            this.textBoxCountryOld.Location = new System.Drawing.Point(341, 107);
            this.textBoxCountryOld.Name = "textBoxCountryOld";
            this.textBoxCountryOld.Size = new System.Drawing.Size(100, 22);
            this.textBoxCountryOld.TabIndex = 9;
            // 
            // labelCountryOld
            // 
            this.labelCountryOld.AutoSize = true;
            this.labelCountryOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryOld.Location = new System.Drawing.Point(235, 107);
            this.labelCountryOld.Name = "labelCountryOld";
            this.labelCountryOld.Size = new System.Drawing.Size(60, 18);
            this.labelCountryOld.TabIndex = 8;
            this.labelCountryOld.Text = "Country";
            // 
            // comboBoxUpdateCountry
            // 
            this.comboBoxUpdateCountry.FormattingEnabled = true;
            this.comboBoxUpdateCountry.Items.AddRange(new object[] {
            "Spain",
            "Germany",
            "England",
            "USA"});
            this.comboBoxUpdateCountry.Location = new System.Drawing.Point(341, 168);
            this.comboBoxUpdateCountry.Name = "comboBoxUpdateCountry";
            this.comboBoxUpdateCountry.Size = new System.Drawing.Size(100, 24);
            this.comboBoxUpdateCountry.TabIndex = 13;
            // 
            // FormUpdateCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxUpdateCountry);
            this.Controls.Add(this.buttonUpdateCountry);
            this.Controls.Add(this.labelCountryNew);
            this.Controls.Add(this.textBoxCountryOld);
            this.Controls.Add(this.labelCountryOld);
            this.Name = "FormUpdateCountry";
            this.Text = "Update Country";
            this.Load += new System.EventHandler(this.FormUpdateCountry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateCountry;
        private System.Windows.Forms.Label labelCountryNew;
        private System.Windows.Forms.TextBox textBoxCountryOld;
        private System.Windows.Forms.Label labelCountryOld;
        private System.Windows.Forms.ComboBox comboBoxUpdateCountry;
    }
}