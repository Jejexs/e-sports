using EScoreMAUI.Views;
using Microsoft.Maui.Controls;

namespace EScoreMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("home", typeof(HomePage));
            Routing.RegisterRoute(nameof(UtilisateursPage), typeof(UtilisateursPage));
            Routing.RegisterRoute(nameof(AdminPage), typeof(AdminPage));
            Routing.RegisterRoute("classement", typeof(Classement));

        }

        public async Task NavigateToUtilisateursAsync()
        {
            await GoToAsync("//utilisateurs");
        }

        public async Task NavigateToAdminAsync()
        {
            await GoToAsync("//admin");
        }

        private async void OnHomeClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//home");
        }
    }

}
