using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using TrendyolApp.Messages;
using TrendyolApp.Models;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;

namespace TrendyolApp.ViewModels
{
    public class UserInfoViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        private readonly TrendyolDbContext _dbcontext;
        public User CurrentUser { get; set; } = new();
        
        public string _nameText = "";
        public string _surnameText = "";
        public string _usernameText = "";
        public string _passwordText = "";
        public string _emailText = "";
        public string NameText
        {
            get { return _nameText; }
            set { Set(ref _nameText, value); }
        }

        public string SurnameText
        {
            get { return _surnameText; }
            set { Set(ref _surnameText, value); }
        }

        public string UsernameText
        {
            get { return _usernameText; }
            set { Set(ref _usernameText, value); }
        }

        public string PasswordText
        {
            get { return _passwordText; }
            set { Set(ref _passwordText, value); }
        }

        public string EmailText
        {
            get { return _emailText; }
            set { Set(ref _emailText, value); }
        }

        public UserInfoViewModel(IMessenger messenger, INavigationService navigationService, DataService dataService, TrendyolDbContext dbcontext)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;

            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as User != null)
                {
                    CurrentUser = message.Data as User;
                }

                NameText = CurrentUser.Name;
                SurnameText = CurrentUser.Surname;
                UsernameText = CurrentUser.Username;
                PasswordText = CurrentUser.Password;
                EmailText = CurrentUser.Email;
            });
            _dbcontext = dbcontext;
        }

        public RelayCommand SaveChanges_Button => new RelayCommand(() =>
        {
            if (CurrentUser != null && CurrentUser.Name != _nameText || CurrentUser.Surname != _surnameText || CurrentUser.Username != _usernameText || CurrentUser.Email != _emailText)
            {
                CurrentUser.Name = _nameText;
                CurrentUser.Surname = _surnameText;
                CurrentUser.Username = _usernameText;
                CurrentUser.Email = _emailText;

                _dbcontext.SaveChanges();

                MessageBox.Show("Changes successfully saved!");
            }
            else
            {
                MessageBox.Show("No changes detected.");
            }
        });

        public RelayCommand Back_Button => new(() =>
        {
            _navigationService.NavigateTo<UserViewModel>();
        });
    }
}

