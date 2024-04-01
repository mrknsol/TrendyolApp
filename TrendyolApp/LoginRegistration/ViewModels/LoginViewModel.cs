using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using TrendyolApp.Messages;
using TrendyolApp.Models;
using TrendyolApp.Services.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Services.Interfaces;
using System.Windows;
using System.Windows.Controls;
using Azure.Identity;

namespace TrendyolApp.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public TrendyolDbContext _dbcontext;
        private ViewModelBase _currentView;
        public string _loginText = "";
        public string _passwordText = "";
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        public readonly LoginService _loginService;
        public string _currentVisibility = "Visible";
        public string _currentMember = "User";

        public string CurrentVisibility
        {
            get { return _currentVisibility; }
            set { Set(ref _currentVisibility, value); }
        }

        public string CurrentMember
        {
            get { return _currentMember; }
            set { Set(ref _currentMember, value); }
        }

        public string LoginText
        {
            get { return _loginText; }
            set { Set(ref _loginText, value); }
        }
        public string PasswordText
        {
            get { return _passwordText; }
            set { Set(ref _passwordText, value); }
        }
        public ViewModelBase CurrentView
        {
            get => _currentView;
            set
            {
                Set(ref _currentView, value);
            }
        }

        public LoginViewModel(IMessenger messenger, INavigationService navigationService, DataService dataService, TrendyolDbContext trendyolDbContext, LoginService loginService)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;
            _dbcontext = trendyolDbContext;
            _loginService = loginService;
            
        }
        public RelayCommand Login_Button => new(() =>
        {
            var user = _dbcontext.Users.FirstOrDefault(u => u.Username == LoginText);
            _dataService.SendData(user);

            if (_loginService.AuthenticateUser(LoginText, PasswordText, _dbcontext.Users))
            {
                MessageBox.Show("Welcome, " + LoginText + "!");

                _loginService.GetUserMembership(_dbcontext.Users, LoginText);
            }
            else
            {
                MessageBox.Show("Authentication failed. Please check your credentials.");
                
            }
            PasswordText = "";
            LoginText = "";
        });


        public RelayCommand Registration_Link => new(() =>
        {   
            _navigationService.NavigateTo<RegistrationViewModel>();
        });

        public RelayCommand ForgotPassword_Link => new(() =>
        {
            _navigationService.NavigateTo<EmailVerificationViewModel>();
        });
    }
}

