using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using MvvmHelpers;
using Xamarin.CommunityToolkit;
using Xamarin.CommunityToolkit.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;
using GreenJournal.Models;
using System.Threading.Tasks;
using GreenJournal.Services;

namespace GreenJournal.ViewModels
{
    public class NewJournalPageVM : BaseViewModel
    {

        public AsyncCommand SaveCommand { get; }
        public AsyncCommand DeleteCommand { get; }

        string pagecontent;
        DateTime entrydate;

        public string PageContent {  get => pagecontent; set => SetProperty(ref pagecontent, value); }
        public DateTime EntryDate { get => entrydate; set => SetProperty(ref entrydate, value); }

        public NewJournalPageVM() {
            //BindingNameVariable = New Command(methodName)

            var SaveCommand = new AsyncCommand(SaveNew);
        }

        async Task SaveNew()
        {
            if (IsBusy) return;
            IsBusy = true;

            if (string.IsNullOrWhiteSpace(pagecontent)) return;

            //Task<int> saved = new Task<int>(() =>
            //{
                

            //    return JournalServices.SaveEntryAsync((PageContent, EntryDate));
            //});

            //saved.Start();
            //await saved;

            await JournalServices.AddEntry(pagecontent);

        }
        
        
        
        
        
        public DateTime CurrentDate
        {
            get => CurrentDate;
            set
            {
                if (value == CurrentDate)
                    return;
                CurrentDate = value;
                OnPropertyChanged(nameof(CurrentDate));
            }
        }

        //void DateChanged()
        //{
        //    CurrentDate = ;
        //}
    }   
}
