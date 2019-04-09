﻿using Prism.Mvvm;

namespace XamarinPrismDryIocSetup
{
    public class MainViewModel : BindableBase
    {
        private string _welcomeMessage;
        public string WelcomeMessage
        {
            get => _welcomeMessage;
            set => SetProperty(ref _welcomeMessage, value);
        }

        public MainViewModel()
        {
            WelcomeMessage = "Welcome to Xamarin.Forms with Prism!";
        }
    }
}
