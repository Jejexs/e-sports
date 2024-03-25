using EScoreMAUI.Entity;
using Microsoft.Maui.Controls;
using EScoreMAUI.ViewModels;
using EScoreMAUI.ViewModels;

namespace EScoreMAUI.Pages
{
    public partial class ConsultationJoueursPage : ContentPage
    {
        // Définir une instance de JoueursViewModel pour le contexte de liaison
        JoueursViewModel viewModel;

        public ConsultationJoueursPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Rafraîchir la source de données de la ListView sur la liste des Equipes
            RefreshJoueursList();
        }

        // Méthode pour rafraîchir la liste des équipes
        private void RefreshJoueursList()
        {
            lstJoueurs.ItemsSource = App.Joueurs;
        }
        
        // Méthode appelée lors du clic sur le bouton "Editer"
        private async void OnEditerJoueurClicked(object sender, EventArgs e)
        {
            // Récupérer le joueur sélectionné à partir du paramètre de commande
            Joueur joueur = (sender as Button)?.CommandParameter as Joueur;

            if (joueur != null)
            {
                // Naviguer vers la page d'édition du joueur
                //await Navigation.PushAsync(new EditerJoueurPage(joueur));
            }
        }
    }
}