using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Prot1
{
    public partial class Checkout : Form
    {
        string?[] UserInfo = new string[13]; //all infomration entered by the user about their payment
        string[][] SavedInfo;

        bool usingBasket = true; //loads differnt items in you are onyl buying one specific item
        string? ProdName;
        private Label[] labelArray_cardInfo;
        private Button[] buttonArray_SelectCard;

        public Checkout()
        {
            InitializeComponent();
        }

        public void setItem(string productName) //subroutine to set the item being purchased
        {
            usingBasket = false;
            ProdName = productName;
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            SavedInfo = GetUserInfo();
            CreateLabels(SavedInfo); //adds all labels and buttons for the cards that have been read
        }
        
        private void CreateLabels(string[][] Info)
        {
            labelArray_cardInfo = new Label[Info.Length];
            buttonArray_SelectCard = new Button[Info.Length];
            
            for (int i = 0; i < Info.Length; i++)
            {
                if (Info[i] != null)
                {
                    labelArray_cardInfo[i] = new Label();
                    labelArray_cardInfo[i].Location = new Point(750, i * 100 + 150);
                    labelArray_cardInfo[i].Text = Info[i][2] + " ending in: ****" + Info[i][3].Substring(Info[i][3].Length - 4, 4);
                    labelArray_cardInfo[i].ForeColor = Color.White;
                    labelArray_cardInfo[i].Font = new Font("Segoe UI", 20f);
                    labelArray_cardInfo[i].AutoSize = true;
                    this.Controls.Add(labelArray_cardInfo[i]);

                    buttonArray_SelectCard[i] = new Button();
                    buttonArray_SelectCard[i].Location = new Point(750, i * 100 + 190);
                    buttonArray_SelectCard[i].Text = "Select Card";
                    buttonArray_SelectCard[i].ForeColor = Color.White;
                    buttonArray_SelectCard[i].Font = new Font("Segoe UI", 10f);
                    buttonArray_SelectCard[i].AutoSize = true;
                    buttonArray_SelectCard[i].Size = new Size(150, 10);
                    buttonArray_SelectCard[i].BackColor = Color.FromArgb(64, 64, 64);
                    buttonArray_SelectCard[i].Click += new EventHandler(SetCard);
                    this.Controls.Add(buttonArray_SelectCard[i]);
                }
            }
            
        }
        private void SetCard(object sender, EventArgs e)
        {
            int InfoID = Convert.ToInt32(SavedInfo[Array.IndexOf(buttonArray_SelectCard, sender as Button)][0]);
            LoadNextCheckout(InfoID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sets all the values dfrom the textboxes into the info array
            #region setting userinfo array
            UserInfo[0] = cmb_cardType.Text;
            UserInfo[1] = txt_cardNo.Text;
            UserInfo[2] = txt_cvv.Text;
            UserInfo[3] = txt_date_day.Text;
            UserInfo[4] = txt_date_month.Text;
            UserInfo[5] = txt_date_year.Text;
            UserInfo[6] = txt_carName.Text;
            UserInfo[7] = txt_ad1.Text;
            UserInfo[8] = txt_ad2.Text;
            UserInfo[9] = txt_ad3.Text;
            UserInfo[10] = txt_city.Text;
            UserInfo[11] = txt_zip.Text;
            UserInfo[12] = txt_country.Text;
            
            #endregion  
            bool canProceed = true;
            for (int i = 0; i<UserInfo.Length; i++)
            {
                if ((i != 8 && i != 9 && i != 3) && UserInfo[i] == "")
                {
                    MessageBox.Show("Please fill out all the required fields");
                    canProceed = false;
                    break;
                }
            }
            if (canProceed && ValidateAllInputs(UserInfo))
            {
                int key = SaveUserInfo(UserInfo);
                LoadNextCheckout(key);
            }
        }
        private int SaveUserInfo(string[] UserInfo)
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            return connectivity.AddPaymentInfo(UserInfo);
        }
        private string?[][] GetUserInfo()
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            return connectivity.GetSavedPaymentInfo(Global.UserID.ToString(), null);
        }
        private void LoadNextCheckout(int key)
        {
            FinalCheckout final = new FinalCheckout(usingBasket, ProdName, key);
            final.Location = this.Location;
            final.StartPosition = FormStartPosition.Manual;
            final.Show();
            this.Close();
        }
        private bool ValidateAllInputs(string[] info) //validation for all the inputs
        {
            if (Global.Sanitise(info[0]) && Global.Validate(info[1], "cardNo") && Global.Validate(info[2], "cvv") && Global.Validate(info[3] + info[4] + info[5], "exp") && Global.Sanitise(info[6]) && Global.Sanitise(info[7] + info[8] + info[9] + info[10] + info[11] + info[12]))
            {
                return true;
            }
            else return false;
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
