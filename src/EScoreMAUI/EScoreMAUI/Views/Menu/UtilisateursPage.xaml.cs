using Microsoft.Maui.Controls;

namespace EScoreMAUI.Views
{
    public partial class UtilisateursPage : ContentPage
    {
        public UtilisateursPage()
        {
            InitializeComponent();
        }

        private async void ClassementPlayer(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("classementPlayer");
        }

        private async void ClassementTeam(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("classementTeam");
        }

        private async void ConsultationPartiesPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ConsultationPartiesPage");
        }

    }
}
