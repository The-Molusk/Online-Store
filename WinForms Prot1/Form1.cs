using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WinForms_Prot1
{
    public partial class Home : Form
    {
        public string errText; //error text for the error popup.
        int currentAd = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_ad1.Hide();
            btn_ad2.Hide();
            if (Global.UserID == null)
            {
                btn_profile.Text = "Login";
            }
            else btn_profile.Text = "Profile";

        }
        private void button2_Click(object sender, EventArgs e)  //opens either profile page or login page, depending on if you are logged in
        {
            if (Global.Username != null) //if you have a saved username, you open the profile page
            {
                Profile profilePage = new Profile();
                profilePage.Location = this.Location;
                profilePage.StartPosition = FormStartPosition.Manual;
                profilePage.Show();
                this.Close();
            }
            else //if no saved username, we go to login
            {
                Login loginPage = new Login();
                loginPage.Location = this.Location;
                loginPage.StartPosition = FormStartPosition.Manual;
                loginPage.Show();
                this.Close();
            }
        }

        private void btn_search_Click(object sender, EventArgs e) //searching for products?
        {
            if (txt_search.Text != "") //u gotta type somethign idiot
            {
                Global.SearchIten(this, txt_search.Text);
            }
            
        }

        private void btn_next_Click(object sender, EventArgs e) //cycles thorugh items
        {
            btn_ad0.Hide();
            btn_ad1.Hide();
            btn_ad2.Hide();
            switch (currentAd)
            {
                case 0:
                    btn_ad1.Show();
                    currentAd = 1;
                    break;
                case 1:
                    btn_ad2.Show();
                    currentAd = 2;
                    break;
                case 2:
                    btn_ad0.Show();
                    currentAd = 0;
                    break;
            }
        }

        private void btn_prev_Click(object sender, EventArgs e) //item cycle but backwards
        {
            btn_ad0.Hide();
            btn_ad1.Hide();
            btn_ad2.Hide();
            switch (currentAd)
            {
                case 0:
                    btn_ad2.Show();
                    currentAd = 2;
                    break;
                case 1:
                    btn_ad0.Show();
                    currentAd = 0;
                    break;
                case 2:
                    btn_ad1.Show();
                    currentAd = 1;
                    break;
            }
        }

        void OpenCategoryPage(string category) //used to open the category pages to view products of a specific category
        {
            if (category != "Cash")
            {
                CategoryPage categoryPage = new CategoryPage(category);
                categoryPage.Location = this.Location;
                categoryPage.StartPosition = FormStartPosition.Manual;
                categoryPage.Show();
                this.Close();
            }
            else //game cash is different, since it will have a fixed layout, since new products cant really be added to it
            {
                GameCash categoryPage = new GameCash(category);
                categoryPage.Location = this.Location;
                categoryPage.StartPosition = FormStartPosition.Manual;
                categoryPage.Show();
                this.Close();
            }
            
        }
        private void btn_cat1_Click(object sender, EventArgs e)
        {
            OpenCategoryPage("Skin"); //Fortnite players when they have to change their skin: AUUUUGHHHHHHHHHHH
        }

        private void btn_cat2_Click(object sender, EventArgs e)
        {
            OpenCategoryPage("Vehicle");
        }

        private void btn_cat3_Click(object sender, EventArgs e)
        {
            OpenCategoryPage("Cash");
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Global.OpenHome(this);
        }

        private void btn_ad1_Click(object sender, EventArgs e)
        {
            OpenProductPage((sender as Button).Text);
        }

        private void btn_ad0_Click(object sender, EventArgs e)
        {
            OpenProductPage((sender as Button).Text);
        }

        private void btn_ad2_Click(object sender, EventArgs e)
        {
            OpenProductPage((sender as Button).Text);
        }
        private void OpenProductPage(string name)
        {
            ProductPage productPage = new ProductPage(name);
            productPage.StartPosition = FormStartPosition.Manual;
            productPage.Location = this.Location;
            productPage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            connectivity.FillDB("DBTEST", 2000);
        }
    }
}
