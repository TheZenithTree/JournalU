using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace GreenJournal.Views
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            // ********This is a test data for debugging list view********
            var journalEntries = new ObservableCollection<JournalEntry>
            {
                new JournalEntry { Date = DateTime.Now, Text = "I love driving." },
                new JournalEntry { Date = DateTime.Now.AddDays(-1), Text = "I went to Dallas." },
                new JournalEntry { Date = DateTime.Now.AddDays(-5), Text = "It was a nice day!" },
                new JournalEntry { Date = DateTime.Now.AddDays(-6), Text = "I went to school!" },
            };

            // Bind the data to ListView
            journalListView.ItemsSource = journalEntries;
        }
    }

    // Define JournalEntry class
    public class JournalEntry
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
