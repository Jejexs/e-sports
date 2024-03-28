using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EScoreMAUI.Views
{
    public partial class AdminViewEquipes : ContentPage
    {
        public AdminViewEquipes()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            RefreshEquipesList();
        }

        private void RefreshEquipesList()
        {
            if (App.Equipes != null)
            {
                lstEquipes.ItemsSource = App.Equipes;
            }
            else
            {
                Console.WriteLine("La liste des équipes est vide ou nulle.");
            }
        }

        private async void OnEditerEquipeClicked(object sender, EventArgs e)
        {
            Equipe equipe = (sender as Button)?.CommandParameter as Equipe;

            if (equipe != null)
            {
                await Navigation.PushAsync(new EditerEquipePage(equipe));
            }
        }
    }
}