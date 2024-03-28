using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EScoreMAUI.Entity;
using EScoreMAUI.Entity.Statistiques;
using EScoreMAUI;
using EScoreMAUI.Views;
using EScoreMAUI.ViewModels;

namespace EScoreMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
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

        // Méthode pour gérer le clic sur le bouton de la consultation du classement
        private async void OnConsultationClassementClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConsultationClassementPage());
        }

        // Méthode pour gérer le clic sur le bouton de la consultation des joueurs
        private async void OnVoirLesJoueursClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConsultationJoueursPage());
        }

        // Méthode pour gérer le clic sur le bouton de la consultation des équipes
        private async void OnVoirLesEquipesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConsultationEquipesPage());
        }

        // Méthode pour gérer le clic sur le bouton de la consultation des parties
        private async void OnVoirLesPartiesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConsultationPartiesPage());
        }
    }
}
