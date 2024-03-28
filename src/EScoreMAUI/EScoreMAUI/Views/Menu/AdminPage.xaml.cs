using Microsoft.Maui.Controls;

namespace EScoreMAUI.Views
{
    public partial class AdminPage : ContentPage
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private async void SaisieJoueurs(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SaisieDesJoueursPage");
        }

        private async void SaisieEquipes(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SaisieDesEquipesPage");
        }

        private async void SaisieDesParties(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SaisieDesPartiesPage");
        }

        private async void ConsultationEquipesPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ConsultationEquipesPage");
        }

        private async void EditerEquipePage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("EditerEquipePage");
        }

        private async void ConsultationJoueursPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ConsultationJoueursPage"); 
        }

        private async void EditerJoueurPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("EditerJoueurPage"); 
        }




    }
}
