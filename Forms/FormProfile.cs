using System;
using System.Windows.Forms;

namespace WindowsFormsUsu.Forms
{
    public partial class FormProfile : Form
    {
        // Form where the user's data is displayed.

        Userr userr;
        public FormProfile(Userr userr)
        {
            InitializeComponent();
            this.userr = userr;
            labelWelkome.Text += this.userr.Username + "!";
            textBoxViewUsername.Text = this.userr.Username;
            textBoxViewPassword.Text = this.userr.Password;
            textBoxViewAge.Text = this.userr.Age.ToString();
            textBoxViewCountry.Text = this.userr.Country;
            
        }
        public void updateUserr(Userr userr)
        {
            this.userr = userr;
            labelWelkome.Text = "Welkome: " + this.userr.Username + "!";
            textBoxViewUsername.Text = this.userr.Username;
            textBoxViewPassword.Text = this.userr.Password;
            textBoxViewAge.Text = this.userr.Age.ToString();
            textBoxViewCountry.Text = this.userr.Country;

        }
        private void FormProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
