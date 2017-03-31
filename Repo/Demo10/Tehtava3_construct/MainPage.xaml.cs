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

namespace Tehtava3_construct
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

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            Lottokone test = new Lottokone();
            string txt = Comboinput.SelectedItem.ToString();
            List<string> test5 = test.Draw(txt, Convert.ToInt32(Draws_input.Text));

            foreach (string row in test5)
            {
                output.Text += row;
            }

            //output.Text = test.Draw(txt, Convert.ToInt32(Draws_input.Text));

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
