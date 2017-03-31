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

namespace Tehtava1_CheckBoxcontrol
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
            List<CheckBox> list = new List<CheckBox>();
            list.Add(checkBox);
            list.Add(checkBox2);
            list.Add(checkBox3);
            list.Add(checkBox4);
            list.Add(checkBox5);
            
            foreach(CheckBox box in list)
            {
                if(box.IsChecked == true)
                {
                    Shopping_list_output.Text += box.Content.ToString();
                    Shopping_list_output.Text += "\n";
                }
            }

        }
    }
}
