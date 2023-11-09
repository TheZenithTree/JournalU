using GreenJournal.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenJournal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewJournalPage : ContentPage
    {
        public NewJournalPage()
        {
            InitializeComponent();
            BindingContext = new NewJournalPageVM();
            
        }
    }
}