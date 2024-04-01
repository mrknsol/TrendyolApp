using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    public class CreateUserViewModel : ViewModelBase
    {
        public readonly RegistrationService _registrationService;
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        public string _nameText = "";
        public string _surnameText = "";
        public string _loginText = "";
        public string _passwordText = "";
        public string _emailText = "";
        public string _membershipText = "";
        public TrendyolDbContext _dbcontext;
        public User CurrentUser { get; set; } = new();

        private byte[] _selectedImage;
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

        private string _userText = "User";
        public string UserText
        {
            get { return _userText; }
            set { Set(ref _userText, value); }
        }

        private string _adminText = "Admin";
        public string AdminText
        {
            get { return _adminText; }
            set { Set(ref _adminText, value); }
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

        public CreateUserViewModel(RegistrationService registrationService, INavigationService navigationService, DataService dataService, IMessenger messenger, TrendyolDbContext dbcontext)
        {
            _registrationService = registrationService;
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;

            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as User != null)
                {
                    CurrentUser = message.Data as User;
                }

            });
            _dbcontext = dbcontext;
        }

        public RelayCommand RegisterUser_Button => new(() =>
        {
            if (MembershipText != "" || SelectedImage != null)
            {
                _registrationService.RegistrationUser(NameText, SurnameText, LoginText, PasswordText, EmailText, MembershipText, SelectedImage);
                _dbcontext.SaveChanges();
                NameText = "";
                SurnameText = "";
                LoginText = "";
                PasswordText = "";
                EmailText = "";
                MembershipText = "";
                SelectedImage = null;
                _navigationService.NavigateTo<SuperAdminViewModel>();

            }
            else
            {
                MessageBox.Show("Please Fill All Filelds!");
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

        public RelayCommand ChangeToUserCommand => new(() =>
        {
            if (MembershipText != null)
            {
                MembershipText = "User";
                //CurrentUser.Membership = "User";
                _dbcontext.SaveChanges();
            }
        });

        public RelayCommand ChangeToAdminCommand => new(() =>
        {
            if (MembershipText != null)
            {
                MembershipText = "Admin";
                //CurrentUser.Membership = "Admin";
                _dbcontext.SaveChanges();
            }
        });

        public RelayCommand Back_Button => new(() =>
        {
            _navigationService.NavigateTo<SuperAdminViewModel>();
        });
    }
}
