using Microsoft.Maui.Controls;
using System;
using EScoreMAUI.Entity;

namespace EScoreMAUI.Pages
{
    public partial class EditerEquipePage : ContentPage
    {
        private Equipe equipe;

        public EditerEquipePage(Equipe equipe)
        {
            InitializeComponent();
            this.equipe = equipe;

            // Afficher le nom de l'équipe dans le champ de saisie
            NomEquipeEntry.Text = equipe.Nom;
        }

        private async void OnEnregistrerEquipeClicked(object sender, EventArgs e)
        {
            // Mettre à jour le nom de l'équipe avec la valeur saisie
            equipe.Nom = NomEquipeEntry.Text;

            // Exemple : Afficher un message de succès
            await DisplayAlert("Succès", "Équipe modifiée avec succès", "OK");

            // Naviguer vers la page de consultation des équipes
            await Navigation.PopAsync();
        }

        private async void OnSupprimerEquipeClicked(object sender, EventArgs e)
        {
            // Afficher une alerte de confirmation avant de supprimer l'équipe
            bool result = await DisplayAlert("Confirmation", "Êtes-vous sûr de vouloir supprimer cette équipe ?", "Oui", "Non");

            if (result)
            {
                // Supprimer l'équipe de la liste
                App.Equipes.Remove(equipe);

                // Exemple : Afficher un message de succès
                await DisplayAlert("Succès", "Équipe supprimée avec succès", "OK");

                // Naviguer vers la page de consultation des équipes
                await Navigation.PopAsync();
            }
        }
    }
}