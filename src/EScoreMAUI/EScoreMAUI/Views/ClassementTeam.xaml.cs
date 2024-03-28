using EScoreMAUI.ViewModels;

namespace EScoreMAUI.Views
{
    public partial class ClassementTeam : ContentPage
    {
        public ClassementTeam()
        {
            InitializeComponent();
            BindingContext = new EquipesViewModel();
        }
    }
}
