using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.IO.Compression;
using Windows.Data.Text;
using System.Text;
using Windows.Security.Cryptography.Core;
using Windows.UI.Core;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Peliverkkokauppa
{

    public sealed partial class login1 : Page
    {
        private double initialHeaderFontSize;
        private UC_NewsDisplay newsForm_ref;
        private UC_LoginForm loginBox;



        //Constructor
        public login1()
        {
            this.InitializeComponent();


            //get the login UserControl object
            loginBox = loginForm;
            

            //save initial header size
            initialHeaderFontSize = Label_CompanyName.FontSize;
            
            //Error tests
            loginBox.errorList.Add(new Error("System is being updated", "Skiv"));
            

        }

        //setup form controls
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //setup delegates from login form usercontrol
            loginForm.SendLogin += new UC_LoginForm.onLoginClick(onLogin);
            loginForm.SendForgotPass += new UC_LoginForm.onForgotPassClick(onForgotPass);
            loginForm.SendACC += new UC_LoginForm.onNewACCClick(onNewAccount);
        }

        //---Onclicks:---
        private void Exit_click(object sender, RoutedEventArgs e) => App.Current.Exit();


        ///---OnChange---
        //Change company name elements font based on size of current window
        private void LoginHeader_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double headerWidth = LoginHeader.Width;

            if (headerWidth > 850.0f)
            {
                Label_CompanyName.FontSize = initialHeaderFontSize;
            }
            else
            {
                Label_CompanyName.FontSize = initialHeaderFontSize * 0.50;
            }

        }
        
        
        private void onLogin(string username, string password)
        {
            if(username == "" || password == "")
            {
                loginForm.errorList_o.Add(new Error("Username or password null", "Username or password are null. Cant login"));
            }
            
            //Username or password not valid
            else if(!validateLogin(username, password))
            {
                loginForm.errorList_o.Add(new Error("Username or password not valid", "Username or password are not valid. Cant login"));
            }

            //if valid 
            else
            {
                Login(username, password);
            }
        }

        private void onForgotPass()
        {
            this.Frame.Navigate(typeof(RestorePass1));
        }

        private void onNewAccount()
        {
            this.Frame.Navigate(typeof(CreateAccount1));
        }


        private Boolean validateLogin(string user, string pwd)
        {
            //---username---
            Boolean validUsername = User.validateUser(user);
            Boolean validPassword = User.validatePass(pwd);

            //if both checks return true
            if (validPassword && validUsername)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //TODO: Encrypt data
        private async void Login(string user, string pwd)
        {

            DatabaseController cc = new DatabaseController();
            Boolean isTrue = await cc.Authenticate(user, pwd);

            if (isTrue == false)
            {
                loginForm.errorList_o.Add(new Error("Login error", "Incorrect username and password"));

            }
            else
            {
                //login was successfull
                this.Frame.Navigate(typeof(Peliverkkokauppa.Pages.Authorized.UserPage));
            }
        }
    }
}
