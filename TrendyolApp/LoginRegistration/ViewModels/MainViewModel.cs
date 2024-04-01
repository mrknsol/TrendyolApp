using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Views;
using System.Windows.Controls;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;
using TrendyolApp.Models;
using GalaSoft.MvvmLight.Command;
using TrendyolApp.Messages;

namespace TrendyolApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentView;
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;

        public ViewModelBase CurrentView
        {
            get => _currentView;
            set
            {
                Set(ref _currentView, value);
            }
        }

        public MainViewModel(IMessenger messenger, INavigationService navigationService, DataService dataService)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;
            CurrentView = App.Container.GetInstance<LoginViewModel>();


            _messenger.Register<NavigationMessage>(this, message =>
            {
                if (message != null)
                {
                    CurrentView = message.ViewModelType;
                }
            });
        }
    }
}
