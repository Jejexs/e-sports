using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;

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
            lstEquipes.ItemsSource = App.Equipes;
        }

        // Gestionnaire d'événements pour le clic sur le bouton "Editer"
        private async void OnEditerEquipeClicked(object sender, EventArgs e)
        {
            // Récupérer l'équipe sélectionnée à partir du paramètre de commande
            Equipe equipe = (sender as Button)?.CommandParameter as Equipe;

            if (equipe != null)
            {
                // Naviguer vers la page d'édition de l'équipe
                await Navigation.PushAsync(new EditerEquipePage(equipe));
            }
        }
    }
}