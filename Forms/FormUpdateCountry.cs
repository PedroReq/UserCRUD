using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsUsu.Forms
{
    public partial class FormUpdateCountry : Form
    {
        // Form where the user's country is updated.

        SqlConnection con;
        UserrManagement um;
        ErrorProvider errorProvider1;
        Userr userr;
        private FormLogin parentForm;
        public FormUpdateCountry(FormLogin parentForm, Userr userr, SqlConnection con, UserrManagement um)
        {
            InitializeComponent();
            textBoxCountryOld.Text = userr.Country;
            this.con = con;
            this.um = um;
            this.userr = userr;
            this.parentForm = parentForm;
            errorProvider1 = new ErrorProvider();
        }


        private void buttonUpdateCountry_Click(object sender, EventArgs e)
        {
            con.Open();
            object selectedCountry = comboBoxUpdateCountry.SelectedItem;
            if (selectedCountry != null)
            {
                string country = comboBoxUpdateCountry.SelectedItem.ToString();
                if (um.UpdateUserr(con, userr.Id, country, "country"))
                {
                    MessageBox.Show(this, "¡Country updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userr.Country = country;
                    parentForm.setUserr(this.userr);
                    parentForm.closeForm();
                }
                else
                {
                    MessageBox.Show("Error updating Country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                errorProvider1.SetError(comboBoxUpdateCountry, "Empty Country");
            }
            con.Close();
        }

        private void FormUpdateCountry_Load(object sender, EventArgs e)
        {

        }
    }
}
