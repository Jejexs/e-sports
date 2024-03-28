using EScoreMAUI.ViewModels;

namespace EScoreMAUI.Views
{
    public partial class ClassementPlayer : ContentPage
    {
        public ClassementPlayer()
        {
            InitializeComponent();
            BindingContext = new JoueursViewModel();
        }
    }
}
