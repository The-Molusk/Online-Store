using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;

namespace WinForms_Prot1
{
    internal class MailSystem
    {
        string systemMail = "wedrm001@woodbridgehigh.net", systemPassword = "Smackapacka_123", displayName = "no-reply";

        //sending a confirmation email to the user after they buy a product/s
        public void SendConfirmation (string email, string[] names, int[] prices)
        {
            try
            {
                MailMessage newMail = new MailMessage();
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                newMail.From = new MailAddress(systemMail, displayName);
                newMail.To.Add(email); // reciever
                newMail.Subject = "Purchase Summary"; //subject
                newMail.IsBodyHtml = true; 
                string body = "<h1> Thank you for your purchase </h1> <h2> See below to view a summary of your purchase: </h2> <ul>"; //html for email body
                int total = 0;
                for (int i = 0; i < names.Length; i++)
                {
                    string price = "£" + (Convert.ToDouble( prices[i])/100).ToString();
                    total += prices[i];
                    body += "<li>" + names[i] + "--------" + price + "</li>";
                }
                
                body += "</ul> <p1> Total =    " + "£" + (Convert.ToDouble(total) / 100).ToString();
                newMail.Body = body;
                // enable SSL for encryption across channels
                client.EnableSsl = true;
                client.Port = 587;
                // Provide authentication information with Gmail SMTP server to authenticate your sender account
                client.Credentials = new System.Net.NetworkCredential(systemMail, systemPassword);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(newMail); // Send the constructed mail
                MessageBox.Show("Items successfully purchases, summary enail has been sent.");
            }
            catch
            {
                MessageBox.Show("Email failed to send");
            }
            
        }
    }
}
