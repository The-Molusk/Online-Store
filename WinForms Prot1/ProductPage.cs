using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.IO;

namespace WinForms_Prot1
{
    public partial class ProductPage : Form
    {
        Dictionary<string, string> Product;
        string productName;
        int currentImage;
        PictureBox[] productImageArr;
        public ProductPage(string name)
        {
            InitializeComponent();
            productName = name;
        }
        private void ProductPage_Load(object sender, EventArgs e)
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            Product = connectivity.GetAllProductInfo(productName);

            ImageSystem imageSystem = new ImageSystem();
            int imgFileCount = imageSystem.GetImageCount(Convert.ToInt32(Product["ID"]));

            productImageArr = new PictureBox[imgFileCount];

            //if the product doesnt have any images, the placeholder image will be shown
            if(imgFileCount == 0)
            {
                PictureBox pic = new PictureBox();
                pic.Location = new Point(12, 79);
                pic.Size = new Size(430, 430);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Image = imageSystem.GetPlaceholder();
                this.Controls.Add(pic);
            }
            else
            {
                //gets all images allocated to that specific image, and displays them on the page
                for (int i = 0; i < imgFileCount; i++)
                {
                    productImageArr[i] = new PictureBox();
                    productImageArr[i].Location = new Point(12, 79);
                    productImageArr[i].Size = new Size(430, 430);
                    productImageArr[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    productImageArr[i].Image = imageSystem.GetImageRoot_Product(Product["ID"], i);
                    this.Controls.Add(productImageArr[i]);
                    productImageArr[i].Hide();
                }
                productImageArr[0].Show();
            }
            currentImage = 0;
            //sets all the label text to the product info
            lbl_ID.Text = Product["ID"];
            lbl_Title.Text = Product["Name"];
            lbl_category.Text = Product["Category"];
            txt_desc.Text = Product["Description"];
            lbl_price.Text = "£" + (Convert.ToDouble(Product["Price"])/100).ToString();
            int avg = connectivity.GetAverageRating(Product["ID"]);
            if (avg == -1)
            {
                lbl_rating.Text = "No reviews";
            }
            else
            {
                lbl_rating.Text = avg.ToString() + "/10";
            }
            
        }

        //cycling through the different iamegs set for the product
        private void btn_next_Click(object sender, EventArgs e)
        {
            foreach (PictureBox picBox in productImageArr) picBox.Hide();
            if (currentImage == productImageArr.Length - 1) 
                currentImage = 0;
            else currentImage++;
            if(productImageArr.Length > 0)
            {
                productImageArr[currentImage].Show();
            }
            
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            foreach (PictureBox picBox in productImageArr) picBox.Hide();
            if (currentImage == 0)
                currentImage = productImageArr.Length-1;
            else currentImage--;
            if (productImageArr.Length > 0)
            {
                productImageArr[currentImage].Show();
            }
        }

        private void btn_basketAdd_Click(object sender, EventArgs e)
        {
            if (Global.UserID != null) //need to be logged in
            {
                DatabaseConnectivity connectivity = new DatabaseConnectivity();
                connectivity.Initialise();
                if (connectivity.AddBasket(Product["ID"])) //adding item to database system in basket
                {
                    MessageBox.Show("Item added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add product to basket");
                }
            }
            else
            {
                MessageBox.Show("You must be logged in to add prodcust to your basket");
            }
            
        }

        //this is the "Buy Now" button, will take the user straight to checkout with the set item
        private void button1_Click(object sender, EventArgs e)
        {
            if (Global.UserID != null) //need to be logged in
            {
                DatabaseConnectivity connectivity = new DatabaseConnectivity();
                connectivity.Initialise();
                Checkout checkout = new Checkout();
                checkout.setItem(productName);
                checkout.Location = this.Location;
                checkout.StartPosition = FormStartPosition.Manual;
                checkout.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You must be logged in to purchase this item");
            }
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

        private void btn_ratings_Click(object sender, EventArgs e)
        {
            //opening reviews page
            ReviewsPage reviews = new ReviewsPage(Convert.ToInt32(Product["ID"]), Product["Name"]);
            reviews.StartPosition = FormStartPosition.Manual;
            reviews.Location = this.Location;
            reviews.Show();
            this.Close();
        }
    }
}
