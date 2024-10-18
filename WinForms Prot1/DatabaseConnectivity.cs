using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Loader;
using System.Diagnostics;
using System.Transactions;

namespace WinForms_Prot1
{
    class DatabaseConnectivity
    {
        OleDbConnection connection;
        public void Initialise()
        {
            string source = @"C:\Users\milos\Documents\GitHub\NEA\Prot1.accdb";   //file source for database
            connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + source); //initalises connection
        }
        #region Users
        public bool AddUser(string Username, string Password, string Email, string Phone, string Salt) //function to add a user to the database
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "INSERT INTO Users ([Username], [Password], [Email], [Phone], [AccessLevel], [Salt], [CommunityAccess])" +
                    " Values('" + Username + "', '" + Password + "', '" + Email + "', '" + Phone + "', '0', '" + Salt + "', '1')";
                command.Connection = connection;
                command.ExecuteNonQuery(); //executes the SQL command.
                connection.Close();
                return true;  //Successful transaction
            }
            catch (Exception exeption) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to add account \nERROR: " + exeption.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //unsecessful transaction
            }
            finally
            {
                connection.Close();
            }
        }
        public string GetUserInfo(string Username, string Required)
        {
            try
            {
                string output;
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "SELECT " + Required + " FROM Users WHERE Username='" + Username + "'";
                OleDbDataReader reader = command.ExecuteReader(); //creates a reader to access data from the table
                while (reader.Read()) //while the reader is active, get the data required from the table
                {
                    output = reader[Required].ToString();
                    return output;
                }
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured when trying to read data \nERROR: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; //unsecessful transaction
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteAccount(string Username) //Deletes accounts (kinda obvious)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "DELETE FROM Users WHERE Username = '" + Username + "'";
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exeption) //errors and stuff
            {
                MessageBox.Show("Error occured when trying to delete account \nERROR: " + exeption.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
        }
        public void SetCommunityAccess(string username, string hasAccess)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText =
                    "UPDATE Users " +
                    "SET CommunityAccess = '" + hasAccess + "' " +
                    "WHERE Username = '" + username + "'";
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exeption) //errors and stuff
            {
                MessageBox.Show("Error occured when trying to set access \nERROR: " + exeption.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
        }
        public void SetSystemAccess(string username, string accessLevel)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText =
                    "UPDATE Users " +
                    "SET AccessLevel = '" + accessLevel + "' " +
                    "WHERE Username = '" + username + "'";
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exeption) //errors and stuff
            {
                MessageBox.Show("Error occured when trying to set access \nERROR: " + exeption.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
        }
        public void UpdateUserInfo(string username, string name, string dob, string phone)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText =
                    "UPDATE Users " +
                    "SET FullName = '" + name + "', DOB = '"+ dob + "', Phone = '" + phone + "' " +
                    "WHERE Username = '" + username + "'";
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exeption) //errors and stuff
            {
                MessageBox.Show("Error occured when trying to update info \nERROR: " + exeption.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
        }
        #endregion)
        #region Products
        public (string?[] name, string?[] price, string?[] ID) GetProductsOfCategory(string category, int requiredAmount)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "SELECT ProductName, Price, ProductID FROM Products WHERE ProductCategory='" + category + "'";
                OleDbDataReader reader = command.ExecuteReader(); //creates a reader to access data from the table
                string[] ProductArray = new string[requiredAmount];
                string[] ProductPriceArray = new string[requiredAmount];
                string[] ProductIDArray = new string[requiredAmount];
                for (int i = 0; reader.Read() && i < requiredAmount; i++)
                {
                    ProductArray[i] = reader["ProductName"].ToString();
                    ProductPriceArray[i] = reader["Price"].ToString();
                    ProductIDArray[i] = reader["ProductID"].ToString();
                }
                return (ProductArray, ProductPriceArray, ProductIDArray);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null, null);
            }
            finally
            {
                connection.Close();
            }
        }
        public (string?[] name, string?[] price, string?[] ID) GetProductsBySearch(string searchTerm, int requiredAmount) // reqAmt = 0 means all items
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "SELECT ProductName, Price, ProductID FROM Products WHERE ProductName LIKE '%" + searchTerm + "%'"; //search for products command
                OleDbDataReader reader = command.ExecuteReader(); //creates a reader to access data from the table
                if (requiredAmount == 0)
                {
                    List<string> ProductNameList = new List<string>();
                    List<string> ProductPriceList = new List<string>();
                    List<string> ProductIDList = new List<string>();
                    while (reader.Read()) //while the reader is active, get the data required from the table
                    {
                        ProductNameList.Add(reader["ProductName"].ToString()); //adds any items with the search term to the temp array
                        ProductPriceList.Add(reader["Price"].ToString());
                        ProductIDList.Add(reader["ProductID"].ToString());
                    }
                    string[] ProductNameArray = ProductNameList.ToArray();
                    string[] ProductPriceArray = ProductPriceList.ToArray();
                    string[] ProductIDArray = ProductIDList.ToArray();
                    return (ProductNameArray, ProductPriceArray, ProductIDArray);
                }
                else
                {
                    string[] ProductArray = new string[requiredAmount];
                    string[] ProductPriceArray = new string[requiredAmount];
                    string[] ProductIDArray = new string[requiredAmount];
                    for (int i = 0; reader.Read() && i < requiredAmount; i++) //while the reader is active and more items are still required
                    {
                        ProductArray[i] = reader["ProductName"].ToString(); //gets the product names
                        ProductPriceArray[i] = reader["Price"].ToString();
                        ProductIDArray[i] = reader["ProductID"].ToString();
                    }
                    return (ProductArray, ProductPriceArray, ProductIDArray);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null, null);
            }
            finally
            {
                connection.Close();
            }

        }
        public Dictionary<string, string> GetAllProductInfo(string InputName)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "SELECT * FROM Products WHERE ProductName='" + InputName + "'";
                OleDbDataReader reader = command.ExecuteReader(); //creates a reader to access data from the table
                while (reader.Read())
                {
                    string[] temp = new string[5];
                    temp[0] = reader["ProductID"].ToString();
                    temp[1] = InputName;
                    temp[2] = reader["ProductCategory"].ToString();
                    temp[3] = reader["Price"].ToString();
                    temp[4] = reader["ProductDescription"].ToString();

                    //dictionary makes it easier to understand the values inside a variable structure. You dont need to use numbers,
                    //but you can use names to reqpresent data
                    Dictionary<string, string> InfoDictionary = new Dictionary<string, string>
                    {
                        {"ID", temp[0] },
                        {"Name", temp[1] },
                        {"Category", temp[2] },
                        {"Price", temp[3] },
                        {"Description", temp[4] }
                    };
                    return InfoDictionary;
                }
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public void AddNewProduct(string name, string price, string category, string description)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "SELECT Count (*) FROM Products WHERE ProductName = '" + name + "'";
                if ((int)command.ExecuteScalar() == 0)
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO Products ([ProductName], [ProductCategory], [Price], [ProductDescription])" +
                    " Values('" + name + "', '" + category + "', '" + price + "', '" + description + "')";
                    command.Connection = connection;
                    command.ExecuteNonQuery(); //executes the SQL command.
                    connection.Close();
                }
                else MessageBox.Show("Product with this name already exists");
            }
            catch (Exception exeption) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to add product \nERROR: " + exeption.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        public void UpdateProductInfo(string ID, string name, string price, string category, string description, bool checkRequired)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                bool canProceed = true;
                //The SQL statement:
                if (checkRequired)
                {
                    command.CommandText = "SELECT Count (*) FROM Products WHERE ProductName = '" + name + "'";
                    if ((int)command.ExecuteScalar() != 0)
                    {
                        MessageBox.Show("Product with this name already exists");
                        canProceed = false;
                    }
                    command.Parameters.Clear();
                }
                if (canProceed)
                {
                    command.CommandText =
                    "UPDATE Products " +
                    "SET ProductName = '" + name + "', ProductCategory = '" + category + "', Price = '" + price + "', ProductDescription = '" + description + "' " +
                    "WHERE ProductID = " + ID;
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception exeption) //errors and stuff
            {
                MessageBox.Show("Error occured when trying to set access \nERROR: " + exeption.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
        }
        public void DeleteProduct(string productID)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "DELETE FROM Products WHERE ProductID = " + productID;
                command.Connection = connection;
                command.ExecuteNonQuery(); //executes the SQL command.
                connection.Close();
            }
            catch (Exception exeption) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to remove product \nERROR: " + exeption.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
        #region Basket
        public bool AddBasket(string ProductID)
        {
            try
            {
                string UserID = Global.UserID.ToString();

                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "INSERT INTO Basket ([UserID], [ProductID]) Values(" + UserID + "," + ProductID + ")";
                command.Connection = connection;
                command.ExecuteNonQuery(); //executes the SQL command.
                connection.Close();
                return true;  //Successful transaction
            }
            catch (Exception exeption) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to add product to basket \nERROR: " + exeption.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //unsecessful transaction
            }
            finally
            {
                connection.Close();
            }
        }
        public string[][] GetBasket(int? ID)
        {
            string UserID = ID.ToString();
            try
            {
                string[] ProductNameArray;
                string[] ProductPriceArray;
                string[] BasketIDArray;
                string[] ProductIDArray;
                string[][] FinalAray = new string[4][];

                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText =
                    "SELECT Products.ProductName, Products.Price, Basket.BasketID, Products.ProductID " +
                    "FROM Products " +
                    "INNER JOIN Basket ON Products.ProductID=Basket.ProductID " +
                    "WHERE Basket.UserID = " + UserID;
                OleDbDataReader reader = command.ExecuteReader(); //creates a reader to access data from the table

                List<string> ProductNameList = new List<string>();  //using lists since total peices of data is unknown yet
                List<string> ProductPriceList = new List<string>();
                List<string> BasketIDList = new List<string>();
                List<string> ProductIDList = new List<string>();

                for (int i = 0; reader.Read(); i++)
                {
                    ProductNameList.Add(reader["ProductName"].ToString()); //adding the name and price to the lists
                    ProductPriceList.Add(reader["Price"].ToString());
                    BasketIDList.Add(reader["BasketID"].ToString());
                    ProductIDList.Add(reader["ProductID"].ToString());
                }
                ProductNameArray = ProductNameList.ToArray();
                ProductPriceArray = ProductPriceList.ToArray();
                BasketIDArray = BasketIDList.ToArray();
                ProductIDArray = ProductIDList.ToArray();
                FinalAray[0] = ProductNameArray;
                FinalAray[1] = ProductPriceArray;
                FinalAray[2] = BasketIDArray;
                FinalAray[3] = ProductIDArray;
                return FinalAray;
            }
            catch (Exception exeption) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to read basket \nERROR: " + exeption.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; //unsecessful transaction
            }
            finally
            {
                connection.Close();
            }
        }
        public void DeleteBasketItem(string BasketID)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "DELETE FROM Basket WHERE BasketID = " + BasketID;
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show("Error occured when trying to delete item \nERROR: " + exeption.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
        }
        public void ClearBasket(string UserID)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "DELETE FROM Basket WHERE UserID = " + UserID;
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show("Error occured when trying to delete items \nERROR: " + exeption.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
        }
        #endregion
        #region Payments
        public int AddPaymentInfo(string[] PayInfo)
        {
            try
            {
                string exp = PayInfo[3] + PayInfo[4] + PayInfo[5];
                string adress = "";
                for (int i = 7; i < 13; i++)
                {
                    adress = adress + "," + PayInfo[i];
                }

                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "INSERT INTO PayInfo ([UserID], [FullName], [CardType], [CardNo], [CVV], [ExpDate], [Address])" +
                    "VALUES ('" + Global.UserID.ToString() + "','" + PayInfo[6] + "','" + PayInfo[0] + "','" + PayInfo[1] + "','" + PayInfo[2] + "','" + exp + "','" + adress + "')";

                command.Connection = connection;
                command.ExecuteNonQuery(); //executes the SQL command.

                command.Parameters.Clear();
                command.CommandText = "SELECT @@IDENTITY";
                int primaryKey = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return primaryKey;  //Successful transaction
            }
            catch (Exception e) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to save info \nERROR: " + e.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; //unsecessful transaction
            }
            finally
            {
                connection.Close();
            }
        }
        public string[][] GetSavedPaymentInfo(string UserID, int? key)
        {
            try
            {
                string[] datanames = { "InfoID", "FullName", "CardType", "CardNo", "CVV", "ExpDate", "Address" };
                if (key == null)
                {
                    OleDbCommand amountcommand = connection.CreateCommand();
                    connection.Open();
                    amountcommand.CommandText = "SELECT COUNT (*) FROM PayInfo";
                    int amount = (int)amountcommand.ExecuteScalar();
                    string[][] output = new string[amount][];
                    OleDbCommand command = connection.CreateCommand();
                    //The SQL statement:
                    command.CommandText = "SELECT InfoID, FullName, CardType, CardNo, CVV, ExpDate, Address FROM PayInfo WHERE UserID = '" + UserID + "'";
                    OleDbDataReader reader = command.ExecuteReader(); //creates a reader to access data from the table

                    for (int i = 0; reader.Read(); i++) //while the reader is active, get the data required from the table
                    {
                        string[] temp = new string[datanames.Length];
                        for (int j = 0; j < datanames.Length; j++)
                        {
                            temp[j] = reader[datanames[j]].ToString();
                        }
                        output[i] = temp;
                    }
                    return output;
                }
                else
                {
                    OleDbCommand command = connection.CreateCommand();
                    connection.Open();
                    command.CommandText = "SELECT InfoID, FullName, CardType, CardNo, CVV, ExpDate, Address FROM PayInfo WHERE InfoID = " + key;
                    OleDbDataReader reader = command.ExecuteReader();
                    string[] temp = new string[datanames.Length];
                    while (reader.Read())
                    {
                        for (int i = 0; i < datanames.Length; i++)
                        {
                            temp[i] = reader[datanames[i]].ToString();
                        }
                    }

                    string[][] output = new string[1][];
                    output[0] = temp;
                    return output;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured when trying to read data \nERROR: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; //unsecessful transaction
            }
            finally
            {
                connection.Close();
            }
        }
        public int[] AddTransaction(string infoID, int[] prodID, string userID, string date, int[] price)
        {
            try
            {
                int[] arrayID = new int[prodID.Length];
                connection.Open();
                for (int i = 0; i < prodID.Length; i++)
                {
                    OleDbCommand command = connection.CreateCommand();
                    //The SQL statement:
                    command.CommandText = "INSERT INTO Transactions ([ProductID], [UserID], [TransactionDate], [Total], [InfoID])" +
                        " Values('" + prodID[i].ToString() + "', '" + userID + "', '" + date + "', '" + price[i] + "', '" + infoID + "')";
                    command.Connection = connection;
                    command.ExecuteNonQuery(); //executes the SQL command.

                    //checking at which primary key the transaction was saved at, so that the ID can be used later.
                    command.Parameters.Clear();
                    command.CommandText = "SELECT @@IDENTITY";
                    arrayID[i] = Convert.ToInt32(command.ExecuteScalar());

                }
                return arrayID;

            }
            catch (Exception exeption) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to add key \nERROR: " + exeption.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int[] failedReturn = { -1 };
                return failedReturn;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
        #region Hashing
        public string GetPasswordSalt(string username)
        {
            try
            {
                string output;
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "SELECT Salt FROM Users WHERE Username='" + username + "'";
                OleDbDataReader reader = command.ExecuteReader(); //creates a reader to access data from the table
                while (reader.Read()) //while the reader is active, get the data required from the table
                {
                    output = reader["Salt"].ToString();
                    Debug.WriteLine(output);
                    return output;
                }
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured when trying to read data \nERROR: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; //unsecessful transaction
            }
            finally
            {
                connection.Close();
            }
        }
        public bool SaltExists(string salt)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "SELECT Count(*) FROM Users WHERE Salt='@salt'";
                command.Parameters.AddWithValue("@salt", salt);
                int amount = (int)command.ExecuteScalar();
                if (amount > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured when trying to read data \nERROR: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
        #region Keys
        public bool AddNewKey(string key, string transactionID)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "INSERT INTO Keys ([TransactionID], [Key], [Active])" +
                    " Values('" + transactionID + "', '" + key + "', '1')";
                command.Connection = connection;
                command.ExecuteNonQuery(); //executes the SQL command.
                connection.Close();
                return true;  //Successful transaction
            }
            catch (Exception exeption) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to add key \nERROR: " + exeption.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //unsecessful transaction
            }
            finally
            {
                connection.Close();
            }
        }
        public string[][] GetKeyInfo(string UserID)
        {
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText =
                    "SELECT COUNT(*) FROM Keys " +
                    "INNER JOIN Transactions ON Keys.TransactionID = Transactions.TransactionID " +
                    "WHERE Transactions.UserID = " + UserID;
                int amount = (int)command.ExecuteScalar();
                string[][] keys = new string[amount][];

                command.Parameters.Clear();
                command = connection.CreateCommand();
                command.CommandText =
                    "SELECT Products.ProductName, Keys.Key, Keys.Active, Transactions.Total, Transactions.TransactionDate " +
                    "FROM ((Keys " +
                    "INNER JOIN Transactions ON Keys.TransactionID = Transactions.TransactionID) " +
                    "INNER JOIN Products ON Transactions.ProductID = Products.ProductID) " +
                    "WHERE Transactions.UserID = " + UserID;
                OleDbDataReader reader = command.ExecuteReader(); //creates a reader to access data from the table
                for (int i = 0; i < amount && reader.Read(); i++)
                {
                    string[] temp = new string[5];
                    temp[0] = reader["ProductName"].ToString();
                    temp[1] = reader["Total"].ToString();
                    temp[2] = reader["TransactionDate"].ToString();
                    temp[3] = reader["Key"].ToString();
                    temp[4] = reader["Active"].ToString();
                    keys[i] = temp;
                }
                return keys;
                #region Shit Code
                //command.CommandText =
                //    "SELECT Products.ProductName, Transactions.Total, Transactions.Date " +
                //    "FROM Products " +
                //    "INNER JOIN Products ON Transactions.ProductID = Products.ProductID " +
                //    "WHERE Transactions.UserID = " + UserID;
                //OleDbDataReader reader = command.ExecuteReader(); //creates a reader to access data from the table

                //for (int i = 0; i < amount; i++)
                //{
                //    keys[i][0] = reader["ProductName"].ToString();
                //    keys[i][1] = reader["Total"].ToString();
                //    keys[i][2] = reader["Date"].ToString();
                //}
                //reader.Close();

                //command.CommandText =
                //    "SELECT Keys.Key, Keys.Active " +
                //    "FROM Keys " +
                //    "INNER JOIN Transactions " +
                //    "ON Keys.TransactionID = Transactions.TransactionID";
                //reader = command.ExecuteReader();

                //for (int i = 0; i < amount; i++)
                //{
                //    keys[i][3] = reader["Key"].ToString();
                //    keys[i][4] = reader["Active"].ToString();
                //}
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured when trying to read data \nERROR: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; //unsecessful transaction
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
        #region Reviews
        public void AddReview(int? userID, int productID, int rating, string reviewText)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "SELECT Count(*) FROM Reviews WHERE UserID = " + userID + " AND ProductID = " + productID;
                int amount = (int)command.ExecuteScalar();
                if (amount > 0)
                {
                    DialogResult d = MessageBox.Show("You already have a review on this product, would you like to overwrite it?", "Review already exists", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        command.Parameters.Clear();
                        command.CommandText = "UPDATE Reviews " +
                            "SET Rating = " + rating.ToString() + ", Review = '" + reviewText + "' " +
                            "WHERE UserID = " + userID + " AND ProductID = " + productID;
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO Reviews " +
                        "(UserID, ProductID, Rating, Review) " +
                        "VALUES (" + userID.ToString() + ", " + productID.ToString() + ", " + rating.ToString() + ", '" + reviewText.ToString() + "')";
                    command.ExecuteNonQuery();

                    MessageBox.Show("Review Posted");
                }
            }
            catch (Exception exeption) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to post review \nERROR: " + exeption.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        public int GetAverageRating(string productID)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText =
                    "SELECT SUM(Reviews.Rating) " +
                    "FROM Reviews " +
                    "INNER JOIN Products ON Reviews.ProductID = Products.ProductID " +
                    "WHERE Reviews.ProductID = " + productID;
                int total = Convert.ToInt32(command.ExecuteScalar());

                command.Parameters.Clear();
                command.CommandText =
                    "SELECT COUNT(Reviews.Rating) " +
                    "FROM Reviews " +
                    "INNER JOIN Products ON Reviews.ProductID = Products.ProductID " +
                    "WHERE Reviews.ProductID = " + productID;
                int amount = Convert.ToInt32(command.ExecuteScalar());

                if (amount > 0) { return total / amount; }
                else return -1;
            }
            catch (Exception e) //if the transaction fails
            {
                //MessageBox.Show("Error occured when trying to get review score \nERROR: " + e.ToString(), //Gives an error message to explain issue
                //    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        public (int?[] userID, string[] username, int?[] rating, string[] review, int?[] reviewID) GetReviewInfo(string productID, int requiredAmount)
        {
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText =
                    "SELECT Reviews.UserID, Users.Username, Reviews.Rating, Reviews.Review, Reviews.ReviewID " +
                    "FROM Reviews " +
                    "INNER JOIN Users ON Reviews.UserID = Users.UserID " +
                    "WHERE ProductID = " + productID.ToString();
                OleDbDataReader reader = command.ExecuteReader();
                int?[] userID = new int?[requiredAmount];
                string[] username = new string[requiredAmount];
                int?[] rating = new int?[requiredAmount];
                string[] review = new string[requiredAmount];
                int?[] reviewID = new int?[requiredAmount];
                for (int i = 0; i < requiredAmount && reader.Read(); i++)
                {
                    userID[i] = Convert.ToInt32(reader["UserID"]);
                    rating[i] = Convert.ToInt32(reader["Rating"]);
                    review[i] = reader["Review"].ToString();
                    username[i] = reader["Username"].ToString();
                    reviewID[i] = Convert.ToInt32(reader["ReviewID"]);
                }
                
                return (userID, username, rating, review, reviewID);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured when trying to read reviews \nERROR: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null, null, null, null);
            }
            finally
            {
                connection.Close();
            }
        }
        public void RemoveOwnReview(int UserID, int ProductID)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "DELETE FROM Reviews WHERE UserID = " + UserID.ToString() + " AND ProductID = " + ProductID.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception exeption) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to remove review \nERROR: " + exeption.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        public void ModeratorRemove(int ReviewID)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:
                command.CommandText = "DELETE FROM Reviews WHERE ReviewID = " + ReviewID;
                command.ExecuteNonQuery();
            }
            catch (Exception exeption) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to remove review \nERROR: " + exeption.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        public void FillDB (string name, int records)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();
                connection.Open();
                //The SQL statement:

                for (int i = 0; i < records; i++)
                {
                    string Username = name + i.ToString();
                    Hashing hashing = new Hashing();
                    var hashed = hashing.NewHash("password");
                    command.CommandText = "INSERT INTO Users ([Username], [Password],  [AccessLevel], [Salt], [CommunityAccess])" +
                    " Values('" + Username + "', '" + hashed.HashedData + "', '0', '" + hashed.salt + "', '1')";
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    command.Connection = connection;
                }

                MessageBox.Show("Complete");
            }
            catch (Exception exeption) //if the transaction fails
            {
                MessageBox.Show("Error occured when trying to add account \nERROR: " + exeption.ToString(), //Gives an error message to explain issue
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
