using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EScoreMAUI.Entity;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace EScoreMAUI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PartiesPage : ContentPage
    {
        public PartiesPage()
        {
            InitializeComponent();
        }

        private void OnPartieSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedPartie = e.SelectedItem as Partie;
            // Faire quelque chose avec la partie sélectionnée, par exemple navigation vers une autre page
            // Navigation.PushAsync(new DetailsPartiePage(selectedPartie));

            // Désélectionner l'élément
            ((ListView)sender).SelectedItem = null;
        }
    }
}