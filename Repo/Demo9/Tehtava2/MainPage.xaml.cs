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

namespace Tehtava2
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

        private void button_Click(object sender, RoutedEventArgs e)
        {

            bool tester_int;
            double y;
      

            int listselec = listBox.SelectedIndex; 

            string text = textBox.Text;
            tester_int = double.TryParse(text, out y);

            


            if (tester_int == true)
            {


                if(listselec == 1)
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(text) * 5.94573);
                }
                else
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(text) / 5.94573);
                }

            }
            else
            {
                textBox1.Text = "Input was not a number";
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void textBox_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (textBox.Text == "Insert number")
            {
                textBox.Text = "";
            }
        }
    }
}
