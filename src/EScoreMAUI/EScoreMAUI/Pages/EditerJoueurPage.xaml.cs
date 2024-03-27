using Microsoft.Maui.Controls;
using System;
using EScoreMAUI.Entity;

namespace EScoreMAUI.Pages
{
    public partial class EditerJoueurPage : ContentPage
    {
        private Joueur joueur;

        public EditerJoueurPage(Joueur joueur)
        {
            InitializeComponent();
            this.joueur = joueur;

            // Afficher le nom de l'équipe dans le champ de saisie
            NomJoueurEntry.Text = joueur.Nom;
        }

        private async void OnEnregistrerJoueurClicked(object sender, EventArgs e)
        {
            // Mettre à jour le nom de l'équipe avec la valeur saisie
            joueur.Nom = NomJoueurEntry.Text;

            // Exemple : Afficher un message de succès
            await DisplayAlert("Succès", "Équipe modifiée avec succès", "OK");

            // Naviguer vers la page de consultation des équipes
            await Navigation.PopAsync();
        }

        private async void OnSupprimerJoueurClicked(object sender, EventArgs e)
        {
            // Afficher une alerte de confirmation avant de supprimer l'équipe
            bool result = await DisplayAlert("Confirmation", "Êtes-vous sûr de vouloir supprimer cette équipe ?", "Oui", "Non");

            if (result)
            {
                // Supprimer l'équipe de la liste
                App.Joueurs.Remove(joueur);

                // Exemple : Afficher un message de succès
                await DisplayAlert("Succès", "Équipe supprimée avec succès", "OK");

                // Naviguer vers la page de consultation des équipes
                await Navigation.PopAsync();
            }
        }
    }
}