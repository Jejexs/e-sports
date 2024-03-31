using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace EScoreMAUI.Views
{
    public partial class ClientView: ContentPage
    {
        public ClientView()
        {
            InitializeComponent();
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