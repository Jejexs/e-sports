using System;
using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using EScoreMAUI.ViewModels;

namespace EScoreMAUI.Views
{
    public partial class ConsultationPartiesPage : ContentPage
    {
        public ConsultationPartiesPage()
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
        
        private async void ViewStatistiques(object sender, EventArgs e)
        {
            if (PartiesListView.SelectedItem is Partie partie)
            {
                await Navigation.PushAsync(new ConsultationStatistiquesPage(partie, partie.Equipe1, partie.Equipe2));
            }
        }
    }
}