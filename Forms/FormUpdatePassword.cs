using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsUsu.Forms
{
    public partial class FormUpdatePassword : Form
    {
        // Form where the user's password is updated.

        SqlConnection con;
        UserrManagement um;
        ErrorProvider errorProvider1;
        Userr userr;
        private FormLogin parentForm;
        public FormUpdatePassword(FormLogin parentForm, Userr userr, SqlConnection con, UserrManagement um)
        {
            InitializeComponent();
            this.con = con;
            this.um = um;
            this.userr = userr;
            this.parentForm = parentForm;
            errorProvider1 = new ErrorProvider();
        }

        private void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            con.Open();
            if (!String.IsNullOrEmpty(textBoxPasswordNew.Text))
            {
                string password = um.HashPassword(textBoxPasswordNew.Text);

                if (um.UpdateUserr(con, userr.Id, password, "password"))
                {
                    MessageBox.Show(this, "¡Password updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userr.Password = password;
                    parentForm.setUserr(this.userr);
                    parentForm.closeForm();
                }
                else
                {
                    MessageBox.Show("Error updating Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                errorProvider1.SetError(textBoxPasswordNew, "Empty Password");
            }
            con.Close();
        }

        private void textBoxPasswordNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormUpdatePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
