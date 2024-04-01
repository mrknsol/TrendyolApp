using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TrendyolApp.Messages;
using TrendyolApp.Models;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;

namespace TrendyolApp.ViewModels
{
    public class AdminViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        private readonly TrendyolDbContext _dbcontext;
        public ObservableCollection<Orders> _orders;
        private readonly AdminService _adminService;
        private RadioButtons _radioButtons;
        private Orders _selectedOrder;
        public string _searchText = "";


        public string SearchText
        {
            get { return _searchText; }
            set { Set(ref _searchText, value); }

        }

        public Orders SelectedOrder
        {
            get { return _selectedOrder; }
            set { Set(ref _selectedOrder, value); }
        }

        public ObservableCollection<Orders> Orders
        {
            get { return _orders; }
            set { Set(ref _orders, value); }
        }

        public RadioButtons RadioButton
        {
            get => _radioButtons;
            set => Set(ref _radioButtons, value);
        }


        public AdminViewModel(IMessenger messenger, INavigationService navigationService, DataService dataService, TrendyolDbContext dbcontext, AdminService adminService)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;
            _dbcontext = dbcontext;
            _adminService = adminService;
            RadioButton = new RadioButtons();

            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as Orders != null)
                    Orders.Add(message.Data as Orders);
            });

            Orders = new ObservableCollection<Orders>(_dbcontext.Orders
            .Include(o => o.Users)
            .Include(o => o.Goods)
            .ToList());
        }

        public RelayCommand Search => new(() =>
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                Orders = new ObservableCollection<Orders>(_dbcontext.Orders
                    .Include(o => o.Users)
                    .Include(o => o.Goods)
                    .ToList());
            }
            else
            {
                Orders = new ObservableCollection<Orders>(_dbcontext.Orders
                    .Include(o => o.Users)
                    .Include(o => o.Goods)
                    .Where(o => o.Users.Username.ToLower().Contains(SearchText.ToLower()) ||
                                o.Goods.Name.ToLower().Contains(SearchText.ToLower()) ||
                                o.Status.ToLower().Contains(SearchText.ToLower()))
                    .ToList());
            }
        });



        public RelayCommand AddGoods => new(() =>
        {
            _navigationService.NavigateTo<AddGoodsViewModel>();
        });

        public RelayCommand ClearText => new(() =>
        {
            SearchText = "";
            Orders = new ObservableCollection<Orders>(_dbcontext.Orders
                    .Include(o => o.Users)
                    .Include(o => o.Goods));
        });


        public RelayCommand<RadioButton> Check => new((radioButton) =>
        {
            try
            {
                if (RadioButton.InAbroadWareHouse)
                {
                    if (SelectedOrder.Status == "Order Placed" || SelectedOrder.Status == "In Abroad Warehouse")
                    {
                        radioButton.IsEnabled = true;
                        SelectedOrder.Status = "In Abroad Warehouse";
                    }
                    else
                    {
                        MessageBox.Show("Can't Change to this Status");
                        return;
                    }
                }
                else if (RadioButton.Shipped)
                {
                    if (SelectedOrder.Status == "In Abroad Warehouse" || SelectedOrder.Status == "Shipped")
                    {
                        radioButton.IsEnabled = true;
                        SelectedOrder.Status = "Shipped";
                    }
                    else
                    {
                        MessageBox.Show("Can't Change to this Status");
                        return;
                    }
                }
                else if (RadioButton.InFilial)
                {
                    if (SelectedOrder.Status == "Shipped" || SelectedOrder.Status == "In Filial")
                    {
                        radioButton.IsEnabled = true;
                        SelectedOrder.Status = "In Filial";
                    }
                    else
                    {
                        MessageBox.Show("Can't Change to this Status");
                        return;
                    }
                }
                else if (RadioButton.Ordered)
                {
                    if (SelectedOrder.Status == "In Filial" || SelectedOrder.Status == "Ordered")
                    {   
                        radioButton.IsEnabled = true;
                        SelectedOrder.Status = "Ordered";
                    }
                    else
                    {
                        MessageBox.Show("Can't Change to this Status");
                        return;
                    }
                }
                else if (RadioButton.Paid)
                {
                    if (SelectedOrder.Status == "Ordered" || SelectedOrder.Status == "Paid")
                    {
                        radioButton.IsEnabled = true;
                        SelectedOrder.Status = "Paid";
                    }
                    else
                    {
                        MessageBox.Show("Can't Change to this Status");
                        return;
                    }
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Orders = new ObservableCollection<Orders>(_dbcontext.Orders
                    .Include(o => o.Users)
                    .Include(o => o.Goods)
                    .ToList());
            _dbcontext.SaveChanges();
        });


        public RelayCommand Out_Button => new(() =>
        {
            _dbcontext.SaveChanges();
            _navigationService.NavigateTo<LoginViewModel>();
        });
    }
}
