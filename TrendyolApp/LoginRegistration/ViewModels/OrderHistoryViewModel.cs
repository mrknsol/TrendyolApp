using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TrendyolApp.Messages;
using TrendyolApp.Models;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;

namespace TrendyolApp.ViewModels
{
    public class OrderHistoryViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        public readonly TrendyolDbContext _dbContext;
        private ViewModelBase _currentView;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        public ObservableCollection<Orders> _orders;
        public User CurrentUser { get; set; } = new();



        public ViewModelBase CurrentView
        {
            get => _currentView;
            set
            {
                Set(ref _currentView, value);
            }
        }

        public ObservableCollection<Orders> Orders
        {
            get { return _orders; }
            set { Set(ref _orders, value); }
        }


        public OrderHistoryViewModel(IMessenger messenger, TrendyolDbContext dbContext, INavigationService navigationService, DataService dataService)
        {
            _messenger = messenger;
            _dbContext = dbContext;
            _navigationService = navigationService;
            _dataService = dataService;
            messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as User != null)
                {
                    CurrentUser = message.Data as User;
                    Orders = new ObservableCollection<Orders>(_dbContext.Orders
                        .Include(oi => oi.Goods)
                        .Where(o => o.UserId == CurrentUser.Id));
                }
            });
        }

        public RelayCommand Back_Button => new(() =>
        {
            _navigationService.NavigateTo<UserViewModel>();
        });
    }
}
