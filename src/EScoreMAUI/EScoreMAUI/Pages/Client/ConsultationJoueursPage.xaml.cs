using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EScoreMAUI.Pages
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

            // Rafraîchir la source de données de la ListView sur la liste des Joueurs
            RefreshJoueursList();
        }

        // Méthode pour rafraîchir la liste des joueurs
        private void RefreshJoueursList()
        {
            // Assurez-vous que la liste des joueurs n'est pas nulle
            if (App.Joueurs != null)
            {
                // Affecter la liste des joueurs à la source de données de la ListView
                lstJoueurs.ItemsSource = App.Joueurs;
            }
            else
            {
                // Afficher un message d'erreur si la liste des joueurs est nulle
                Console.WriteLine("La liste des joueurs est vide ou nulle.");
            }
        }

        // Gestionnaire d'événements pour le clic sur le bouton "Editer"
        private async void OnEditerJoueurClicked(object sender, EventArgs e)
        {
            // Récupérer le joueur sélectionné à partir du paramètre de commande
            Joueur joueur = (sender as Button)?.CommandParameter as Joueur;

            if (joueur != null)
            {
                // Naviguer vers la page d'édition du joueur en passant le joueur en paramètre
                await Navigation.PushAsync(new EditerJoueurPage(joueur));
            }
        }
    }
}