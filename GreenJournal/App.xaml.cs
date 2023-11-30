using System.ComponentModel.DataAnnotations.Schema;
using Xamarin.Forms;
using System.IO;
using System;
using GreenJournal.Services;

namespace GreenJournal
{
    public partial class App : Application
    {
        private static JournalServices database;
        private static JournalServices Database
        {
            get
            {
                if (database == null)
                    database = new JournalServices();

                return database;
            }
        }


        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
