using System;
using EScoreMAUI.Entity;
using EScoreMAUI.Views;
using Microsoft.Maui.Controls;

namespace EScoreMAUI.Views
{
    public partial class AdminViewJoueurs : ContentPage
    {
        public AdminViewJoueurs()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            RefreshJoueursList();
        }

        private void RefreshJoueursList()
        {
            if (App.Joueurs != null)
            {
                lstJoueurs.ItemsSource = App.Joueurs;
            }
            else
            {
                Console.WriteLine("La liste des joueurs est vide ou nulle.");
            }
        }

        private async void OnEditerJoueurClicked(object sender, EventArgs e)
        {
            Joueur joueur = (sender as Button)?.CommandParameter as Joueur;

            if (joueur != null)
            {
                await Navigation.PushAsync(new EditerJoueurPage(joueur));
            }
        }
    }
}