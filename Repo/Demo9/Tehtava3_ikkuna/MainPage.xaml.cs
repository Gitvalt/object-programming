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
using Windows.UI.Xaml.Shapes;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tehtava3_ikkuna
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

        private void Laske_pintaala_Click(object sender, RoutedEventArgs e)
        {
        
                int x = Convert.ToInt16(leveysinput.Text);
                int y = Convert.ToInt16(korkeusinput.Text);
                int z = Convert.ToInt16(karmipuuinput.Text);

           
            

            int IKpintaala = x * y;
            int LApintaala = (x - (2*z)) * (y - (2*z));    
            int karminpiiri = 2*(x+y);


            //muutetaan senteiksi
            karminpiiri = karminpiiri / 10;
            IKpintaala = IKpintaala / 10;
            LApintaala = LApintaala / 10;

            Ikkunapintaala.Text = Convert.ToString(IKpintaala + "cm^2");
            Lasinpintaala.Text = Convert.ToString(LApintaala + "cm^2");
            Karminpiiri.Text = Convert.ToString(karminpiiri + "cm");

        }
    }
}
