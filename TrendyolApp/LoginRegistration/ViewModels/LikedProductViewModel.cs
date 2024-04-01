using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using TrendyolApp.Messages;
using TrendyolApp.Models;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;

namespace TrendyolApp.ViewModels
{
    public class LikedProductViewModel : ViewModelBase
    {
        public TrendyolDbContext _dbcontext;
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        public UserService _userService;
        public User CurrentUser { get; set; } = new();
        public ObservableCollection<LikedProducts> LikedProduct { get; set; }
        public Goods _selectedProduct;

        public Goods SelectedProduct
        {
            get { return _selectedProduct; }
            set { Set(ref _selectedProduct, value); }
        }

        public LikedProductViewModel(TrendyolDbContext dbContext, UserService userService, IMessenger messenger, INavigationService navigationService, DataService dataService)
        {
            _dbcontext = dbContext;
            _userService = userService;
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;

            messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as User != null)
                {
                    CurrentUser = message.Data as User;
                    LikedProduct = new ObservableCollection<LikedProducts>(_dbcontext.LikedProducts
                        .Include(oi => oi.Goods)
                        .Where(o => o.UserId == CurrentUser.Id));
                }
            });
        }

            

        //}

        //public RelayCommand Buy_Button => new(() =>
        //{

        //    _dataService.SendData(LikedProduct);
        //    _userService.Buy(SelectedProduct);
        //});

        public RelayCommand Back_Button => new(() =>
        {
            _navigationService.NavigateTo<UserViewModel>();
        });
    }
}
