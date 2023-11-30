using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using GreenJournal.Models;
using GreenJournal.ViewModels;

namespace GreenJournal.Views
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            //// ********This is a test data for debugging list view********
            //var journalEntries = new ObservableCollection<Models.Entry>
            //{
            //    new Models.Entry { Time = DateTime.Now, Content = "I love driving." },
            //    new Models.Entry { Time = DateTime.Now.AddDays(-1), Content = "I went to Dallas." },
            //    new Models.Entry { Time = DateTime.Now.AddDays(-5), Content = "It was a nice day!" },
            //    new Models.Entry { Time = DateTime.Now.AddDays(-6), Content = "I went to school!" },
            //};

            //// Bind the data to ListView
            //journalListView.ItemsSource = journalEntries;
        }
    }
}
