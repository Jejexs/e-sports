using EScoreMAUI.Views;
using EScoreMAUI.Views.Administrateur.ListeJoueur;
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
            Routing.RegisterRoute("ConsultationJoueursPage", typeof(ConsultationJoueursPage)); 
            Routing.RegisterRoute("EditerJoueurPage", typeof(EditerJoueurPage));
        }

    }

}
