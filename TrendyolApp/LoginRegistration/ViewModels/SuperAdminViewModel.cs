using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using TrendyolApp.Messages;
using TrendyolApp.Models;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;

namespace TrendyolApp.ViewModels
{
    public class SuperAdminViewModel : ViewModelBase
    {
        private readonly TrendyolDbContext _dbContext;
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        private ObservableCollection<User> _users;
        private User _selectedUser;
        private string _searchText;

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set { Set(ref _users, value); }
        }

        public User SelectedUser
        {
            get { return _selectedUser; }
            set { Set(ref _selectedUser, value); }
        }

        public string SearchText
        {
            get { return _searchText; }
            set { Set(ref _searchText, value); }
        }


        public SuperAdminViewModel(TrendyolDbContext dbContext, INavigationService navigationService, IMessenger messenger, DataService dataService)
        {
            _dbContext = dbContext;
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;

            //_messenger.Register<DataMessage>(this, message =>
            //{
            //    if (message.Data as User != null) 
            //        Users.Add(message.Data as User);
            //});

            Users = new ObservableCollection<User>(_dbContext.Users);
        }


        public RelayCommand Search_Button => new(() =>
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                Users = new ObservableCollection<User>(_dbContext.Users);
            }
            else
            {
                Users = new ObservableCollection<User>(
                _dbContext.Users.Where(u => u.Username.ToLower().Contains(SearchText.ToLower()) || u.Membership.ToLower().Contains(SearchText.ToLower())));
            }
        });

        public RelayCommand ChangeToUserCommand => new(() =>
        {
            if (SelectedUser != null)
            {
                SelectedUser.Membership = "User";
                _dbContext.SaveChanges();
            }
            Users = new ObservableCollection<User>(_dbContext.Users);
        });

        public RelayCommand ChangeToAdminCommand => new(() =>
        {
            if (SelectedUser != null)
            {
                SelectedUser.Membership = "Admin";
                _dbContext.SaveChanges();
            }
            Users = new ObservableCollection<User>(_dbContext.Users);
        });

        public RelayCommand CreateUser_Button => new(() =>
        {
            _navigationService.NavigateTo<CreateUserViewModel>();
        });

        public RelayCommand DeleteUser_Button => new(() =>
        {
            if (SelectedUser != null)
            {
                if (SelectedUser.Membership == "SuperAdmin")
                {
                    MessageBox.Show("Нельзя удалить СуперАдмина");
                    return;
                }

                _dbContext.Users.Remove(SelectedUser);
                _dbContext.SaveChanges();
                Users = new ObservableCollection<User>(_dbContext.Users);
            }
        });

        public RelayCommand Out_Button
        {
            get => new(
                () =>
                {
                    _navigationService.NavigateTo<LoginViewModel>();
                });
        }
    }
}
