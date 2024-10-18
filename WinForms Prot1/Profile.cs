using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace WinForms_Prot1
{
    public partial class Profile : Form
    {
      
        string User;
        public Profile()
        {
            InitializeComponent();
        }

        public void InitProfile(string Username)
        {
            txt_dateDay.Hide();
            txt_dateMonth.Hide();
            txt_dateYear.Hide();
            txt_name.Hide();
            txt_phoneNo.Hide();
            btn_confirm.Hide();
            btn_cancel.Hide();

            User = Username;
            DatabaseConnectivity connectivity = new DatabaseConnectivity(); //database connection
            connectivity.Initialise();
            string Email = connectivity.GetUserInfo(Username, "Email"); //adding all the required stuff to be shown on the profile page
            string PhoneNo = connectivity.GetUserInfo(Username, "Phone");
            int access = Convert.ToInt16(connectivity.GetUserInfo(Username, "AccessLevel"));
            string FullName = connectivity.GetUserInfo(Username, "FullName");
            string TempDOB = connectivity.GetUserInfo(Username, "DOB");
            string DOB = "";
            if (TempDOB != "")
            {
                DOB = TempDOB.Substring(0, 2) + "/" + TempDOB.Substring(2, 2) + "/" + TempDOB.Substring(4, 4);
            }
            string role = "";
            switch (access)
            {
                //access level so that (hypothetically) if Jeremy Fitzgerald from the Five Night At Freddy's story line
                //(who was the victim of the bite of '87) came back to life and needed to see what access level he had
                //on this really cool app, he would be able to check easilly by reading it on screen instead of having to
                //interpret the meaning of some number.
                case 0:
                    role = "User";
                    break;
                case 1:
                    role = "Moderator";
                    break;
                case 2:
                    role = "Administrator";
                    break;
            }
            //sets all the damn labels to the good stuff >:)
            lbl_username.Text = Username;
            lbl_email.Text = Email;
            lbl_phoneNo.Text += PhoneNo;
            lbl_access.Text = role;
            lbl_DOB.Text += DOB;
            lbl_Name.Text += FullName;

            ImageSystem imageSys = new ImageSystem();
            try
            {
                pic_profile.Image = imageSys.GetImageRoot_User(Global.UserID);
            }
            catch (Exception e) 
            {
                pic_profile.Image = imageSys.GetPlaceholder();
            };
            
        }
        private void btn_admin_Click(object sender, EventArgs e)
        {
            if (btn_admin.Enabled && Global.AccessLevel == 2)
            {
                //opening the admin panel
                AdminPanel admin = new AdminPanel();
                admin.StartPosition = FormStartPosition.Manual;
                admin.Location = this.Location;
                admin.Show();
                this.Close();
            }
        }

        private void btn_delAcc_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DatabaseConnectivity connectivity = new DatabaseConnectivity(); 
                connectivity.Initialise();
                connectivity.DeleteAccount(User);
                //i cant be bothered to reset everything so ill just make the user have to restart the program aftetr deleting their account
                MessageBox.Show("Application needs to restart to confirm account removal", "Restart Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(1);
            }
        }
        private void btn_viewPurchases_Click(object sender, EventArgs e)
        {
            PastPurchases pastPurchases = new PastPurchases();
            pastPurchases.Location = this.Location;
            pastPurchases.StartPosition = FormStartPosition.Manual;
            pastPurchases.Show();
            this.Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            if (Global.AccessLevel == 2)
            {
                btn_admin.Show();
            }
            else btn_admin.Hide();
            InitProfile(Global.Username);
        }
        #region goofy functions
        private void btn_home_Click_1(object sender, EventArgs e)
        {
            Global.OpenHome(this);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Global.SearchIten(this, txt_search.Text);
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Global.OpenProfile(this);
        }
        

        private void btn_Basket_Click(object sender, EventArgs e)
        {
            Global.OpenBasket(this);
        }
        #endregion

        private void btn_signOut_Click(object sender, EventArgs e)
        {
            Global.UserID = null;
            Global.Username = null;
            Global.AccessLevel = null;
            Global.OpenHome(this);
        }

        private void btn_changePfp_Click(object sender, EventArgs e)
        {
            ImageSystem imageSystem = new ImageSystem();
            pic_profile.Image = imageSystem.GetPlaceholder();
            imageSystem.AddImage_User(Global.UserID);
            pic_profile.Image = imageSystem.GetImageRoot_User(Global.UserID);
        }

        private void btn_changeInfo_Click(object sender, EventArgs e)
        {
            //this allows the user to change their personal info on the system
            lbl_Name.Text = "Name: ";
            lbl_phoneNo.Text = "Phone number: ";
            lbl_DOB.Text = "Date of birth: ";

            txt_dateDay.Show();
            txt_dateMonth.Show();
            txt_dateYear.Show();
            txt_name.Show();
            txt_phoneNo.Show();

            btn_changeInfo.Hide();
            btn_confirm.Show();
            btn_cancel.Show();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //actually changes the values int eh database to new infomation entered
            string name = txt_name.Text;
            string phoneNo = txt_phoneNo.Text;
            string DOB = txt_dateDay.Text + txt_dateMonth.Text + txt_dateYear.Text;

            if(Global.Sanitise(name) && Global.Validate(DOB, "dob") && Global.Validate(phoneNo, "phone"))
            {
                DatabaseConnectivity connectivity = new DatabaseConnectivity();
                connectivity.Initialise();
                connectivity.UpdateUserInfo(User, name, DOB, phoneNo);
                MessageBox.Show("Updated Info");
                this.InitProfile(User);
                btn_changeInfo.Show();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.InitProfile(User);
            btn_changeInfo.Show();
        }
    }
}
