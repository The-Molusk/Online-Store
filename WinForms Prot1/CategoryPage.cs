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
    public partial class CategoryPage : Form
    {
        string Cat;
        public CategoryPage(string category)
        {
            InitializeComponent();
            lbl_title.Text = category +"s";
            Cat = category;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryPage_Load(object sender, EventArgs e)
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            var Products = connectivity.GetProductsOfCategory(Cat, 20); 
            //we get the products in the category:
            GenResults(Products.name, Products.price, Products.ID);
        }
        Label[] lblArray_SearchResults;
        Label[] lblArray_SearchResultsPrice;
        PictureBox[] picArray_SearchResultsImage;
        private void GenResults(string[] productArray, string[] priceArray, string[] idArray)
        {
            //generating all the labels for every single product in the specificied category
            lblArray_SearchResults = new Label[productArray.Length];
            lblArray_SearchResultsPrice = new Label[productArray.Length];
            picArray_SearchResultsImage = new PictureBox[productArray.Length];

            ImageSystem imageSystem = new ImageSystem();
            for (int i = 0; i < lblArray_SearchResults.Length; i++)
            {
                if (productArray[i] != null)
                {
                    lblArray_SearchResults[i] = new Label();
                    lblArray_SearchResults[i].Location = new Point(120, 140 + (i * 130));
                    lblArray_SearchResults[i].Text = productArray[i];
                    lblArray_SearchResults[i].ForeColor = Color.White;
                    lblArray_SearchResults[i].Font = new Font("Segoe UI", 27.75f);
                    lblArray_SearchResults[i].AutoSize = true;
                    lblArray_SearchResults[i].Click += new EventHandler(OpenSearchedProduct);
                    this.Controls.Add(lblArray_SearchResults[i]);

                    lblArray_SearchResultsPrice[i] = new Label();
                    lblArray_SearchResultsPrice[i].Location = new Point(120, 180 + (i * 130));
                    lblArray_SearchResultsPrice[i].Text = "£" + (Convert.ToDouble(priceArray[i]) / 100).ToString();
                    lblArray_SearchResultsPrice[i].ForeColor = Color.White;
                    lblArray_SearchResultsPrice[i].Font = new Font("Segoe UI", 27.75f);
                    lblArray_SearchResultsPrice[i].AutoSize = true;
                    lblArray_SearchResultsPrice[i].Click += new EventHandler(OpenSearchedProduct_price);
                    this.Controls.Add(lblArray_SearchResultsPrice[i]);

                    picArray_SearchResultsImage[i] = new PictureBox();
                    picArray_SearchResultsImage[i].Location = new Point(10, 150 + (i * 130));
                    picArray_SearchResultsImage[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    picArray_SearchResultsImage[i].Size = new Size(100, 100);
                    if (imageSystem.GetImageCount(Convert.ToInt32(idArray[i])) > 0)
                    {
                        picArray_SearchResultsImage[i].Image = imageSystem.GetImageRoot_Product(idArray[i], 0);
                    }
                    else
                    {
                        picArray_SearchResultsImage[i].Image = imageSystem.GetPlaceholder();
                    }
                    picArray_SearchResultsImage[i].Click += new EventHandler(OpenSearchedProduct_picture);
                    this.Controls.Add(picArray_SearchResultsImage[i]);
                }
            }
        }
        private void OpenSearchedProduct(object sender, EventArgs e)
        {
            Label label = sender as Label;
            Global.OpenProductPage(label.Text, this);
        }
        private void OpenSearchedProduct_picture(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int position = Array.IndexOf(picArray_SearchResultsImage, pictureBox);
            Global.OpenProductPage(lblArray_SearchResults[position].Text, this);
        }
        private void OpenSearchedProduct_price(object sender, EventArgs e)
        {
            Label label = sender as Label;
            int position = Array.IndexOf(lblArray_SearchResultsPrice, label);
            Global.OpenProductPage(lblArray_SearchResults[position].Text, this);
        }

        private void CategoryPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if ((new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")))
            //{
            //    //closed via home
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
    }
}
