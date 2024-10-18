using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinForms_Prot1
{
    static internal class Global
    {
        //mr Bald said i shouldnt use global vars, but he also has no hair so i decided to ignore him
        // + Parsing liek 40 different variables into every instatiated form sounds like work

        public static int? AccessLevel = null;
        public static string? Username = null;
        public static int? UserID = null;
        public static void OpenProductPage(string itemName, Form current)
        {
            System.Drawing.Point obj = current.Location;
            ProductPage product = new ProductPage(itemName);
            product.StartPosition = FormStartPosition.Manual;
            product.Location = obj;
            product.Show();
            current.Close();
        }
        public static void OpenBasket(Form current)
        {
            System.Drawing.Point obj = current.Location;
            Basket basket = new Basket();
            basket.StartPosition = FormStartPosition.Manual;
            basket.Location = obj;
            basket.Show();
            current.Close();
        }
        public static void SearchIten (Form current, string searchTerm)
        {
            if (Sanitise(searchTerm))
            {
                SearchResultsPage searchPage = new SearchResultsPage(searchTerm);
                searchPage.StartPosition = FormStartPosition.Manual;
                searchPage.Location = current.Location;
                searchPage.Show();
                current.Close();
            }
            
        }
        public static void OpenProfile(Form current)
        {
            System.Drawing.Point obj = current.Location;
            if (UserID != null)
            {
                Profile profilePage =  new Profile();
                profilePage.StartPosition = FormStartPosition.Manual;
                profilePage.Location = obj;
                profilePage.Show();
            }
            else
            {
                Login login = new Login();
                login.StartPosition = FormStartPosition.Manual;
                login.Location = obj;
                login.Show();
            }
            current.Close();
            
        }
        public static void OpenHome(Form current)
        {
            Home homePage = new Home();
            homePage.StartPosition = FormStartPosition.Manual;
            homePage.Location = current.Location;
            homePage.Show();
            current.Close();
        }
        public static bool Sanitise(string input)
        {
            if (Regex.IsMatch(input, @"[^(\w\d !?.,+=@)]"))
            {
                MessageBox.Show("Invalid");
                return false;
            }
            return true;
        }
        public static bool Validate(string input, string inputType) //validation function for all difernt types of inputs
        {
            switch (inputType)
            {
                case "email":  //using the built in e-mail validation system instead of a 4km long string of regex
                    var emailValidator = new EmailAddressAttribute();
                    if (emailValidator.IsValid(input) && input.Length > 3) return true;
                    else
                    {
                        MessageBox.Show("Enter Valid email");
                        return false;
                    }
                case "username": //simple regex validation
                    if (input.ToCharArray().Length < 5 || input.ToCharArray().Length > 20 || Regex.IsMatch(input, @"[^a-zA-Z0-9_]"))
                    {
                        MessageBox.Show("Username must be between 5 and 20 characters and can only contain letters, numbers and _", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else return true;
                case "password": //must meet password requirements
                    if (!Regex.IsMatch(input, @"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(^[a-zA-Z_\W\d]{5,20}$)"))
                    {
                        MessageBox.Show("Password must be between 5 and 20 characters, contain at least 1 lowecase and 1 capital letter and 1 number", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else return true;
                case "phone": //for all phone number formats (1st regex check is for several formats like 12345678900, 1234 123 123 123, 1234-123-123-123 etc. 2nd statement is for the +12 123 123 123 type formats)
                    if (!(Regex.IsMatch(input, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$") || Regex.IsMatch(input, @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$") || Regex.IsMatch(input,@"^[0-9]{11}")))
                    {
                        MessageBox.Show("Please eneter a valid phone number", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else return true;
                case "cardNo":
                    if (input.ToCharArray().Length != 16 || Regex.IsMatch(input, @"[^0-9]"))
                    {
                        MessageBox.Show("Please eneter a valid card number", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else return true;
                case "cvv":
                    if (input.ToCharArray().Length != 3 || Regex.IsMatch(input, @"[^0-9]"))
                    {
                        MessageBox.Show("Please eneter a valid CVV", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else return true;
                case "dob": 
                    char[] dob = input.ToCharArray();
                    if (dob.Length != 8 || Regex.IsMatch(input, @"[^0-9]"))
                    {
                        MessageBox.Show("Please enter valid date");
                        return false;
                    }
                    int[][] months = new int[2][];
                    months[0] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                    months[1] = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                    int date_day = Convert.ToInt16(input.Substring(0,2));
                    int date_month = Convert.ToInt16(input.Substring(2, 2));
                    int date_year = Convert.ToInt16(input.Substring(4, 4));
                    if (date_month < 1 || date_month > 12)
                    {
                        MessageBox.Show("Please enter valid date");
                        return false;
                    }
                    int dayLimit = months[1][Array.IndexOf(months[0], date_month)];
                    if (date_day < 0 || date_day > dayLimit || date_month < 0 || date_month > 12 || date_year < 1900 || date_year >= Convert.ToInt64(DateTime.Today.ToString("yyyy")))
                    {
                        MessageBox.Show("Please enter valid date");
                        return false;
                    }
                    else return true;
                case "exp":
                    char[] exp = input.ToCharArray();
                    if (exp.Length != 6 || Regex.IsMatch(input, @"[^0-9]"))
                    {
                        MessageBox.Show("Please enter valid date");
                        return false;
                    }
                    int exp_month = Convert.ToInt16(input.Substring(0, 2));
                    int exp_year = Convert.ToInt16(input.Substring(2, 4));
                    if (exp_month < 0 || exp_month > 12 || exp_year < Convert.ToInt64(DateTime.Today.ToString("yyyy")))
                    {
                        MessageBox.Show("Please enter valid date");
                        return false;
                    }
                    else return true;
            }
            return false;
        }
    }
    
}
