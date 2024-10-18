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
    public partial class Basket : Form
    {
        string[][] ProductInfo;
        Button[] buttonArray_Delete;

        public Basket()
        {
            InitializeComponent();
        }

        private void Basket_Load(object sender, EventArgs e)
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            ProductInfo = connectivity.GetBasket(Global.UserID);
            CreateLabels(ProductInfo[0].Length);
        }
        void CreateLabels(int Amount)
        {
            Label[] labelArray_Name = new Label[Amount];
            Label[] labelArray_Price = new Label[Amount]; //just arrays of the labels
            buttonArray_Delete = new Button[Amount];
            for (int i = 0; i < Amount; i++)
            {
                //this just sets all the properties of the labels and buttons to the required ones so that the UI is readable and usable

                labelArray_Name[i] = new Label();
                labelArray_Name[i].Location = new Point(10, 100 + (i * 50));
                labelArray_Name[i].Text = ProductInfo[0][i];
                labelArray_Name[i].ForeColor = Color.White;
                labelArray_Name[i].Font = new Font("Segoe UI", 27.75f);
                labelArray_Name[i].AutoSize = true;
                labelArray_Name[i].Click += new EventHandler(OpenSearchedProduct);
                this.Controls.Add(labelArray_Name[i]);

                labelArray_Price[i] = new Label();
                labelArray_Price[i].Location = new Point(500, 100 + (i * 50));
                labelArray_Price[i].Text = "£"+(((float)Convert.ToInt64(ProductInfo[1][i]))/100).ToString();
                labelArray_Price[i].ForeColor = Color.White;
                labelArray_Price[i].Font = new Font("Segoe UI", 27.75f);
                labelArray_Price[i].AutoSize = true;
                this.Controls.Add(labelArray_Price[i]);

                buttonArray_Delete[i] = new Button();
                buttonArray_Delete[i].Location = new Point(650, 110 + (i * 50));
                buttonArray_Delete[i].Text = "Delete";
                buttonArray_Delete[i].Size = new Size(150, 30);
                buttonArray_Delete[i].BackColor = Color.Red;
                buttonArray_Delete[i].ForeColor = Color.White;
                buttonArray_Delete[i].Click += new EventHandler(DeleteItem);
                this.Controls.Add(buttonArray_Delete[i]);

            }
            int sum = 0;
            for (int i = 0; i < ProductInfo[1].Length; i++)
            {
                //counts up total price
                sum += Convert.ToInt32(ProductInfo[1][i]);
            }
            lbl_totalPrice.Text = "£" + ((float)sum / 100).ToString();

        }
        private void OpenSearchedProduct(object sender, EventArgs e)
        {
            Label label = sender as Label;
            Global.OpenProductPage(label.Text, this);
        }
        private void DeleteItem(object sender, EventArgs e)
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            //deletes the item corresponfing to the button that was pressed
            //e.g if the button of index 3 was deleted, the product with that index gets deleted
            connectivity.DeleteBasketItem(ProductInfo[2][Array.IndexOf(buttonArray_Delete, sender as Button)]);
            Global.OpenBasket(this);
        }

        private void btn_clearBasket_Click(object sender, EventArgs e) //clearing the whole basket
        {
            var result = MessageBox.Show("Are you sure you want to clear all items from your basket?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                DatabaseConnectivity connectivity = new DatabaseConnectivity();
                connectivity.Initialise();
                connectivity.ClearBasket(Global.UserID.ToString());
                Global.OpenBasket(this);
            }
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Location = this.Location;
            checkout.StartPosition = FormStartPosition.Manual;
            checkout.Show();
            this.Close();
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
