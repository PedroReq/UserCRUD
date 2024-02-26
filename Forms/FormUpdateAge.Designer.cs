namespace WindowsFormsUsu.Forms
{
    partial class FormUpdateAge
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
            this.buttonUpdateAge = new System.Windows.Forms.Button();
            this.labelAgeNew = new System.Windows.Forms.Label();
            this.textBoxAgeOld = new System.Windows.Forms.TextBox();
            this.labelAgeOld = new System.Windows.Forms.Label();
            this.numericUpDownNewAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewAge)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateAge
            // 
            this.buttonUpdateAge.Location = new System.Drawing.Point(274, 243);
            this.buttonUpdateAge.Name = "buttonUpdateAge";
            this.buttonUpdateAge.Size = new System.Drawing.Size(119, 33);
            this.buttonUpdateAge.TabIndex = 12;
            this.buttonUpdateAge.Text = "Update";
            this.buttonUpdateAge.UseVisualStyleBackColor = true;
            this.buttonUpdateAge.Click += new System.EventHandler(this.buttonUpdateAge_Click);
            // 
            // labelAgeNew
            // 
            this.labelAgeNew.AutoSize = true;
            this.labelAgeNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgeNew.Location = new System.Drawing.Point(237, 172);
            this.labelAgeNew.Name = "labelAgeNew";
            this.labelAgeNew.Size = new System.Drawing.Size(67, 18);
            this.labelAgeNew.TabIndex = 10;
            this.labelAgeNew.Text = "New Age";
            // 
            // textBoxAgeOld
            // 
            this.textBoxAgeOld.Enabled = false;
            this.textBoxAgeOld.Location = new System.Drawing.Point(352, 106);
            this.textBoxAgeOld.Name = "textBoxAgeOld";
            this.textBoxAgeOld.Size = new System.Drawing.Size(100, 22);
            this.textBoxAgeOld.TabIndex = 9;
            // 
            // labelAgeOld
            // 
            this.labelAgeOld.AutoSize = true;
            this.labelAgeOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgeOld.Location = new System.Drawing.Point(246, 106);
            this.labelAgeOld.Name = "labelAgeOld";
            this.labelAgeOld.Size = new System.Drawing.Size(33, 18);
            this.labelAgeOld.TabIndex = 8;
            this.labelAgeOld.Text = "Age";
            // 
            // numericUpDownNewAge
            // 
            this.numericUpDownNewAge.Location = new System.Drawing.Point(377, 172);
            this.numericUpDownNewAge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownNewAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNewAge.Name = "numericUpDownNewAge";
            this.numericUpDownNewAge.Size = new System.Drawing.Size(61, 22);
            this.numericUpDownNewAge.TabIndex = 13;
            this.numericUpDownNewAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormUpdateAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownNewAge);
            this.Controls.Add(this.buttonUpdateAge);
            this.Controls.Add(this.labelAgeNew);
            this.Controls.Add(this.textBoxAgeOld);
            this.Controls.Add(this.labelAgeOld);
            this.Name = "FormUpdateAge";
            this.Text = "Update Age";
            this.Load += new System.EventHandler(this.FormUpdateAge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateAge;
        private System.Windows.Forms.Label labelAgeNew;
        private System.Windows.Forms.TextBox textBoxAgeOld;
        private System.Windows.Forms.Label labelAgeOld;
        private System.Windows.Forms.NumericUpDown numericUpDownNewAge;
    }
}