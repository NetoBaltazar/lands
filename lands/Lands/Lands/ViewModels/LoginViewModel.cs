

namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using System.ComponentModel;



    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Atributes
        private string password;
        private bool isRunning;
        private bool isEnabled;

        #endregion

        #region Propertis
        public string Email
        {
            get; set;
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if (this.password!=value)
                {
                    this.password = value;
                    PropertyChanged?.Invoke(
                        this, new PropertyChangedEventArgs(nameof(this.Password)));

                }

            }
        }
        public bool IsRunning
        {
            get
            {
                return this.isRunning;
            }
            set
            {
                if (this.isRunning != value)
                {
                    this.isRunning  = value;
                    PropertyChanged?.Invoke(
                        this, new PropertyChangedEventArgs(nameof(this.IsRunning)));

                }

            }
        }
        public bool IsRemembered
        {
            get; set;
        }
        public bool IsEnabled
        {
            get
            {
                return this.isEnabled;
            }
            set
            {
                if (this.isEnabled != value)
                {
                    this.isEnabled = value;
                    PropertyChanged?.Invoke(
                        this, new PropertyChangedEventArgs(nameof(this.IsEnabled)));

                }

            }
        }
        #endregion
        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.isEnabled = true;
        }
        #endregion
        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }



        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "you must enter an email.",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "you must enter an Password.",
                    "Accept");
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;
        }
        #endregion

    }


}
