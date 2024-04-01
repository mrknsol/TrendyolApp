using GalaSoft.MvvmLight.Messaging;
using TrendyolApp.Messages;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;
using TrendyolApp.ViewModels;
using TrendyolApp.Views;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using TrendyolApp.Models;
using TrendyolApp.Services;

namespace TrendyolApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; } = new();

        public void Register()
        {
            Container.RegisterSingleton<EmailVerificationViewModel>();
            Container.RegisterSingleton<RegistrationViewModel>();
            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<LoginViewModel>();
            Container.RegisterSingleton<ForgotPasswordViewModel>();
            Container.RegisterSingleton<OrderViewModel>();
            Container.RegisterSingleton<UserViewModel>();
            Container.RegisterSingleton<SuperAdminViewModel>();
            Container.RegisterSingleton<AdminViewModel>();
            Container.RegisterSingleton<User>();
            Container.RegisterSingleton<Orders>();
            Container.RegisterSingleton<WareHouse>();
            Container.RegisterSingleton<Goods>();
            Container.RegisterSingleton<AddGoodsViewModel>();
            Container.RegisterSingleton<OrderHistoryViewModel>();
            Container.RegisterSingleton<IncreaseBalanceViewModel>();
            Container.RegisterSingleton<UserInfoViewModel>();
            Container.RegisterSingleton<CreateUserViewModel>();



            Container.RegisterSingleton<INavigationService, NavigationService>();

            Container.RegisterSingleton<EmailVerificationService>();
            Container.RegisterSingleton<AddGoodsService>();
            Container.RegisterSingleton<RegistrationService>();
            Container.RegisterSingleton<AddGoodsView>();
            Container.RegisterSingleton<UserService>();
            Container.RegisterSingleton<AdminService>();
            Container.RegisterSingleton<ForgotPasswordService>();
            Container.RegisterSingleton<LoginService>();
            Container.RegisterSingleton<DataMessage>();
            Container.RegisterSingleton<Login>();
            Container.RegisterSingleton<MainWindow>();
            Container.RegisterSingleton<AdminView>();
            Container.RegisterSingleton<SuperAdminView>();
            Container.RegisterSingleton<UserView>();
            Container.RegisterSingleton<OrderView>();
            Container.RegisterSingleton<DatasMessage>();
            Container.RegisterSingleton<DataService>();
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<TrendyolDbContext>();
            Container.RegisterSingleton<LikedProductService>();
            Container.RegisterSingleton<LikedProductViewModel>();
            Container.RegisterSingleton<LikedProductsView>();
            

            Container.Verify();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();

            var window = App.Container.GetInstance<MainWindow>();
            window.DataContext = Container.GetInstance<MainViewModel>();


            window.ShowDialog();

        }
    }
}
