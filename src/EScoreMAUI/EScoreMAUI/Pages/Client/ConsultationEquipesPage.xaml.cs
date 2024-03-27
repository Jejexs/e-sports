using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EScoreMAUI.Pages
{
    public partial class ConsultationEquipesPage : ContentPage
    {
        public ConsultationEquipesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Rafraîchir la source de données de la ListView sur la liste des Equipes
            RefreshEquipesList();
        }

        // Méthode pour rafraîchir la liste des équipes
        private void RefreshEquipesList()
        {
            // Assurez-vous que la liste des équipes n'est pas nulle
            if (App.Equipes != null)
            {
                // Affecter la liste des équipes à la source de données de la ListView
                lstEquipes.ItemsSource = App.Equipes;
            }
            else
            {
                // Afficher un message d'erreur si la liste des équipes est nulle
                Console.WriteLine("La liste des équipes est vide ou nulle.");
            }
        }

        // Gestionnaire d'événements pour le clic sur le bouton "Editer"
        private async void OnEditerEquipeClicked(object sender, EventArgs e)
        {
            // Récupérer l'équipe sélectionnée à partir du paramètre de commande
            Equipe equipe = (sender as Button)?.CommandParameter as Equipe;

            if (equipe != null)
            {
                // Naviguer vers la page d'édition de l'équipe en passant l'équipe en paramètre
                await Navigation.PushAsync(new EditerEquipePage(equipe));
            }
        }
    }
}