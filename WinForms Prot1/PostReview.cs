using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Prot1
{
    public partial class PostReview : Form
    {
        int productID;
        public PostReview(int ID)
        {
            InitializeComponent();
            productID = ID;
        }

        //user adding anew review to the system
        private void btn_post_Click(object sender, EventArgs e)
        {
            string reviewText = txt_review.Text;
            try
            {
                int rating = Convert.ToInt32(txt_rating.Text);
                if (Global.Sanitise(reviewText) && Global.Sanitise(rating.ToString()))
                {
                    DatabaseConnectivity connectivity = new DatabaseConnectivity();
                    connectivity.Initialise();
                    if (rating >= 0 && rating <= 10)
                    {
                        connectivity.AddReview(Global.UserID, productID, rating, reviewText);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Wrong rating format");
            }
            
        }

        private void btn_home_Click(object sender, EventArgs e)
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
    }
}
