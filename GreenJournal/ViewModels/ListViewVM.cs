using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using GreenJournal.Models;

namespace GreenJournal.ViewModels
{
    public class JournalViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Entry> Entries { get; set; }

        public JournalViewModel()
        {
            // コンストラクタでEntriesを初期化など
            Entries = new ObservableCollection<Entry>();

            // データベースからデータを読み込むなど
            var databaseEntries = GetEntriesFromDatabase();
            foreach (var entry in databaseEntries)
            {
                Entries.Add(entry);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                ((INotifyPropertyChanged)Entries).PropertyChanged += value;
            }

            remove
            {
                ((INotifyPropertyChanged)Entries).PropertyChanged -= value;
            }
        }

        private List<Entry> GetEntriesFromDatabase()
        {
            // データベースからデータを取得する処理など
            // ここでは仮のデータを返す例
            return new List<Entry>
            {
                new Entry { ID = 1, Time = DateTime.Now, Content = "I love driving." },
                new Entry { ID = 2, Time = DateTime.Now.AddDays(-1), Content = "I went to Dallas." },           
                new Entry { ID = 2, Time = DateTime.Now.AddDays(-3), Content = "It was a nice day!" }
            };
        }
    }
}
