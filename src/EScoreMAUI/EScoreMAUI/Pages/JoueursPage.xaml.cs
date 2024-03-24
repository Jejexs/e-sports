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
    public partial class JoueursPage : ContentPage
    {
        public JoueursPage()
        {
            InitializeComponent();
        }

        private void OnJoueurSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedJoueur = e.SelectedItem as Joueur;
            // Faire quelque chose avec le joueur sélectionné, par exemple navigation vers une autre page
            // Navigation.PushAsync(new DetailsJoueurPage(selectedJoueur));

            // Désélectionner l'élément
            ((ListView)sender).SelectedItem = null;
        }
    }
}