using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsUsu
{
    public partial class FormLogin : Form
    {
        // Establish your connection to your database
        private SqlConnection con = new SqlConnection("SERVER=.\\*****;DATABASE=*****;integrated security=true;");
       
        private Button currentButton;
        private List<Form> activeForms = new List<Form>();
        private UserrManagement um = new UserrManagement();
        Userr userr;


        public FormLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            um.createTable(this.con);
            buttonCloseChildForm.Visible = false;
            disableButtonsUserr();
            activeForms.Add(this);
        }

        private void ChangeButton(object btnSender)
        {
            // The style of the selected button is changed.
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    ReturnButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = System.Drawing.SystemColors.MenuText;
                    currentButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void ReturnButton()
        {
            // The button style is returned to the original.
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Transparent;
                    previousBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    previousBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }


        }

        private void disableButtonsUserr()
        {
            // Userr update buttons are not shown in the login form.
            for (int i = 0; i < panelMenu.Controls.Count - 2; i++)
            {
                Control currentBtn = panelMenu.Controls[i];
                if (currentBtn.GetType() == typeof(Button))
                {
                  currentBtn.Visible = false;
                }
            }
            buttonCreateUser.Visible = true;
        }
        private void activateButtonsUserr()
        {
            // The update userr buttons are activated and the creation button is hidden.
            for (int i = 0; i < panelMenu.Controls.Count - 2; i++)
            {
                Control currentBtn = panelMenu.Controls[i];
                if (currentBtn.GetType() == typeof(Button))
                {
                    currentBtn.Visible = true;
                }
            }
            buttonCreateUser.Visible = false;
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            ChangeButton(sender);
            buttonCloseChildForm.Visible = true;
            openChildForm(new Forms.FormCreateUserr(this,um, con), sender);
        }

        private void openChildForm(Form childForm, object btnSender)
        {
          
            activeForms.Add(childForm);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
            buttonCloseChildForm.Visible = true;
        }

        public void ResetLogin()
        {
            ReturnButton();
            labelTitle.Text = "LOGIN";
            currentButton = null;
            buttonCloseChildForm.Visible = false;
            disableButtonsUserr();
            activeForms[activeForms.Count - 1].Refresh();
        }
        public void ResetProfile()
        {    
            ReturnButton();
            labelTitle.Text = "Profile";
            currentButton = null;
            activeForms[activeForms.Count - 1].Refresh();
        }

        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            closeForm();
            
        }
        public void closeForm()
        {
            /*
              The form is closed and if the total number of forms is 2, the "PROFILE" menu is updated. 
              If there is only 1 active form, it is implied that the remaining form is the "LOGIN"
              and updates to the "LOGIN" menu.
             */
            activeForms[activeForms.Count - 1].Close();
            activeForms.RemoveAt(activeForms.Count - 1);
            if (activeForms.Count == 2)
            {
                ResetProfile();
               
            }
            else
            {
                ResetLogin();
            }
        }
        public void close3dForm()
        {
            // The update form that is no longer used is closed.
            if (activeForms.Count >= 3)
            {
                activeForms[activeForms.Count - 1].Close();
                activeForms.RemoveAt(activeForms.Count - 1);
            }
            
        }
            
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            con.Open();
            userr = um.ObtainUserr(con, textBoxUsername.Text);
            con.Close();
            if (userr != null)
            {
                if (um.HashPassword(textBoxPassword.Text).Equals(userr.Password))
                {
                    activateButtonsUserr();
                    openChildForm(new Forms.FormProfile(userr), sender);
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public void setUserr(Userr userr)
        {
            this.userr = userr;
            foreach (var form in activeForms.OfType<Forms.FormProfile>())
            {
                form.updateUserr(userr);
            }
        }
        private void buttonUpdateUsername_Click(object sender, EventArgs e)
        {
            ChangeButton(sender);
            close3dForm();
            buttonCloseChildForm.Visible = true;
            openChildForm(new Forms.FormUpdateUsername(this,userr, con, um), sender);
        }

        private void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            ChangeButton(sender);
            close3dForm();
            buttonCloseChildForm.Visible = true;
            openChildForm(new Forms.FormUpdatePassword(this, userr, con, um), sender);
        }

        private void buttonUpdateAge_Click(object sender, EventArgs e)
        {
            ChangeButton(sender);
            close3dForm();
            buttonCloseChildForm.Visible = true;
            openChildForm(new Forms.FormUpdateAge(this, userr, con, um), sender);
        }

        private void buttonUpdateCountry_Click(object sender, EventArgs e)
        {
            ChangeButton(sender);
            close3dForm();
            buttonCloseChildForm.Visible = true;
            openChildForm(new Forms.FormUpdateCountry(this, userr, con, um), sender);
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
