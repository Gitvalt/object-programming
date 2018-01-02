using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;
using Windows.Security.Cryptography.DataProtection;


namespace Peliverkkokauppa
{
    //abstract parent for account types
    class User
    {               
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public DateTime AccountCreated { get; set; }

        //Constructor with fields
        public User(string firstname, string lastname, string username, string password, string email, string phonenumber, string address, DateTime accountCreated)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
            Email = email;
            Phonenumber = phonenumber;
            Address = address;
            AccountCreated = accountCreated;
        }

        //Empty Contructor
        public User()
        {

        }

        public void ChangeInformation()
        {

        }

        public void RestorePassword()
        {

        }

        public static Boolean validateUser(string user)
        {
            int length = user.Length;

            //is username empty
            if (user == null) { return false; }
            
            //is username long enough
            if (length < 4 && length > 20)
            {
                return false;
            }

            //if all checks were passed, then returns true
            return true;
        }

        public static Boolean validatePass(string pwd)
        {
            int length = pwd.Length;
            int minLength = 8;
            int maxLength = 20;

            //is username empty
            if (pwd == null) { return false; }

            //is username long enough
            if (length < minLength && length > maxLength)
            {
                return false;
            }

            //if all checks were passed, then returns true
            return true;
        }

        //For encrypting password
        public static string EncryptString(string unEncrypted)
        {
            if (unEncrypted.Equals(null))
            {
                throw new ArgumentNullException("Cannot encrypt empty string");
            }

            string salt = "xx_MONGO_Pass";
            HashAlgorithmProvider cryptoProvider = HashAlgorithmProvider.OpenAlgorithm(SymmetricAlgorithmNames.AesEcb);
            return null;
        }

        /*
        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Address + " " + Phonenumber;
        }
        */
    }

}
