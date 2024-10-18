using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.ComponentModel.Design;

namespace WinForms_Prot1
{
    public partial class GameCash : Form
    {
        string Cat;
        public GameCash(string category)
        {
            InitializeComponent();
            Cat = category;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close(); //auuuughhhhhhhh
        }

        private void GameCash_Load(object sender, EventArgs e)
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            //we do a lil getting the products:
            var temp = connectivity.GetProductsOfCategory(Cat, 5);
            //incredibly efficient program:
            btn_item01.Text = temp.name[0];
            btn_item02.Text = temp.name[1];
            btn_item03.Text = temp.name[2];
            btn_item04.Text = temp.name[3];
            btn_item05.Text = temp.name[4];
        }

        private void GameCash_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if ((new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")))
            //{
            //    //if u pressed X, u go back home
            //    Home home = new Home();
            //    home.Location = this.Location;
            //    home.StartPosition = FormStartPosition.Manual;
            //    home.Show();
            //}
            //else
            //{
            //    Environment.Exit(1);
            //}
        }
        private void LoadProduct(object sender)
        {
            Button button = sender as Button;
            Global.OpenProductPage(button.Text, this);
        }
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

        private void btn_item01_Click(object sender, EventArgs e)
        {
            LoadProduct(sender);
        }

        private void btn_item02_Click(object sender, EventArgs e)
        {
            LoadProduct(sender);
        }

        private void btn_item03_Click(object sender, EventArgs e)
        {
            LoadProduct(sender);
        }

        private void btn_item04_Click(object sender, EventArgs e)
        {
            LoadProduct(sender);
        }

        private void btn_item05_Click(object sender, EventArgs e)
        {
            LoadProduct(sender);
        }
    }
}
