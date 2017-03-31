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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tehtava1_1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public int truck_clicker = 0;
        public int auto_clicker { get; set; }


        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void Truck_Click(object sender, RoutedEventArgs e)
        {
            
            truck_clicker++;
            textBox.Text = Convert.ToString(truck_clicker);
        }

        private void Car_Click(object sender, RoutedEventArgs e)
        {
            auto_clicker++;
            textBox1.Text = Convert.ToString(auto_clicker);
        }
    }
}
