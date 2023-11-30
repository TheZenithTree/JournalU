using GreenJournal.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace GreenJournal.ViewModels
{
    public class NewJournalPageVM : BaseViewModel
    {
        

        public Command SaveCommand { get
            {
                return new Command(async () => await SaveNew());
            }
        }
        string pagecontent;
        DateTime entrydate = DateTime.Today;

        public string PageContent {  get => pagecontent; set => SetProperty(ref pagecontent, value); }
        public DateTime EntryDate { get => entrydate; set => SetProperty(ref entrydate, value); }

        public NewJournalPageVM()
        {
            //BindingNameVariable = New Command(methodName)

            var SaveCommand = new Command(async () => await SaveNew());
        }

        public async Task SaveNew()
        {
            if (string.IsNullOrWhiteSpace(PageContent))
            {
                return;
            };

            //Task<int> saved = new Task<int>(() =>
            //{


            //    return JournalServices.SaveEntryAsync((PageContent, EntryDate));
            //});

            //saved.Start();
            //await saved;

            await JournalServices.AddEntry(PageContent, EntryDate);

        }



    }   
}
