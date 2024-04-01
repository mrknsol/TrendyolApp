using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using TrendyolApp.Models;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using BCrypt.Net;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System;

namespace TrendyolApp.ViewModels
{
    public partial class RegistrationViewModel : ViewModelBase
    {

        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        public string _nameText = "";
        public string _surnameText = "";
        public string _loginText = "";
        public string _passwordText = "";
        public string _emailText = "";
        public string _membershipText = "";
        public readonly TrendyolDbContext _dbContext;
        public readonly RegistrationService _registrationService;

        private byte[]_selectedImage;
        public byte[] SelectedImage
        {
            get { return _selectedImage; }
            set { Set(ref _selectedImage, value); }
        }
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

        public string EmailText
        {
            get { return _emailText; }
            set { Set(ref _emailText, value); }
        }

        public string MembershipText
        {
            get { return _membershipText; }
            set { Set(ref _membershipText, value); }
        }


        public RegistrationViewModel(IMessenger messenger, INavigationService navigationService, DataService dataService, TrendyolDbContext dbContext, RegistrationService registrationService)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;
            _dbContext = dbContext;
            _registrationService = registrationService;
        }


        public RelayCommand Registration_Button => new(() =>
        {
            if (SelectedImage != null)
            {
                string validationMessage = _registrationService.ValidateInput(NameText, SurnameText, LoginText, PasswordText, EmailText, "User", SelectedImage);
                if (string.IsNullOrEmpty(validationMessage))
                {
                    _registrationService.RegistrationUser(NameText, SurnameText, LoginText, PasswordText, EmailText, "User", SelectedImage);
                    NameText = "";
                    SurnameText = "";
                    LoginText = "";
                    EmailText = "";
                    PasswordText = "";
                    SelectedImage = null;
                    _navigationService.NavigateTo<LoginViewModel>();
                }
                else
                {
                    MessageBox.Show(validationMessage);
                }
            }
            else
            {
                MessageBox.Show("Select Image");
            }

        });


        public RelayCommand BrowseImage => new(() =>
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                SelectedImage = File.ReadAllBytes(openFileDialog.FileName);
            }
        });


        public RelayCommand Back_Button => new(() =>
        {
            NameText = "";
            SurnameText = "";
            LoginText = "";
            EmailText = "";
            PasswordText = "";
            SelectedImage = null;

            _navigationService.NavigateTo<LoginViewModel>();
        });
    }
}


