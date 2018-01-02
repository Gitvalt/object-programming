using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliverkkokauppa
{
    static class Session
    {
        public static User Logged_User { get; set; }

        public static string sessionToken { get; set; }

        public static DateTime loginTimeStamp { get; set; }
        

        //check if user has been logged in
        public static Boolean hasLoggedIn()
        {
            if(string.Equals(Logged_User, null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
