using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight.Messaging;
using TrendyolApp.Services.Interfaces;

namespace TrendyolApp.Services.Classes
{
    public class EmailVerificationService
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;

        public EmailVerificationService(IMessenger messenger, INavigationService navigationService, DataService dataService)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;

        }

        
    }
}
