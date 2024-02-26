using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsUsu.Forms
{
    public partial class FormUpdateAge : Form
    {
        // Form where the user's age is updated.

        SqlConnection con;
        UserrManagement um;
        ErrorProvider errorProvider1;
        Userr userr;
        private FormLogin parentForm;
        public FormUpdateAge(FormLogin parentForm, Userr userr, SqlConnection con, UserrManagement um)
        {
            InitializeComponent();
            textBoxAgeOld.Text = userr.Age.ToString();
            this.con = con;
            this.um = um;
            this.userr = userr;
            this.parentForm = parentForm;
            errorProvider1 = new ErrorProvider();
        }

        private void buttonUpdateAge_Click(object sender, EventArgs e)
        {
            
            con.Open();
            int newAge = Convert.ToInt32(numericUpDownNewAge.Value);
            if (newAge != 0)
            {
                    if (um.UpdateUserr(con, userr.Id, newAge.ToString(), "age"))
                    {
                        MessageBox.Show(this, "¡Age updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userr.Age = newAge;
                        parentForm.setUserr(this.userr);
                        parentForm.closeForm();
                    }
                    else
                    {
                        MessageBox.Show("Error updating Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                errorProvider1.SetError(numericUpDownNewAge, "Empty Age");
            }
            con.Close();
        }

        private void FormUpdateAge_Load(object sender, EventArgs e)
        {

        }
    }
}
