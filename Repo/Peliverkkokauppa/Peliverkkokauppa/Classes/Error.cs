using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliverkkokauppa
{
    public class Error
    {

        private string title;
        public string Title
        {
           get { return title; }
            set { }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { }
        }


        //Constructor
        public Error(string err_title, string err_msg)
        {
            title = err_title;
            message = err_msg;
        }

        //override tostring method
        public override string ToString()
        {
            return string.Format("Error '{0}': '{1}'", title, message);
        }
    }
}
