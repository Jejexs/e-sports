using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using EScoreMAUI.ViewModels;
using System;

namespace EScoreMAUI.Views
{
    public partial class AdminViewParties : ContentPage
    {
        public AdminViewParties()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is PartiesViewModel viewModel)
            {
                PartiesListView.ItemsSource = viewModel.Parties;
            }
        }

        private async void SetStatistiques(object sender, EventArgs e)
        {
            if (PartiesListView.SelectedItem is Partie partie)
            {
                await Navigation.PushAsync(new SaisieStatistiquesPage(partie, partie.Equipe1, partie.Equipe2));
            }
        }

    }
}