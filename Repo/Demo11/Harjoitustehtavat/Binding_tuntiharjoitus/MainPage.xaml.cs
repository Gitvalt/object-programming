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
using Binding_tuntiharjoitus.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Binding_tuntiharjoitus
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>



    public sealed partial class MainPage : Page
    {


        public EmployeeViewModel ViewModel { get; set; }
        string propertybindingtext { get; set; }
        Person person;

        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new EmployeeViewModel();
            propertybindingtext = "Sample of property text";

            person = new Person { Firstname = "Kirsi", Lastname = "Kernel" };


        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Employee employee = (Employee)e.ClickedItem;
            ResultTextBlock.Text = "Selected employee: " + employee.Firstname + " " + employee.Lastname;
        }
    }
}
