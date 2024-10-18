using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Prot1
{
    public partial class PastPurchases : Form
    {
        Label[][] arr_fullInfo;
        Button[] buttonArr_showKey;
        string[][] infoArr;
        public PastPurchases()
        {
            InitializeComponent();
        }

        private void PastPurchases_Load(object sender, EventArgs e)
        {
            CreateLabels(GetPurchaseInfo());
        }
        private string[][] GetPurchaseInfo()
        {
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            return connectivity.GetKeyInfo(Global.UserID.ToString());
        }
        private void CreateLabels(string[][] info)
        {
            //array order:
            //name total date key active
            infoArr = info;
            arr_fullInfo = new Label[info.Length][];
            buttonArr_showKey = new Button[info.Length];
            for (int i = 0; i < info.Length; i++)
            {
                arr_fullInfo[i] = new Label[info[i].Length];
                for (int j = 0; j < info[i].Length; j++)
                {
                    arr_fullInfo[i][j] = new Label();
                    string text = "";
                    int xCoord = 0;
                    switch (j) //setting all text and locations corresponding to each value for the labels
                    {
                        case 0:
                            xCoord = 50;
                            text = info[i][j].ToString();
                            break;
                        case 1:
                            xCoord = 320;
                            text = "£" + (Convert.ToDecimal(info[i][j]) / 100).ToString();
                            break;
                        case 2:
                            xCoord = 430;
                            text = info[i][j].Substring(0,2) + "/" + info[i][j].Substring(2,2) + "/" + info[i][j].Substring(4,4);
                            break;
                        case 3:
                            xCoord = 650;
                            text = "XXXXXXXXXXXXXXXX";
                            break;
                        case 4:
                            xCoord = 1000;
                            break;
                    }
                    arr_fullInfo[i][j].Location = new Point(xCoord, i * 50 + 100); //settings for labels
                    arr_fullInfo[i][j].ForeColor = Color.White;
                    arr_fullInfo[i][j].Font = new Font("Segoe UI", 27.75f);
                    arr_fullInfo[i][j].AutoSize = true;
                    arr_fullInfo[i][j].Text = text;
                    this.Controls.Add(arr_fullInfo[i][j]);
                }
                buttonArr_showKey[i] = new Button();
                buttonArr_showKey[i].Text = "Show Key";
                buttonArr_showKey[i].Location = new Point(1100, i * 50 + 100);
                buttonArr_showKey[i].ForeColor = Color.White;
                buttonArr_showKey[i].BackColor = Color.Navy;
                buttonArr_showKey[i].AutoSize = true;
                buttonArr_showKey[i].Font = new Font("Segoe UI", 20f);
                buttonArr_showKey[i].Click += new EventHandler(ShowKey);
                this.Controls.Add(buttonArr_showKey[i]);
            }
        }
        private void ShowKey(object sender, EventArgs e)
        {
            int position = Array.IndexOf(buttonArr_showKey, sender as Button);
            arr_fullInfo[position][3].Text = infoArr[position][3];
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