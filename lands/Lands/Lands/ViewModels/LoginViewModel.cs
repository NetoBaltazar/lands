

namespace Lands.ViewModels
{

    using System.Windows.Input;
    class LoginViewModel
    {
        #region Propertis
        public string Email
        {
            get; set;
        }
       
        public string Password
        {
            get; set;
        }
        public bool IsRuIsRunning
        {
            get; set;
        }
        public bool IsRemembered
        {
            get; set;
        }
        #endregion
        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }
        #endregion
        #region Commands
        public ICommand LoginCommand
        {
            get; set;
        }
        #endregion
    }
}
