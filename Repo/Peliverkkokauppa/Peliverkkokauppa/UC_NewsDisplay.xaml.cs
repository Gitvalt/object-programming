using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Peliverkkokauppa
{
    public sealed partial class UC_NewsDisplay : UserControl
    {
        public List<News> newsList = new List<News>();
        public ObservableCollection<News> newsList_o = new ObservableCollection<News>();

        //Constructor
        public UC_NewsDisplay()
        {
            this.InitializeComponent();
            displayNews();
        }

        //Displays fetched news on the UI
        private async void displayNews()
        {
            try
            {
                DatabaseController databaseController = new DatabaseController();

                //create async task that returns a list
                Task<List<News>> first = databaseController.GetNews();

                List<News> news = new List<News>();

                //wait for results
                news = await first;

                if (news != null || news.Count != 0)
                {
                    news = news.OrderBy(o => o.Date.Date).ThenBy(e => e.Date.TimeOfDay).ToList();
                    news.Sort((a, b) => b.Date.CompareTo(a.Date));
                    foreach (News n in news)
                    {
                        newsList.Add(n);
                        newsList_o.Add(n);
                    }
                }
            }
            catch (Exception err)
            {
                //loginBox.errorList_o.Add(new Error("Fetching data from server failed.", "err " + err.Message));
            }


        }

    }
}
