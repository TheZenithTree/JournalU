//using GreenJournal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenJournal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
       public SettingsPage()
        {
            InitializeComponent();
            //BindingContext = new SettingsPageVM();

        }

        bool showPasswordValue = false;
        int currentPassword = 0000;
        bool enableReminder = false;

        public int CurrentPassword
        {
            get => currentPassword;

            set
            {
                if (value == currentPassword)
                    return;
                currentPassword = value;
                OnPropertyChanged();
            }
        }

        private void showPasswordCell_OnChanged(object sender, ToggledEventArgs e)
        {
            if (showPasswordCell.IsEnabled == true)
            {
                showPasswordValue = true;
            }
            else
                showPasswordValue = false;

        }


        private void enableReminderCell_OnChanged(object sender, ToggledEventArgs e)
        {
            if (e.Value == true) 
            {
                enableReminder = true;
            }
            else
                enableReminder = false;
        }

        private void setPasswordCell_Completed(object sender, EventArgs e)
        {
            currentPassword = 
        }
    }
}