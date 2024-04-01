using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TrendyolApp.Messages;
using TrendyolApp.Models;
using TrendyolApp.Services.Interfaces;
using TrendyolApp.ViewModels;

namespace TrendyolApp.Services.Classes
{
    public class UserService
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        public TrendyolDbContext _dbcontext;
        public ObservableCollection<Goods> Goods { get; set; }

        public UserService(IMessenger messenger, INavigationService navigationService, DataService dataService, TrendyolDbContext dbcontext)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;
            _dbcontext = dbcontext;

            _messenger.Register<DataMessage>(this, message =>
            {
                Goods = message.Data as ObservableCollection<Goods>;
            });
        }
        public ObservableCollection<Goods> LoadGoodsFromDatabase()
        {
            var allGoods = _dbcontext.Goods.ToList();

            foreach (var product in allGoods)
            {
                var warehouseItem = _dbcontext.WareHouses.FirstOrDefault(w => w.GoodsId == product.Id);

                if (warehouseItem == null || warehouseItem.Count == 0)
                {
                    _dbcontext.Goods.Remove(product);
                }
            }

            _dbcontext.SaveChanges();

            return new ObservableCollection<Goods>(_dbcontext.Goods);
        }

        public void Buy(Goods SelectedProduct)
        {
            var product = Goods.FirstOrDefault(g => g.Name == SelectedProduct.Name);

            _dataService.SendData(product);

            _navigationService.NavigateTo<OrderViewModel>();
        }
    }
}
