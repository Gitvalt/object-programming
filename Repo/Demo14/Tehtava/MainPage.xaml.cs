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
using Tehtava.test;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tehtava
{
    
    /// <summary>
    /// Tehtava, jolla testataan eräänlaisen galleria sovelluksen tekemistä.
    /// </summary>


    public sealed partial class MainPage : Page
    {
        //Lista of pictures
        
        public Queue<test.Image> images = new Queue<test.Image>();
        public ImageSource mainpage;
        public MainPage()
        {
            this.InitializeComponent();
            test.Image image1 = new test.Image("Assets/Media/employee01.png");
            test.Image image2 = new test.Image("Assets/Media/employee02.png");
            test.Image image3 = new test.Image("Assets/Media/employee03.png");
            test.Image image4 = new test.Image("Assets/Media/employee04.png");

           

            images.Enqueue(image1);
            images.Enqueue(image2);
            images.Enqueue(image3);
            images.Enqueue(image4);

            

            foreach(test.Image kuva in images)
            {
                DebugBOX.Text += kuva.path + Environment.NewLine;
            }
        }



    }
}
