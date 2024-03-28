using Microsoft.Maui.Controls;
using System;
using EScoreMAUI.Entity;

namespace EScoreMAUI.Views
{
    public partial class EditerJoueurPage : ContentPage
    {
        private Joueur joueur;

        public EditerJoueurPage(Joueur joueur)
        {
            InitializeComponent();
            this.joueur = joueur;

            NomJoueurEntry.Text = joueur.Nom;
        }

        private async void OnEnregistrerJoueurClicked(object sender, EventArgs e)
        {
            joueur.Nom = NomJoueurEntry.Text;

            await DisplayAlert("Succès", "Équipe modifiée avec succès", "OK");

            await Navigation.PopAsync();
        }

        private async void OnSupprimerJoueurClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Confirmation", "Êtes-vous sûr de vouloir supprimer cette équipe ?", "Oui", "Non");

            if (result)
            {
                App.Joueurs.Remove(joueur);

                await DisplayAlert("Succès", "Équipe supprimée avec succès", "OK");

                await Navigation.PopAsync();
            }
        }
    }
}