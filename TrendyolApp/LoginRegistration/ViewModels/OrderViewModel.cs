using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using TrendyolApp.Messages;
using TrendyolApp.Models;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;

namespace TrendyolApp.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        public TrendyolDbContext _dbContext;

        public List<Orders> OrderList { get; set; }
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        public Goods _selectedProduct;
        private ViewModelBase _currentView;
        public int _productCount = 0;
        public ObservableCollection<Goods> Goods { get; set; }

        public User CurrentUser { get; set; } = new();
        public Goods CurrentProduct { get; set; } = new();


        public ViewModelBase CurrentView
        {
            get => _currentView;
            set
            {
                Set(ref _currentView, value);
            }
        }

        public int ProductCount
        {
            get { return _productCount; }
            set { Set(ref _productCount, value); }
        }

        public Goods SelectedProduct
        {
            get { return _selectedProduct; }
            set { Set(ref _selectedProduct, value); }
        }

        public OrderViewModel(IMessenger messenger, INavigationService navigationService, DataService dataService, TrendyolDbContext dbcontext)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;
            _dbContext = dbcontext;

            OrderList = _dbContext.Orders.ToList();

            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as Goods != null)
                    CurrentProduct = message.Data as Goods;

                Goods = new ObservableCollection<Goods>(_dbContext.Goods.Where(o => o.ProductType == CurrentProduct.ProductType &&
                                                                                        o.Description != CurrentProduct.Description));
            });



            messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as User != null)
                {
                    CurrentUser = message.Data as User;
                }
            });

        }

        public RelayCommand Buy_Button => new(() =>
        {
            var wareHouseItem = _dbContext.WareHouses.FirstOrDefault(item => item.GoodsId == CurrentProduct.Id);
            if (wareHouseItem != null)
            {

                if (ProductCount >= wareHouseItem.Count)
                {
                    MessageBox.Show("This Product Was Out of Stocks");
                    ProductCount = 0;

                }
                else
                {

                    wareHouseItem.Count -= ProductCount;
                    if (wareHouseItem.Count < 0)
                    {
                        MessageBox.Show("Not Enought Products!! Try Again Later");
                    }
                    else
                    {
                        _dbContext.SaveChanges();
                        if (ProductCount <= 0)
                        {
                            MessageBox.Show("Product Count Can't be 0");
                        }
                        else
                        {
                            var price = CurrentProduct.Price;
                            var newOrder = new Orders
                            {
                                UserId = CurrentUser.Id,
                                GoodsId = CurrentProduct.Id,
                                Status = "Order Placed",
                                GoodsCount = ProductCount
                            };
                            _dataService.SendData(newOrder);

                            price *= ProductCount;
                            if (CurrentUser.Balance <= price)
                            {
                                MessageBox.Show($"Not Enought Money To Buy {CurrentProduct.Name} {CurrentProduct.Description}");
                            }
                            else
                            {
                                CurrentUser.Balance -= price;
                                _dbContext.Orders.Add(newOrder);
                                _dbContext.SaveChanges();
                                _dataService.SendData(CurrentUser);
                            }
                        
                    
                        }
                    }
                }
            }
            ProductCount = 0;
            _navigationService.NavigateTo<UserViewModel>();
        });

        public RelayCommand<string> IncreaseDecreaseCount => new((function) =>
        {
            if (function == "Increase")
            {
                ProductCount += 1;
            }
            else if (function == "Decrease")
            {
                if (ProductCount > 0)
                {
                    ProductCount -= 1;
                }
                else
                {
                    MessageBox.Show("Can't Decrease!!");
                }
            }
        });
        

        public RelayCommand Back_Button => new(() =>
        {
            _navigationService.NavigateTo<UserViewModel>();
        });

    }
}

