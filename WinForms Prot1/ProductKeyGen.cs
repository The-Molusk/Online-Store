using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Prot1
{
    internal class ProductKeyGen
    {
        public string GenerateNew()
        {
            //generated a new key of hex numbers
            string key = "";
            Random random = new Random();
            for (int i = 0; i < 16; i++)
            {
                key += ToHex(random.Next(0, 15));
            }
            return key;
        }
        private string ToHex(int num)
        {
            if (num < 10) return num.ToString();
            else
            {
                switch (num){
                    case 10:
                        return "A";
                    case 11:
                        return "B";
                    case 12:
                        return "C";
                    case 13:
                        return "D";
                    case 14:
                        return "E";
                    case 15:
                        return "F";
                }
                return "X";
            }
        }
        public void Add(string key, string tranID)
        {
            //saves the new key to the database
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            connectivity.AddNewKey(key, tranID);
        }
    }
}
