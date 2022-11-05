using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authorization1.Command;
using Authorization1.View.Pages;
using System.Windows.Controls;
using System.Windows.Input;

namespace Authorization1.ViewModel
{
    public class AdminViewModel : BaseViewModel
    {
        private Page _selectedPage;

        public Page SelectedPage { get => _selectedPage; set => SetProperty(ref _selectedPage, value); }
        public ICommand OpenUsersPageCommand { get; private set; }

        public AdminViewModel()
        {
            OpenUsersPageCommand = new DelegateCommand(OpenUsersPage);
        }

        private void OpenUsersPage(object parameter)
        {
            SelectedPage = new UserPage();
        }
    }
}