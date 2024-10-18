using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Linq;

namespace WinForms_Prot1
{
    public partial class SignUp : Form
    {
        bool hasAccepted; //TAC Accepted?
        public SignUp()
        {
            InitializeComponent();
        }

        private void cBox_TAC_CheckedChanged(object sender, EventArgs e) //simply checks if you have agreen To T&Cs
        {
            if (cBox_TAC.Checked)
            {
                hasAccepted = true;
            }
            else hasAccepted = false;
        }

        private void lbl_TAC_Click(object sender, EventArgs e) //opens T&Cs
        {
            TAC tacPage = new TAC();
            tacPage.Location = this.Location;
            tacPage.StartPosition = FormStartPosition.Manual; //esnures page is centred
            tacPage.Show();
        }

        private void btn_LoginPage_Click(object sender, EventArgs e) //Switches to the login page
        {
            OpenLoginPage();
        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {
            //takes all text box inputs
            string username = txt_Username.Text;
            string password = txt_password.Text;
            string confirm = txt_confirmPassword.Text;
            string email = txt_email.Text;
            string phone = txt_Phone.Text;

            DatabaseConnectivity Connectivity = new DatabaseConnectivity(); //database connection

            if (password == confirm) //Passwords match?
            {
                if (hasAccepted)
                {
                    Connectivity.Initialise();
                    if (Global.Validate(username,"username") && Global.Validate(password,"password") && Global.Validate(email,"email") && Global.Validate(phone,"phone")&& Global.Sanitise(username) && Global.Sanitise(password) && Global.Sanitise(email) && Global.Sanitise(phone))
                    {
                        Hashing hashing = new Hashing();
                        var hashedPassword = hashing.NewHash(password);
                        bool success = Connectivity.AddUser(username, hashedPassword.HashedData, email, phone, hashedPassword.salt);  //adds the user to the database
                        if (success)
                        {
                            OpenLoginPage();
                        }
                        else return;
                    }
                    else return;

                }
                else
                {
                    MessageBox.Show("You must accept the terms and conditions before you can create an account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Cant proceed without accpeting 
                }
            }
            else
            {
                MessageBox.Show("Make sure both passwords match", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error); //Literally just type the same thing again stupid
            }
        }
        void OpenLoginPage()
        {
            Login loginPage = new Login();
            loginPage.Location = this.Location;
            loginPage.StartPosition = FormStartPosition.Manual;
            loginPage.Show();
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Global.OpenHome(this);
        }
    }
}
