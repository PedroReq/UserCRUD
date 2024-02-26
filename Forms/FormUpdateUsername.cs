using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsUsu.Forms
{
    public partial class FormUpdateUsername : Form
    {
        // Form where the user's username is updated.

        SqlConnection con;
        UserrManagement um;
        ErrorProvider errorProvider1;
        Userr userr;
        private FormLogin parentForm;
        public FormUpdateUsername(FormLogin parentForm, Userr userr, SqlConnection con, UserrManagement um)
        {
            InitializeComponent();
            textBoxUsernameOld.Text = userr.Username;
            this.con = con;
            this.um = um;
            this.userr = userr;
            this.parentForm = parentForm;
            errorProvider1 = new ErrorProvider();       
        }

        private void buttonUpdateUsername_Click(object sender, EventArgs e)
        {
            con.Open();
            if (!String.IsNullOrEmpty(textBoxUsernameNew.Text))
            {
                if ((um.ObtainUserr(con,textBoxUsernameNew.Text) == null)) {
                    if ( um.UpdateUserr(con,userr.Id, textBoxUsernameNew.Text, "username"))
                    {
                        MessageBox.Show(this, "¡Username updated successfully!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userr.Username = textBoxUsernameNew.Text;
                        parentForm.setUserr(this.userr);
                        parentForm.closeForm();
                    }
                    else
                    {   
                        MessageBox.Show("Error updating Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorProvider1.SetError(textBoxUsernameNew, "Existing Username");
                }
            }
            else
            {
                errorProvider1.SetError(textBoxUsernameNew, "Empty Username");
            }
            con.Close();
        }

        private void FormUpdateUsername_Load(object sender, EventArgs e)
        {

        }
    }
}
