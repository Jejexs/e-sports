using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using EScoreMAUI.ViewModels;

namespace EScoreMAUI.Views
{
    public partial class ConsultationStatistiquesPage : ContentPage
    {
        private readonly StatistiquesViewModel viewModel;
        
        public ConsultationStatistiquesPage(Partie partie, Equipe equipe1, Equipe equipe2)
        {
            InitializeComponent();
            viewModel = new StatistiquesViewModel(partie, equipe1, equipe2);
            BindingContext = viewModel;
            viewModel.AfficherInformationsPartie(partie);
        }
    }
}