//using GreenJournal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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

            ShowPasswordCommand = new Command(OnToggleShowPass);

            

            BindingContext = this;


        }

        public ICommand ShowPasswordCommand { get; }

        bool showPasswordValue = false;
        int? currentPassword = null;
        bool enableReminder = false;

        public void OnToggleShowPass()
        {
            if (showPasswordCell.IsEnabled == false)
            {
                showPasswordValue = false;
                currentPassword = null;
            }
            else
            {
                showPasswordValue = true;
                currentPassword = null;
            }

        }
        
        public int? CurrentPassword
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

        private void ShowPasswordCell_OnChanged(object sender, ToggledEventArgs e)
        {
            if (showPasswordCell.IsEnabled == true)
            {
                showPasswordValue = true;
            }
            else
                showPasswordValue = false;

        }


        private void EnableReminderCell_OnChanged(object sender, ToggledEventArgs e)
        {
            if (enableReminderCell.IsEnabled == true)
            {
                enableReminder = true;
            }
            else
                enableReminder = false;
        }

        private void SetPasswordCell_Completed(object sender, EventArgs e)
        {
            currentPassword = int.Parse(setPasswordCell.Text);
        }

    }
}