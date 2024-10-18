using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Prot1
{
    public partial class AdminPanel : Form
    {
        DatabaseConnectivity connectivity = new DatabaseConnectivity();
        int currentProductID;
        string currentProductName;
        public AdminPanel()
        {
            InitializeComponent();
            connectivity.Initialise();
        }

        private void btn_removeUser_Click(object sender, EventArgs e) //remove a user account
        {
            connectivity.DeleteAccount(txt_Username.Text);
            MessageBox.Show("User's account deleted successfully");
        }

        private void button1_Click(object sender, EventArgs e) //give a user access to the community
        {
            connectivity.SetCommunityAccess(txt_Username.Text, "1");
            MessageBox.Show("User Pardonned");
        }

        private void btn_removeAcess_Click(object sender, EventArgs e) //revoke acces to community from a user
        {
            connectivity.SetCommunityAccess(txt_Username.Text, "0");
            MessageBox.Show("User Banned");
        }

        private void btn_accessLevel_Click(object sender, EventArgs e) //change system access level for a specific user
        {
            if (txt_accessLevel.Text == "0" || txt_accessLevel.Text == "1" || txt_accessLevel.Text == "2")
            {
                connectivity.SetSystemAccess(txt_Username.Text, txt_accessLevel.Text);
                MessageBox.Show("USer's access level changed successfully");
            }
            else
            {
                MessageBox.Show("Please enter a valid access level \n User: 0 \n Moderator: 1 \n Adminsitrator: 2");
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Global.OpenHome(this);
        }

        private void btn_search_Click(object sender, EventArgs e) //finds the product using the name entered
        {
            Dictionary<string,string> product = connectivity.GetAllProductInfo(txt_productName.Text);
            if (product != null)
            {
                currentProductID = Convert.ToInt32(product["ID"]);
                currentProductName = product["Name"];

                txt_price.Text = product["Price"];
                txt_description.Text = product["Description"];
                lbl_ID.Text = "Editing ProdID: " + product["ID"];
                cbox_category.Text = product["Category"];
            }

            ImageSystem imageSystem = new ImageSystem();
            lbl_picNum.Text = imageSystem.GetImageCount(currentProductID).ToString();
        }

        private void btn_addNew_Click(object sender, EventArgs e) //adds new product
        {
            if (Global.Sanitise(txt_productName.Text) && Global.Sanitise(txt_price.Text) && Global.Sanitise(cbox_category.Text) && Global.Sanitise(txt_description.Text))
            {
                connectivity.AddNewProduct(txt_productName.Text, txt_price.Text, cbox_category.Text, txt_description.Text);
                MessageBox.Show("Item added successfully");
            }
        }
        private void btn_update_Click(object sender, EventArgs e) //updates existing product
        {
            if (currentProductID != 0)
            {
                bool checkRequired = true;
                if (txt_productName.Text == currentProductName)
                {
                    checkRequired = false;
                }
                if (Global.Sanitise(txt_productName.Text) && Global.Sanitise(txt_price.Text) && Global.Sanitise(cbox_category.Text) && Global.Sanitise(txt_description.Text))
                {
                    connectivity.UpdateProductInfo(currentProductID.ToString(), txt_productName.Text, txt_price.Text, cbox_category.Text, txt_description.Text, checkRequired);
                    MessageBox.Show("Updated Successfully");
                }
            }
            else
            {
                MessageBox.Show("Please select a product");
            }
        }

        private void btn_addImage_Click(object sender, EventArgs e) //adds a new image for a product
        {
            if (currentProductID != 0)
            {
                ImageSystem imageSystem = new ImageSystem();
                imageSystem.AddImage_Product(currentProductID);
                MessageBox.Show("Image added");
            }
            else
            {
                MessageBox.Show("Please select a product");
            }
        }

        private void btn_clearImages_Click(object sender, EventArgs e) //removes images from a product
        {
            if (Convert.ToInt32(lbl_picNum.Text) != 0)
            {
                ImageSystem image = new ImageSystem();
                image.ClearImages(currentProductID);
            }
            MessageBox.Show("Product images cleared");
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e) //removes a product from the system
        {
            connectivity.DeleteProduct(currentProductID.ToString());
            MessageBox.Show("Item removed");
        }
    }
}
