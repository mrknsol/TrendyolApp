using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using TrendyolApp.Models;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;

namespace TrendyolApp.ViewModels
{
    public class AddGoodsViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        private readonly TrendyolDbContext _dbcontext;
        public readonly AddGoodsService _addGoodsService = new();
        public string _productNameText = "";
        public string _productDescriptionText = "";
        public string _productTypeText = "";
        public int _productPriceText = 0;
        public int _productCountText = 0;


        public string ProductNameText
        {
            get { return _productNameText; }
            set { Set(ref _productNameText, value); }
        }

        public string ProductDescriptionText
        {
            get { return _productDescriptionText; }
            set { Set(ref _productDescriptionText, value); }
        }

        public string ProductTypeText
        {
            get { return _productTypeText; }
            set { Set(ref _productTypeText, value); }
        }

        public int ProductPriceText
        {
            get { return _productPriceText; }
            set { Set(ref _productPriceText, value); }
        }

        public int ProductCountText
        {
            get { return _productCountText; }
            set { Set(ref _productCountText, value); }
        }

        private byte[] _selectedImage;
        public byte[] SelectedImage
        {
            get { return _selectedImage; }
            set { Set(ref _selectedImage, value); }
        }


        public AddGoodsViewModel(IMessenger messenger, INavigationService navigationService, DataService dataService, TrendyolDbContext dbcontext)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;
            _dbcontext = dbcontext;
        }


        public RelayCommand BrowseImage => new(() =>
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                SelectedImage = File.ReadAllBytes(openFileDialog.FileName);
            }
        });


        public RelayCommand AddOrder => new(() =>
        {
            if (SelectedImage != null && _addGoodsService.ValidateFields(ProductNameText, ProductDescriptionText, ProductTypeText, ProductPriceText, ProductCountText))
            {
                var newGoods = _addGoodsService.AddProductOrder(ProductNameText, ProductDescriptionText, ProductTypeText, ProductPriceText, SelectedImage);

                _dbcontext.Goods.Add(newGoods);
                _dataService.SendData(newGoods);
                _dbcontext.SaveChanges();

                WareHouse newWareHouseItem = new WareHouse
                {
                    GoodsId = newGoods.Id,
                    Count = ProductCountText
                };

                _dbcontext.WareHouses.Add(newWareHouseItem);
                _dbcontext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Fields Must Be Filled In");
            }


            ProductNameText = "";
            ProductDescriptionText = "";
            ProductTypeText = "";
            ProductPriceText = 0;
            ProductCountText = 0;
            ProductCountText = 0;
            SelectedImage = null;
        });


        public RelayCommand Back_Button => new(() =>
        {
            ProductNameText = "";
            ProductDescriptionText = "";
            ProductTypeText = "";
            ProductPriceText = 0;
            ProductCountText = 0;
            ProductCountText = 0;
            SelectedImage = null;
            _navigationService.NavigateTo<AdminViewModel>();
        });


    }
}
