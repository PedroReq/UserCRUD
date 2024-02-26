using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsUsu.Forms
{
    public partial class FormCreateUserr : Form
    {
        // User creation Form
        SqlConnection con;
        UserrManagement um;
        ErrorProvider errorProvider1, errorProvider2, errorProvider3, errorProvider4;
        private FormLogin parentForm;

        private void FormCreateUserr_Load(object sender, EventArgs e)
        {

        }

        public FormCreateUserr(FormLogin parentForm, UserrManagement um , SqlConnection con)
        {
            InitializeComponent();
            
            errorProvider1 = new ErrorProvider();
            errorProvider2 = new ErrorProvider();
            errorProvider3 = new ErrorProvider();
            errorProvider4 = new ErrorProvider();
            this.parentForm = parentForm;
            this.um = um;
            this.con = con;
        }

        private void buttonCreateUserr_Click(object sender, EventArgs e)
        { 
            con.Open();
            if (!comprovateErrors())
            {    
                try
                {
                    Userr userr = new Userr(null, textBoxCreateUsername.Text, um.HashPassword(textBoxCreatePassword.Text), Convert.ToInt32(numericUpDownCreateAge.Value), comboBoxCreateCountry.SelectedItem.ToString());
                    um.InsertUserr(con, userr);
                    MessageBox.Show(this, "¡User created successfully!\nUsername: " + userr.Username, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   parentForm.closeForm();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
            }
            con.Close();
        }

        private bool comprovateErrors()
        {
            bool error = false;
            if (String.IsNullOrEmpty(textBoxCreateUsername.Text))
            {
                errorProvider1.SetError(textBoxCreateUsername, "Empty username");
                error = true;
            }
            else
            {
                if (um.ObtainUserr(con, textBoxCreateUsername.Text) != null)
                {
                    errorProvider1.SetError(textBoxCreateUsername, "Existing username");
                    error = true;
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            if (String.IsNullOrEmpty(textBoxCreatePassword.Text))
            {
                errorProvider2.SetError(textBoxCreatePassword, "Empty password");
                error = true;
            }
            else
            {
                errorProvider2.Clear();
            }
            if (Convert.ToInt32(numericUpDownCreateAge.Value) == 0)
            {
                errorProvider3.SetError(numericUpDownCreateAge, "Empty age");
                error = true;
            }
            else
            {
                errorProvider3.Clear();
            }
            object selectedCountry = comboBoxCreateCountry.SelectedItem;
            if (selectedCountry == null)
            {
                errorProvider4.SetError(comboBoxCreateCountry, "Empty country");
                error = true;
            }
            else
            {
                errorProvider4.Clear();
            }
            return error;

        }
        
    }
}
