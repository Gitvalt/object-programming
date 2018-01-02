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
using System.Collections.ObjectModel;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Peliverkkokauppa
{
    public sealed partial class UC_LoginForm : UserControl
    {

        public List<Error> errorList = new List<Error>();
        public ObservableCollection<Error> errorList_o = new ObservableCollection<Error>();

        public string Username
        {
            get
            {
                return UsernameBox.Text;
            }
        }
        public string Password
        {
            get
            {
                return PasswordBox.Password;
            }
        }

        //Constructor
        public UC_LoginForm()
        {
            this.InitializeComponent();
        }

        public delegate void onLoginClick(string username, string password);
        public delegate void onForgotPassClick();
        public delegate void onNewACCClick();

        public event onLoginClick SendLogin;
        public event onForgotPassClick SendForgotPass;
        public event onNewACCClick SendACC;

        private void onLoginClick_event(object sender, RoutedEventArgs e)
        {
            SendLogin(Username, Password);
        }

        private void onForgotPass_event(object sender, RoutedEventArgs e)
        {
            SendForgotPass();
        }

        private void onNewAcc_event(object sender, RoutedEventArgs e)
        {
            SendACC();
        }

    }
}
