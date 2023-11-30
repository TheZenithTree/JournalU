using GreenJournal.Models;
using GreenJournal.Services;
using MvvmHelpers;
using System;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace GreenJournal.ViewModels
{
    public class ViewEntryVM : BaseViewModel
    {
        public Entry Entry { get; private set; }

        public AsyncCommand SaveCommand { get; }
        public AsyncCommand DeleteCommand { get; }

        public string PageContent
        {
            get { return Entry.Content; }
            set
            {
                if (value == Entry.Content) return;
                Entry.Content = value;
                OnPropertyChanged();
            }
        }
        public DateTime EntryDate
        {
            get { return Entry.EntryDateTime; }
            set
            {
                if (value == Entry.EntryDateTime) return;
                Entry.EntryDateTime = value;
                OnPropertyChanged();
            }
        }

        public int? EntryID
        {
            get { return Entry.ID; }
        }

        public ViewEntryVM()
        {
            var SaveCommand = new AsyncCommand(SaveEdited);
            var DeleteCommand = new AsyncCommand(Delete);
        }

        async Task SaveEdited()
        {
            if (string.IsNullOrWhiteSpace(PageContent)) return;

            var entry = new Entry
            {
                ID = EntryID,
                EntryDateTime = EntryDate,
                Content = PageContent
            };
            await JournalServices.SaveEntryAsync(entry);

        }

        async Task Delete()
        {
            await JournalServices.DeleteEntry(EntryID);
        }



    }
}
