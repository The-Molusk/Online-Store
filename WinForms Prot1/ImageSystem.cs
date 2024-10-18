using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Prot1
{
    internal class ImageSystem
    {
        //change this directory to the real resource root for the system cloud
        string resourcesRoot = @"C:\Users\milos\Documents\GitHub\NEA\Resources\";
        
        OpenFileDialog openFileDialog;
        public int GetImageCount(int ID)
        {
            string productImageRoot = resourcesRoot + @"ProductImages\";
            if (Directory.Exists(productImageRoot + ID.ToString()))
            {
                int count = Directory.GetFiles(productImageRoot + ID.ToString(), "*", SearchOption.TopDirectoryOnly).Length;
                return count;
            }
            else return 0;
        }
        public Image GetImageRoot_Product(string productID, int imageNum)
        {
            string productImageRoot = resourcesRoot + @"ProductImages\";
            Image imageRoot = Image.FromStream(new MemoryStream(File.ReadAllBytes(productImageRoot + productID + @"\" + imageNum.ToString() + @".jpg")));
            return imageRoot;
        }
        public void ClearImages(int productID)
        {
            string productImageRoot = resourcesRoot + @"ProductImages\";
            int amount = GetImageCount(productID);
            Directory.Delete(productImageRoot + productID, true);
        }
        public void AddImage_Product(int productID)
        {
            string productImageRoot = resourcesRoot + @"ProductImages\";
            openFileDialog = new OpenFileDialog()
            {
                Filter = "Image files (*.jpg)|*.jpg",
                Title = "Open image file"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int fileCount = GetImageCount(productID);
                string sourceFilePath = openFileDialog.FileName;
                string targetPath = productImageRoot + productID.ToString();
                string targetFilePath = targetPath + @"\" + fileCount.ToString() + ".jpg";

                Directory.CreateDirectory(targetPath);
                File.Copy(sourceFilePath, targetFilePath);
            }
        }
        public void AddImage_User(int? userID)
        {
            string userImageRoot = resourcesRoot + @"UserImages\";
            openFileDialog = new OpenFileDialog()
            {
                Filter = "Image files (*.jpg)|*.jpg",
                Title = "Open image file"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourceFilePath = openFileDialog.FileName;
                    string targetPath = userImageRoot;
                    string targetFilePath = targetPath + @"\" + userID.ToString() + ".jpg";

                    File.Copy(sourceFilePath, targetFilePath, true);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        public Image GetImageRoot_User(int? userID)
        {
            Image image = Image.FromStream(new MemoryStream(File.ReadAllBytes(resourcesRoot + @"UserImages\" + userID.ToString() + ".jpg")));
            return image;
        }
        public Image GetPlaceholder()
        {
            Image imageRoot = Image.FromFile(resourcesRoot + "placeholder.jpg");
            return imageRoot;
        }
    }
}
