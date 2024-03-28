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
            Routing.RegisterRoute("classementTeam", typeof(ClassementTeam));
            Routing.RegisterRoute("classementPlayer", typeof(ClassementPlayer)); 
            Routing.RegisterRoute("SaisieDesJoueursPage", typeof(SaisieDesJoueursPage));
            Routing.RegisterRoute("SaisieDesEquipesPage", typeof(SaisieDesEquipesPage)); 
            Routing.RegisterRoute("SaisieDesPartiesPage", typeof(SaisieDesPartiesPage));
            Routing.RegisterRoute("ConsultationEquipesPage", typeof(ConsultationEquipesPage));
            Routing.RegisterRoute("EditerEquipePage", typeof(EditerEquipePage));
            Routing.RegisterRoute("ConsultationPartiesPage", typeof(ConsultationPartiesPage)); 

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
