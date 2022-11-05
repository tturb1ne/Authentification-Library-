using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Authorization1.model;
using Authorization1.Core;
using Authorization1.View;

namespace Authorization1.ViewModel
{
    public class UserCollectionViewModel : BaseViewModel
    {
        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users { get => _users; set => SetProperty(ref _users, value); }

        public UserCollectionViewModel()
        {
            Users = new ObservableCollection<User>(UserParser.ParseFile("users3.txt"));
        }
    }
}
