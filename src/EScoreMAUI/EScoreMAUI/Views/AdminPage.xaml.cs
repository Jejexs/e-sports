using Microsoft.Maui.Controls;

namespace EScoreMAUI.Views
{
    public partial class AdminPage : ContentPage
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private async void OnClassementClickedAdmin(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("classement");
        }
    }
}
