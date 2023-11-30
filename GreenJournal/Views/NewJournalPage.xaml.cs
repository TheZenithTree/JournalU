using GreenJournal.ViewModels;
using GreenJournal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace GreenJournal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewJournalPage : ContentPage
    {
        public NewJournalPage()
        {
            InitializeComponent();
        }
    }
}