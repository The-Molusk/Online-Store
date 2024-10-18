using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Prot1
{
    public partial class ReviewsPage : Form
    {
        int productID;
        string name;
        int?[] reviewID;
        public ReviewsPage(int productID, string name)
        {
            InitializeComponent();
            this.productID = productID;
            this.name = name;
        }

        private void ReviewsPage_Load(object sender, EventArgs e)
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();

            //getting all required info from the database
            var Info = connectivity.GetReviewInfo(productID.ToString(), 3);
            reviewID = Info.reviewID;
            CreateLabels(Info.userID, Info.rating, Info.review, Info.username);
            lbl_title.Text = "Reviews for " + name;
        }

        Label[] lblArray_username;
        Label[] lblArray_rating;
        Label[] lblArray_review;
        PictureBox[] picArray_user;
        ImageSystem image;
        Button[] btnArr_modRemove;
        private void CreateLabels(int?[] UserID, int?[] Rating, string[] Review, string[] username)
        {
            //generating all the labels for the reviews that have been posted
            lblArray_username = new Label[UserID.Length];
            lblArray_rating = new Label[UserID.Length];
            lblArray_review = new Label[UserID.Length];
            picArray_user = new PictureBox[UserID.Length];
            image = new ImageSystem();
            btnArr_modRemove = new Button[UserID.Length];

            for(int i = 0; i < UserID.Length; i++)
            {
                if (UserID[i] != null)
                {
                    lblArray_username[i] = new Label();
                    lblArray_username[i].Location = new Point(120, 120 + (i * 130));
                    lblArray_username[i].Text = username[i];
                    lblArray_username[i].ForeColor = Color.White;
                    lblArray_username[i].Font = new Font("Segoe UI", 27.75f);
                    lblArray_username[i].AutoSize = true;
                    this.Controls.Add(lblArray_username[i]);

                    lblArray_rating[i] = new Label();
                    lblArray_rating[i].Location = new Point(600, 120 + (i * 130));
                    lblArray_rating[i].Text = Rating[i].ToString() + @"/10";
                    lblArray_rating[i].ForeColor = Color.Yellow;
                    lblArray_rating[i].Font = new Font("Segoe UI", 20f);
                    lblArray_rating[i].AutoSize = true;
                    this.Controls.Add(lblArray_rating[i]);

                    lblArray_review[i] = new Label();
                    lblArray_review[i].Location = new Point(120, 170 + (i * 130));
                    lblArray_review[i].Text = Review[i];
                    lblArray_review[i].ForeColor = Color.White;
                    lblArray_review[i].Font = new Font("Segoe UI", 14f);
                    lblArray_review[i].AutoSize = true;
                    this.Controls.Add(lblArray_review[i]);

                    picArray_user[i] = new PictureBox();
                    picArray_user[i].Location = new Point(10, 130 + (i * 130));
                    picArray_user[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    picArray_user[i].Size = new Size(100, 100);
                    try
                    {
                        picArray_user[i].Image = image.GetImageRoot_User(UserID[i]);
                    }
                    catch (Exception e) 
                    {
                        picArray_user[i].Image = image.GetPlaceholder();
                    }
                    this.Controls.Add(picArray_user[i]);

                    if (Global.AccessLevel >= 1)
                    {
                        btnArr_modRemove[i] = new Button();
                        btnArr_modRemove[i].Location = new Point(700, 120 + (i * 130));
                        btnArr_modRemove[i].Size = new Size(80,20);
                        btnArr_modRemove[i].Text = "Delete";
                        btnArr_modRemove[i].ForeColor = Color.White;
                        btnArr_modRemove[i].BackColor = Color.DarkRed;
                        btnArr_modRemove[i].Font = new Font("Segoe UI", 14f);
                        btnArr_modRemove[i].AutoSize = true;
                        btnArr_modRemove[i].Click += new EventHandler(ModeratorRemove);
                        this.Controls.Add(btnArr_modRemove[i]);
                    }
                }
            }
        }
        private void ModeratorRemove(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int position = Array.IndexOf(btnArr_modRemove, button);
            int? ID = reviewID[position];

            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            connectivity.ModeratorRemove(Convert.ToInt32(ID));

            MessageBox.Show("Review Removed");
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

        private void btn_postReview_Click(object sender, EventArgs e)
        {
            if (Global.UserID != null)
            {
                DatabaseConnectivity connectivity = new DatabaseConnectivity();
                connectivity.Initialise();
                string access = connectivity.GetUserInfo(Global.Username, "CommunityAccess");
                if (access == "1")
                {
                    PostReview post = new PostReview(productID);
                    post.StartPosition = FormStartPosition.Manual;
                    post.Location = this.Location;
                    post.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You are community banned");
                }
                
            }
            else MessageBox.Show("You must be logged in to post a review");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            connectivity.RemoveOwnReview(Convert.ToInt32(Global.UserID), productID);
            MessageBox.Show("Review Removed");
        }
    }
}
