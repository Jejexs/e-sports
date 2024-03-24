using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;

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

            // Définir la source de données de la ListView sur la liste des joueurs
            lstJoueurs.ItemsSource = App.Joueurs;
        }

        private void OnJoueurSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            // Désélectionner l'élément
            ((ListView)sender).SelectedItem = null;
        }
    }
}