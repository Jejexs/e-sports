using Microsoft.Maui.Controls;
using System;
using EScoreMAUI.ViewModels;

namespace EScoreMAUI.Views
{
    public partial class SaisieDesEquipesPage : ContentPage
    {
        public EquipesViewModel viewModel;

        public SaisieDesEquipesPage()
        {
            InitializeComponent();

            viewModel = new EquipesViewModel();
            this.BindingContext = viewModel;
        }

        private void OnAjouterEquipeClicked(object sender, EventArgs e)
        {
            string nomEquipe = NomEquipeEntry.Text;

            if (!string.IsNullOrEmpty(nomEquipe))
            {
                viewModel.AjouterEquipeCommand.Execute(nomEquipe);

                DisplayAlert("Succès", "L'équipe a été ajoutée avec succès", "OK");
            }
            else
            {
                DisplayAlert("Erreur", "Veuillez saisir le nom de l'équipe", "OK");
            }
        }
    }
}