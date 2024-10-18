using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;

namespace WinForms_Prot1
{
    public partial class Login : Form
    {
        string HashedPassword;
        public Login()
        {
            InitializeComponent();
        }
        private void btn_noAcc_Click(object sender, EventArgs e) //create an account
        {
            SignUp signUpPage = new SignUp();
            signUpPage.Location = this.Location;
            signUpPage.StartPosition = FormStartPosition.Manual;
            signUpPage.Show();
            this.Close();
        }
        private void btn_proceed_Click(object sender, EventArgs e) //create account
        {
            
            string Username = txt_Username.Text;
            string Password = txt_password.Text;
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            if (Global.Sanitise(Password) && Global.Sanitise(Username))
            {
                connectivity.Initialise();
                string salt = connectivity.GetPasswordSalt(Username);
                if (salt != null)
                {
                    Hashing hashing = new Hashing();
                    HashedPassword = hashing.HashData(Password, salt);
                }

                if (HashedPassword != null && HashedPassword == connectivity.GetUserInfo(Username, "Password"))  //checks if password good?
                {
                    //MessageBox.Show("Successful login!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //augggh
                    int accessLevel = Convert.ToInt16(connectivity.GetUserInfo(Username, "AccessLevel")); //gets access level

                    Global.Username = Username; //sets the global variables to the stuff
                    Global.UserID = Convert.ToInt32(connectivity.GetUserInfo(Username, "UserID"));
                    Global.AccessLevel = accessLevel;
                    Home homePage = new Home(); //NEW HOME PAGE !!!!
                    homePage.Location = this.Location;
                    homePage.StartPosition = FormStartPosition.Manual;
                    homePage.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_forgot_Click(object sender, EventArgs e) //forgor password
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            //literally 1984 right here:
            MessageBox.Show(connectivity.GetUserInfo(txt_Username.Text, "Password"), "Password:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")))
            {
                //if u pressed X, u go back home
                Home home = new Home();
                home.Location = this.Location;
                home.StartPosition = FormStartPosition.Manual;
                home.Show();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Global.OpenHome(this);
        }
    }
}
