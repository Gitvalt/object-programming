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
using System.Diagnostics;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Demo_17
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GamePage2));
        }

        private void HighscoreButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HighscorePage));
        }

        private void InstructionsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InstructionPage));
        }

        private void HyperClick_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person { Firstname = FirstName.Text, Lastname = Surname.Text };
            this.Frame.Navigate(typeof(Page2), person);
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            Debug.WriteLine("Number is " + (App.Current as App).Number);
            base.OnNavigatedTo(e);
        }

    }

}
