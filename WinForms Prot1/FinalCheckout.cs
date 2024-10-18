using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Prot1
{
    public partial class FinalCheckout : Form
    {
        bool usingBasket;
        string? productName;
        int total;
        string[] UserInfo;
        int[] arrayID;
        int[] arrayPrice;
        int key;
        string[] nameArray;
        DatabaseConnectivity connectivity = new DatabaseConnectivity();
        public FinalCheckout(bool usingBasket, string? productName, int key)
        {
            InitializeComponent();
            this.usingBasket = usingBasket;
            this.productName = productName;
            this.key = key;
        }

        private void FinalCheckout_Load(object sender, EventArgs e)
        {
            connectivity.Initialise();
            UserInfo = GetPaymentInfo(key);
            if (usingBasket) { loadFull(GetBasket(), UserInfo); }
            else { loadSingle(GetProduct(), UserInfo); }
        }
        private void loadSingle(Dictionary<string, string> ProductInfo, string[] UserInfo) //if buying 1 product
        {
            int totalPrice = Convert.ToInt32(ProductInfo["Price"]);
            arrayID = new int[1];
            arrayPrice = new int[1];
            arrayID[0] = Convert.ToInt32(ProductInfo["ID"]);
            arrayPrice[0] = Convert.ToInt32(ProductInfo["Price"]);
            nameArray = new string[] { ProductInfo["Name"] };
            lbl_totalPrice.Text = "£" + ((float)totalPrice / 100).ToString();
            lbl_cardType.Text = UserInfo[2];
            lbl_cardType2.Text = "Ending in ****" + UserInfo[3].Substring(UserInfo[3].Length - 4, 4);
            CreateLabels(null, ProductInfo);
        }
        private void loadFull(string[][] ProductInfo, string[] UserInfo) //if buying several products
        {
            total = 0;
            arrayID = new int[ProductInfo[0].Length];
            arrayPrice = new int[ProductInfo[0].Length];
            nameArray = new string[ProductInfo[0].Length];
            for (int i = 0; i < ProductInfo[1].Length; i++)
            {
                total += Convert.ToInt32(ProductInfo[1][i]);
                arrayID[i] = Convert.ToInt32(ProductInfo[3][i]);
                arrayPrice[i] = Convert.ToInt32(ProductInfo[1][i]);
                nameArray[i] = ProductInfo[0][i];
            }
            lbl_totalPrice.Text = "£" + ((float)total / 100).ToString();
            lbl_cardType.Text = UserInfo[2];
            lbl_cardType2.Text = "Ending in ****" + UserInfo[3].Substring(UserInfo[3].Length - 4, 4);
            CreateLabels(ProductInfo, null);
        }
        void CreateLabels(string?[][] ProductInfoArray, Dictionary<string,string> ProductInfoDict)
        {
            if (usingBasket)
            {
                int Amount = ProductInfoArray[1].Length;
                Label[] labelArray_Name = new Label[Amount];
                Label[] labelArray_Price = new Label[Amount]; //just arrays of the labels
                for (int i = 0; i < Amount; i++)
                {
                    //this just sets all the properties of the labels and buttons to the required ones so that the UI is readable and usable

                    labelArray_Name[i] = new Label();
                    labelArray_Name[i].Location = new Point(10, 200 + (i * 50));
                    labelArray_Name[i].Text = ProductInfoArray[0][i];
                    labelArray_Name[i].ForeColor = Color.White;
                    labelArray_Name[i].Font = new Font("Segoe UI", 20f);
                    labelArray_Name[i].AutoSize = true;
                    this.Controls.Add(labelArray_Name[i]);

                    labelArray_Price[i] = new Label();
                    labelArray_Price[i].Location = new Point(500, 200 + (i * 50));
                    labelArray_Price[i].Text = "£" + (((float)Convert.ToInt64(ProductInfoArray[1][i])) / 100).ToString();
                    labelArray_Price[i].ForeColor = Color.White;
                    labelArray_Price[i].Font = new Font("Segoe UI", 20f);
                    labelArray_Price[i].AutoSize = true;
                    this.Controls.Add(labelArray_Price[i]);
                }
            }
            else
            {
                Label lbl_Name = new Label();
                Label lbl_Price = new Label();

                lbl_Name.Location = new Point(10, 200);
                lbl_Name.Text = ProductInfoDict["Name"];
                lbl_Name.ForeColor = Color.White;
                lbl_Name.Font = new Font("Segoe UI", 20f);
                lbl_Name.AutoSize = true;
                this.Controls.Add(lbl_Name);

                lbl_Price.Location = new Point(500, 200);
                lbl_Price.Text = "£" + ((float)Convert.ToInt64(ProductInfoDict["Price"]) / 100).ToString();
                lbl_Price.ForeColor = Color.White;
                lbl_Price.Font = new Font("Segoe UI", 20f);
                lbl_Price.AutoSize = true;
                this.Controls.Add(lbl_Price);
            }
            
        }
        private string[][] GetBasket()
        {
            string[][] ProductInfo = connectivity.GetBasket(Global.UserID);
            return ProductInfo;
        }
        private Dictionary<string,string> GetProduct()
        {
            Dictionary<string, string> ProductInfo = connectivity.GetAllProductInfo(productName);
            return ProductInfo;
        }
        private string[] GetPaymentInfo(int key)
        {
            string[][] info = connectivity.GetSavedPaymentInfo(Global.UserID.ToString(), key);
            return info[0];
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("ddMMyyyy", CultureInfo.InvariantCulture);
            int[] primaryKeyArray = connectivity.AddTransaction(UserInfo[0], arrayID, Global.UserID.ToString(), date, arrayPrice);

            ProductKeyGen KeyGen = new ProductKeyGen();
            for (int i = 0; i < primaryKeyArray.Length; i++)
            {
                string key = KeyGen.GenerateNew();
                KeyGen.Add(key, primaryKeyArray[i].ToString());
            }
            connectivity.ClearBasket(Global.UserID.ToString());

            MailSystem mail = new MailSystem();
            mail.SendConfirmation(connectivity.GetUserInfo(Global.Username, "Email"), nameArray, arrayPrice);
            
            Global.OpenHome(this);
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
