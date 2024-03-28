using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EScoreMAUI.Views
{
    public partial class ConsultationJoueursPage : ContentPage
    {
        public ConsultationJoueursPage()
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