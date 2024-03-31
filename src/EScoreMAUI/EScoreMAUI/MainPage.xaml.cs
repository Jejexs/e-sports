using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EScoreMAUI.Entity;
using EScoreMAUI.Entity.Statistiques;
using EScoreMAUI;
using EScoreMAUI.Views;
using EScoreMAUI.ViewModels;

namespace EScoreMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void OnViewAdminClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminView());
        }

        private async void OnViewClientClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientView());
        }
    }
}
