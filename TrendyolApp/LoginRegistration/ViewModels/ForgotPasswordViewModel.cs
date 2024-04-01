using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;
using TrendyolApp.Models;
using TrendyolApp.Messages;
using GalaSoft.MvvmLight.Command;

namespace TrendyolApp.ViewModels
{
    public class ForgotPasswordViewModel : ViewModelBase
    {
        public TrendyolDbContext _dbcontext;
        private string emailToReset = "";
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        public readonly ForgotPasswordService _forgotPasswordService = new();
        public string _passwordText = "";
        public string _confirmText = "";
        public string PasswordText
        {
            get { return _passwordText; }
            set { Set(ref _passwordText, value); }
        }
        public string ConfirmText
        {
            get { return _confirmText; }
            set { Set(ref _confirmText, value); }
        }
        public ForgotPasswordViewModel(IMessenger messenger, INavigationService navigationService, DataService dataService, TrendyolDbContext trendyolDbContext)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;
            _dbcontext = trendyolDbContext;

            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data != null)
                    emailToReset = message.Data.ToString();

            });

        }


       
        public RelayCommand ResetPassword_Button => new(() =>
        {
            string newPassword = PasswordText;
            string confirmNewPassword = ConfirmText;


            string validationMessage = _forgotPasswordService.ValidateInput(newPassword, confirmNewPassword);

            if (_forgotPasswordService.IsInputValid(newPassword))
            {
                if (string.IsNullOrEmpty(validationMessage))
                {
                    if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
                    {
                        MessageBox.Show("Please enter a new password and confirm it.");
                        return;
                    }

                    if (newPassword != confirmNewPassword)
                    {
                        MessageBox.Show("Passwords do not match. Please enter and confirm your password.");
                        ConfirmText = "";
                        return;
                    }
                    if (_dbcontext.Users != null)
                    {
                        MessageBox.Show($"{_dbcontext.Users.ToString()} and {emailToReset}");

                    }
                    User userToReset = _dbcontext.Users.FirstOrDefault(user => user.Email == emailToReset);

                    if (userToReset != null)
                    {

                        userToReset.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);

                        _dbcontext.SaveChanges();

                        MessageBox.Show("Password has been successfully updated.");

                        _navigationService.NavigateTo<LoginViewModel>();
                    }
                    else
                    {
                        MessageBox.Show("Users Are Null!!");
                    }
                }
            }
        });
        public RelayCommand BackToLoginPage_Button => new(() =>
        {
            _navigationService.NavigateTo<LoginViewModel>();
        });
    }
}
