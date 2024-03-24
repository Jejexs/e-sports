using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;

namespace EScoreMAUI.Pages
{
    public partial class ConsultationPartiesPage : ContentPage
    {
        public ConsultationPartiesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Mettre à jour la liste des parties
            PartiesListView.ItemsSource = App.Parties;
        }

        private void OnPartieSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            // Désélectionner l'élément
            ((ListView)sender).SelectedItem = null;
        }
    }
}