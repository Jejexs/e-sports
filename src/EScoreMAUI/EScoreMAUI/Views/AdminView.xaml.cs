using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace EScoreMAUI.Views
{
    public partial class AdminView : ContentPage
    {
        public AdminView()
        {
            InitializeComponent();
        }

        // Méthode pour gérer le clic sur le bouton de la saisie des joueurs
        private async void OnSaisieDesJoueursClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaisieDesJoueursPage());
        }

        private async void OnSaisieDesEquipesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaisieDesEquipesPage());
        }

        // Méthode pour gérer le clic sur le bouton de la saisie des parties et statistiques
        private async void OnSaisieDesPartiesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaisieDesPartiesPage());
        }

        // Méthode pour gérer le clic sur le bouton de d'affichage des parties côté admin
        private async void OnViewAdminPartiesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminViewParties());
        }

        private async void OnViewAdminEquipesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminViewEquipes());
        }
        
        private async void OnViewAdminJoueursClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminViewJoueurs());
        }
    }
}