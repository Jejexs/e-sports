using Microsoft.Maui.Controls;

namespace EScoreMAUI.Views
{
    public partial class UtilisateursPage : ContentPage
    {
        public UtilisateursPage()
        {
            InitializeComponent();
        }

        private async void OnClassementClickedUtilisateur(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("classement");
        }
    }
}
