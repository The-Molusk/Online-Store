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
    public partial class SearchResultsPage : Form
    {
        string searchTerm;
        public SearchResultsPage(string searchTerm)
        {
            InitializeComponent();
            this.searchTerm = searchTerm;
        }

        private void SearchResultsPage_Load(object sender, EventArgs e)
        {
            LoadResults(); //gotta load them results
        }
        private void LoadResults()
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity(); //db connection
            connectivity.Initialise();
            if (Global.Sanitise(searchTerm))
            {
                var productArray = connectivity.GetProductsBySearch(searchTerm, 10); //product name array with results of SQL search
                GenResults(productArray.name, productArray.price, productArray.ID);
                lbl_Title.Text = "Search results for '" + searchTerm + "'"; //just puts the title on
            }
            
        }
        PictureBox[] picArray_SearchResultsImage;
        Label[] lblArray_SearchResultsPrice;
        Label[] lblArray_SearchResults;
        private void GenResults(string[] productArray, string[] priceArray, string[] idArray)
        {
            //arrays of all the info dispalyed on screen
            lblArray_SearchResults = new Label[productArray.Length];
            lblArray_SearchResultsPrice = new Label[productArray.Length];
            picArray_SearchResultsImage = new PictureBox[productArray.Length];

            ImageSystem imageSystem = new ImageSystem();
            for (int i = 0; i < lblArray_SearchResults.Length; i++)
            {
                if(productArray[i] != null)
                {
                    //just loads of properties. looks long but its just setting all the design stuff correctly
                    lblArray_SearchResults[i] = new Label();
                    lblArray_SearchResults[i].Text = productArray[i];
                    lblArray_SearchResults[i].ForeColor = Color.White;
                    lblArray_SearchResults[i].Font = new Font("Segoe UI", 27.75f);
                    lblArray_SearchResults[i].AutoSize = true;
                    //y-axis position changes each time, since results show under eachother, basically aritmetic sequence
                    lblArray_SearchResults[i].Location = new Point(120, 140 + (i * 120));
                    lblArray_SearchResults[i].Click += new EventHandler(OpenSearchedProduct);
                    this.Controls.Add(lblArray_SearchResults[i]);

                    lblArray_SearchResultsPrice[i] = new Label();
                    lblArray_SearchResultsPrice[i].Location = new Point(120, 180 + (i * 120));
                    lblArray_SearchResultsPrice[i].Text = "£" + (Convert.ToDouble(priceArray[i]) / 100).ToString();
                    lblArray_SearchResultsPrice[i].ForeColor = Color.White;
                    lblArray_SearchResultsPrice[i].Font = new Font("Segoe UI", 27.75f);
                    lblArray_SearchResultsPrice[i].AutoSize = true;
                    lblArray_SearchResultsPrice[i].Click += new EventHandler(OpenSearchedProduct_price);
                    this.Controls.Add(lblArray_SearchResultsPrice[i]);

                    picArray_SearchResultsImage[i] = new PictureBox();
                    picArray_SearchResultsImage[i].Location = new Point(10, 150 + (i * 120));
                    picArray_SearchResultsImage[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    picArray_SearchResultsImage[i].Size = new Size(100, 100);
                    if (imageSystem.GetImageCount(Convert.ToInt32(idArray[i])) > 0)
                    {
                        //loads image onto the page for each picture box
                        picArray_SearchResultsImage[i].Image = imageSystem.GetImageRoot_Product(idArray[i], 0);
                    }
                    else
                    {
                        //loads placeholder image
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
            Global.OpenProductPage(lblArray_SearchResults[position].Text,this);
        }
        private void OpenSearchedProduct_price(object sender, EventArgs e)
        {
            Label label = sender as Label;
            int position = Array.IndexOf(lblArray_SearchResultsPrice, label);
            Global.OpenProductPage(lblArray_SearchResults[position].Text,this);
        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            Global.OpenHome(this);
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            Global.SearchIten(this, txt_search.Text);
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Global.OpenProfile(this);
        }
    }
}
