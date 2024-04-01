using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight.Messaging;
using TrendyolApp.Services.Classes;
using TrendyolApp.Services.Interfaces;
using TrendyolApp.Messages;
using GalaSoft.MvvmLight;
using Microsoft.EntityFrameworkCore.Query;
using GalaSoft.MvvmLight.Command;

namespace TrendyolApp.ViewModels
{
    public class EmailVerificationViewModel : ViewModelBase
    {
        public string verificationCode = "";
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly DataService _dataService;
        public string _currentText = "";
        public string _enteredCode = "";
        public string EmailToReset = "";

        public string CurrentText
        {
            get { return _currentText; }
            set { Set(ref _currentText, value); }
        }

        public string EnteredCode
        {
            get { return _enteredCode; }
            set { Set(ref _enteredCode, value); }
        }

        public EmailVerificationViewModel(IMessenger messenger, INavigationService navigationService, DataService dataService)
        {
            _messenger = messenger;
            _navigationService = navigationService;
            _dataService = dataService;

        }
       

        public RelayCommand SendVerificationCode_Button => new(() =>
        {
            string recipientEmail = CurrentText;
            

            if (string.IsNullOrWhiteSpace(recipientEmail) || !recipientEmail.Contains("@"))
            {
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Random random = new Random();
            verificationCode = random.Next(100000, 999999).ToString();

            string subject = "Verification Code";
            string body = $"Your verification code is: { verificationCode}";

            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "kenanmemmedli055@gmail.com";
            string smtpPassword = "kyzzvqbmlbdndgrh";

            SmtpClient client = new SmtpClient(smtpServer, smtpPort);
            client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
            client.EnableSsl = true;

            MailMessage mail = new MailMessage(smtpUsername, recipientEmail, subject, body);

            try
            {
                client.Send(mail);
                MessageBox.Show("Verification code has been sent to your email.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending verification code: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        });

        public RelayCommand VerifyCode_Button => new(() =>
        {
            string enteredCode = EnteredCode;

            if (enteredCode == verificationCode)
            {
                EmailToReset = CurrentText;
                _dataService.SendData(EmailToReset);
                _navigationService.NavigateTo<ForgotPasswordViewModel>();

            }
            else
            {
                MessageBox.Show("Incorrect verification code. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        });

       
        public RelayCommand Back_Button => new(() =>
        {
            _navigationService.NavigateTo<LoginViewModel>();
        });
    }
}
