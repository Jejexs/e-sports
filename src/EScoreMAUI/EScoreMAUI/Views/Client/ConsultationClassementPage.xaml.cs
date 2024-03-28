using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using System;
using System.Collections.ObjectModel;

namespace EScoreMAUI.Views
{
    public partial class ConsultationClassementPage : ContentPage
    {
        public ConsultationClassementPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            RefreshClassementList();
        }

        private void RefreshClassementList()
        {
            if (App.Equipes != null)
            {
                var orderedTeams = App.Equipes.OrderByDescending(t => t.Points);

                ClassementListView.ItemsSource = orderedTeams;
            }
            else
            {
                Console.WriteLine("La liste des équipes est vide ou nulle.");
            }
        }
    }
}