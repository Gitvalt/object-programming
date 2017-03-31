using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tehtava4_Kiuas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public string textline { get; set; }
        public string inputtype { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

        }

        private void Clickfunktion(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            textline += button.Content.ToString();
            Screen.Text = textline;
            Info.Text = "";
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text != "")
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1);
            }
            else
            {
                Info.Text = "Screen is empty";
            }
        }

        private void button_ok_Click(object sender, RoutedEventArgs e)
        {
            Kiuas XTR = new Kiuas();
            string screen_text = Screen.Text;

         if (screen_text != null)
            {

                if (humidity_radio.IsChecked == true)
                   {
                    inputtype = "humidity";

                    if (XTR.Isok(screen_text, inputtype))
                    {
                        Hum_count.Text = screen_text;
                        Screen.Text = "";
                        XTR.humidity = Convert.ToDouble(screen_text);
                        Info.Text = XTR.errormessage;
                    }
                    else
                    {
                        Info.Text = XTR.errormessage;
                    }

                  }


              if(lampo_radio.IsChecked == true)
                {
                inputtype = "Temperature";
                    if (XTR.Isok(screen_text, inputtype))
                    {
                        Temp_count.Text = screen_text;
                        Screen.Text = "";
                        XTR.tempeature = Convert.ToDouble(screen_text);
                        Info.Text = XTR.errormessage;
                    }
                    else
                    {
                        Info.Text = XTR.errormessage;
                    }
                }

                if(lampo_radio.IsChecked == false && humidity_radio.IsChecked == false)
                {
                    Info.Text = "Select the setting you want to change";
                }

            }
            
        }
    }


}
