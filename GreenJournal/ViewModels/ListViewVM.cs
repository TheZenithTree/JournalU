using GreenJournal.Models;
using GreenJournal.Services;
using GreenJournal.Views;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;
using Entry = GreenJournal.Models.Entry;

namespace GreenJournal.ViewModels
{
    public class ListViewVM : BaseViewModel

    {
        MvvmHelpers.ObservableRangeCollection<Entry> entries;

        public MvvmHelpers.ObservableRangeCollection<Entry> Entries { get => entries;
            set
            {
                JournalServices.GetAllEntry();
                if (entries != value) { entries = value; }
                OnPropertyChanged();

            }
        }
        public Command SelectCommand
        {
            get
            {
                return new Command(async () => await SelectedAsync());
            }
        }
        public ViewEntryVM selectedEntry;
        public ViewEntryVM SelectedEntry {  get => selectedEntry; set => SetProperty(ref selectedEntry, value); }

        public ListViewVM()
        {
            // コンストラクタでEntriesを初期化など
            Entries = new MvvmHelpers.ObservableRangeCollection<Entry>();
            var SelectCommand = new Command(async () => await SelectedAsync());


            //データベースからデータを読み込むなど
            var databaseEntries = GetEntriesFromDatabase();
            foreach (var entry in databaseEntries)
            {
                Entries.Add(entry);
            }
        }


        async Task SelectedAsync()
        {
            if (SelectedEntry == null) return;
            await Shell.Current.Navigation.PushAsync(new ViewEntry(SelectedEntry));
            SelectedEntry = null;
        }

        //public event PropertyChangedEventHandler PropertyChanged
        //{
        //    add
        //    {
        //        ((INotifyPropertyChanged)Entries).PropertyChanged += value;
        //    }

        //    remove
        //    {
        //        ((INotifyPropertyChanged)Entries).PropertyChanged -= value;
        //    }
        //}



        private List<Entry> GetEntriesFromDatabase()
        {
            // データベースからデータを取得する処理など
            // ここでは仮のデータを返す例
            return new List<Entry>
            {
                new Entry {EntryDateTime = DateTime.Now, Content = "I love driving." },
                new Entry {EntryDateTime = DateTime.Now.AddDays(-1), Content = "I went to Dallas." },
                new Entry {EntryDateTime = DateTime.Now.AddDays(-3), Content = "It was a nice day!" }
            };
        }
    }
}
