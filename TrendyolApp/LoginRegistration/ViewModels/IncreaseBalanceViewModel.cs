using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TrendyolApp.Messages;
using TrendyolApp.Models;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;
using Prism.Commands;

namespace TrendyolApp.ViewModels
{
    public class IncreaseBalanceViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        public IncreaseBalanceService _balanceService = new();
        public User CurrentUser { get; set; } = new();
        public TrendyolDbContext _dbcontext;
        public string _passwordText = "";
        public int _amount = 0;
        private bool _isIncreaseBalanceEnabled = false;
        private ViewModelBase _currentView;


        public string PasswordText
        {
            get { return _passwordText; }
            set { Set(ref _passwordText, value); }
        }
        public int Amount
        {
            get { return _amount; }
            set { Set(ref _amount, value); }
        }

        public bool IsIncreaseBalanceEnabled
        {
            get { return _isIncreaseBalanceEnabled; }
            set { Set(ref _isIncreaseBalanceEnabled, value); }
        }

        public ViewModelBase CurrentView
        {
            get => _currentView;
            set
            {
                Set(ref _currentView, value);
            }
        }


        public IncreaseBalanceViewModel(IMessenger messenger, INavigationService navigationService, DataService dataService, TrendyolDbContext dbContext)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;;
            _dbcontext = dbContext;


            messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as User != null)
                {
                    CurrentUser = message.Data as User;
                }
            });
        }


        public DelegateCommand IncreaseBalance_Button => new(() =>
        {
            if (_balanceService.IncreaseBalance(CurrentUser, PasswordText, Amount))
            {
                CurrentUser.Balance += Amount;
                _dbcontext.SaveChanges();
                _dataService.SendData(CurrentUser);
                MessageBox.Show("Balance Increased");
            }
            else
            {
                MessageBox.Show("There's an error while checking Password!! Please Try Again!!");
                PasswordText = "";
            }
            _navigationService.NavigateTo<UserViewModel>();
            PasswordText = "";
            Amount = 0;
        });

        public RelayCommand<string> SelectAmount_Button => new((amount) =>
        {
            switch (amount)
            {
                case "100":
                    Amount = 100;
                    break;
                case "500":
                    Amount = 500;
                    break;
                case "1000":
                    Amount = 1000;
                    break;
                case "5000":
                    Amount = 5000;
                    break;
                case "Custom":
                    Amount = 1;
                    break;
                default:
                    break;
            }
            if (Amount > 0)
            {
                IsIncreaseBalanceEnabled = true;
            }
        });


        public RelayCommand Back_Button => new(() =>
        {
            PasswordText = "";
            Amount = 0;
            _navigationService.NavigateTo<UserViewModel>();
        });
    }
}
