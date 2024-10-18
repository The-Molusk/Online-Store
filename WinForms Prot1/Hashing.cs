using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinForms_Prot1
{
    internal class Hashing
    {
        public (string HashedData, string salt) NewHash (string data)
        {
            //generate new salt of random bytes
            byte[] salt = GenSalt();
            string hash = HashData(data, Encoding.Unicode.GetString(salt));
            //converts the byte arrays into unicode strings, as ASCII won't work here
            return (hash, Encoding.Unicode.GetString(salt));
        }
        private byte[] GenSalt()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            DatabaseConnectivity connectivity = new DatabaseConnectivity();
            connectivity.Initialise();
            if (connectivity.SaltExists(Encoding.Unicode.GetString(salt)))
            {
                return GenSalt();
            }
            else return salt;
        }

        public string HashData(string data, string stringSalt)
        {
            //converts back into byte array
            byte[] salt = Encoding.Unicode.GetBytes(stringSalt);

            //hashes inputted data with specified salt
            var pbkdf2 = new Rfc2898DeriveBytes(data, salt, 310000);
            byte[] hash = pbkdf2.GetBytes(20);
            return Encoding.Unicode.GetString(hash);
        }
    }
}
