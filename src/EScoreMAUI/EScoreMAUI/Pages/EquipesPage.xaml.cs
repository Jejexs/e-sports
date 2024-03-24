using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using EScoreMAUI.Entity;


namespace EScoreMAUI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EquipesPage : ContentPage
    {
        public EquipesPage()
        {
            InitializeComponent();
        }

        private void OnEquipeSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedEquipe = e.SelectedItem as Equipe;
            // Faire quelque chose avec l'équipe sélectionnée, par exemple navigation vers une autre page
            // Navigation.PushAsync(new DetailsEquipePage(selectedEquipe));

            // Désélectionner l'élément
            ((ListView)sender).SelectedItem = null;
        }
        
        // ConsultationEquipesPage
    }
}