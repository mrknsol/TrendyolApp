using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TrendyolApp.Messages;
using TrendyolApp.Models;
using TrendyolApp.Services;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;

namespace TrendyolApp.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        public readonly TrendyolDbContext _dbContext;
        public Goods _selectedProduct = new();
        private ViewModelBase _currentView;
        public ObservableCollection<Goods> _goods;
        public LikedProductService _likedProductService;
        public UserService _userService;

        public List<int> listOfLikedProducts = new();

        public ObservableCollection<Goods> Goods
        {
            get { return _goods; }
            set { Set(ref _goods, value) ;}
        }

        public User CurrentUser { get; set; } = new();
        public float _balance;

        public float Balance
        {
            get => _balance;
            set
            {
                Set(ref _balance, value);
            }
        }

        public ViewModelBase CurrentView
        {
            get => _currentView;
            set
            {
                Set(ref _currentView, value);
            }
        }

        public string _searchText = "";


        public string SearchText
        {
            get { return _searchText; }
            set { Set(ref _searchText, value); }

        }

        public Goods SelectedProduct
        {
            get { return _selectedProduct; }
            set { Set(ref _selectedProduct, value); }
        }
        public UserViewModel(INavigationService navigationService, IMessenger messenger, DataService dataService, TrendyolDbContext dbContext, LikedProductService likedProductService, UserService userService) { 
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;
            _dbContext = dbContext;
            _userService = userService;
            _likedProductService = likedProductService;
            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as User != null)
                {
                    CurrentUser = message.Data as User;
                    Balance = CurrentUser.Balance;
                }
                
            });
            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as Goods != null)
                {
                    var product = message.Data as Goods;
                    if (Goods.Contains(product))
                    {
                        Goods = _userService.LoadGoodsFromDatabase();
                    }
                    else
                    {
                        Goods.Add(message.Data as Goods);
                    }
                }
                Goods = _userService.LoadGoodsFromDatabase();

            });


        }

        public RelayCommand<string> ShowGoodsByType => new((name) =>
        {
            if (name == "All")
            {
                Goods = new ObservableCollection<Goods>(_dbContext.Goods);
            }
            else if (name == "Smartphones and Accessories")
            {
                Goods = new ObservableCollection<Goods>(_dbContext.Goods.Where(o => o.ProductType == "Smartphone" || o.ProductType == "Accessory"));
            }
            else if (name == "Smart Gadjets")
            {
                Goods = new ObservableCollection<Goods>(_dbContext.Goods.Where(o => o.ProductType == "Smart Gadjets"));
            }
            else if (name == "Laptops, PC, Tablets")
            {
                Goods = new ObservableCollection<Goods>(_dbContext.Goods.Where(o => o.ProductType == "Laptop" || o.ProductType == "PC" || o.ProductType == "Tablet"));
            }
            else if (name == "Gaming Devices")
            {
                Goods = new ObservableCollection<Goods>(_dbContext.Goods.Where(o => o.ProductType == "Gaming Devices"));
            }
            else if (name == "TV, Audio, Photo")
            {
                Goods = new ObservableCollection<Goods>(_dbContext.Goods.Where(o => o.ProductType == "TV" || o.ProductType == "Audio" || o.ProductType == "Photo"));
            }
            else if (name == "Kitchen Appliances")
            {
                Goods = new ObservableCollection<Goods>(_dbContext.Goods.Where(o => o.ProductType == "Kitchen Appliances"));
            }
            else if (name == "Home Appliances")
            {
                Goods = new ObservableCollection<Goods>(_dbContext.Goods.Where(o => o.ProductType == "Home Appliances"));
            }
            else if (name == "Automobile Products")
            {
                Goods = new ObservableCollection<Goods>(_dbContext.Goods.Where(o => o.ProductType == "Automobile Product"));
            }
        });

        public RelayCommand LikedProductView => new(() =>
        {
            if (listOfLikedProducts.Count != 0)
            {
                foreach (int i in listOfLikedProducts)
                {
                    LikedProducts likedProduct = new LikedProducts
                    {
                        UserId = CurrentUser.Id,
                        GoodsId = i,
                    };
                    _dbContext.LikedProducts.Add(likedProduct);
                }
                _dbContext.SaveChanges();
                MessageBox.Show("Product liked successfully.");
                _dataService.SendData(CurrentUser);
            }
            else
            {
                MessageBox.Show("Don't Selected Any Products!!");
            }
            _navigationService.NavigateTo<LikedProductViewModel>();

        });

        public RelayCommand Search => new(() =>
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                Goods = new ObservableCollection<Goods>(_dbContext.Goods);
            }
            else
            {
                Goods = new ObservableCollection<Goods>(_dbContext.Goods
                    .Where(o => o.Name.ToLower().Contains(SearchText.ToLower()) ||
                    o.Description.ToLower().Contains(SearchText.ToLower()) ||
                    o.ProductType.ToLower().Contains(SearchText.ToLower())));
            }
        });

        public RelayCommand ClearText => new(() =>
        {
            SearchText = "";
            Goods = new ObservableCollection<Goods>(_dbContext.Goods);
        });

        public RelayCommand<string> AddOrRemoveProduct => new((value) =>
        {
            if (value == "Plus")
            {
                if (!listOfLikedProducts.Contains(SelectedProduct.Id))
                {
                    listOfLikedProducts.Add(SelectedProduct.Id);
                }
                else
                {
                    MessageBox.Show("This Product already exists in Liked Products!");
                }
            }
            else if (value == "Minus")
            {
                if (listOfLikedProducts.Contains(SelectedProduct.Id))
                {
                    listOfLikedProducts.Remove(SelectedProduct.Id);
                }
                else
                {
                    MessageBox.Show("This Product does not exist in Liked Products");
                }
            }
        });

        public RelayCommand Buy_Button => new(() =>
        {
            _dataService.SendData(Goods);
            _userService.Buy(SelectedProduct);
        });

        public RelayCommand OrdersView => new(() =>
        {
            _navigationService.NavigateTo<OrderHistoryViewModel>();
        });

        public RelayCommand GoodsView => new(() =>
        {
            CurrentView = null;
        });

        public RelayCommand IncreaseBalanceView_Button => new(() =>
        {
            _navigationService.NavigateTo<IncreaseBalanceViewModel>();
        });

        public RelayCommand UserInfoView_Button => new(() =>
        {
            _navigationService.NavigateTo<UserInfoViewModel>();
        });

        public RelayCommand SignOut_Button => new(() =>
        {
            _navigationService.NavigateTo<LoginViewModel>();

        });
    }
}
