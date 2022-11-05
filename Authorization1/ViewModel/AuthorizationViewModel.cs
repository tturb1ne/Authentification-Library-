using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authorization1.Command;
using Authorization1.Core;
using System.Windows.Input;
using System.Windows;
using Authorization1.View.Windows;

namespace Authorization1.ViewModel
{
    public class AuthorizationViewModel : BaseViewModel
    {
        private string _login;
        private string _password;

        public string Login { get => _login; set => SetProperty(ref _login, value); }
        public string Password { get => _password; set => SetProperty(ref _password, value); }
        public ICommand SingInCommand { get; private set; }

        public AuthorizationViewModel()
        {
            SingInCommand = new DelegateCommand(SingIn);
        }
        private void SingIn(object parameter)
        {
            if (UserValidator.Validate(Login, Password))
            {
                new UserListWindow().Show();
                Application.Current.Windows
                    .Cast<Window>()
                    .FirstOrDefault(w => w is AuthorizationWindow)
                    .Close();
            }
            else MessageBox.Show("Invalid login or password");
        }
    }
}
