using System;
using System.Collections.Generic;
using DogApp.ViewModels;
using Xamarin.Forms;

namespace DogApp.Views
{
    public partial class DogInformationPage : ContentPage
    {
        private readonly DogInformationPageViewModel _viewModel;

        public DogInformationPage()
        {
            InitializeComponent();
            _viewModel = new DogInformationPageViewModel();
            BindingContext = _viewModel;
        }

        protected async void OnEditButtonClicked(object sender, ClickedEventArgs args)
        {
            // TODO: Navigate to edit page once it has been created
            return;
        }
    }
}
