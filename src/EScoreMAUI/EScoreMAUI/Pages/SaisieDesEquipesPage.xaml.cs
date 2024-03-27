using Microsoft.Maui.Controls;
using System;
using EScoreMAUI.ViewModels;

namespace EScoreMAUI.Pages
{
    public partial class SaisieDesEquipesPage : ContentPage
    {
        public EquipesViewModel viewModel;

        public SaisieDesEquipesPage()
        {
            InitializeComponent();

            // Initialiser le ViewModel des équipes
            viewModel = new EquipesViewModel();
            this.BindingContext = viewModel;
        }

        private void OnAjouterEquipeClicked(object sender, EventArgs e)
        {
            string nomEquipe = NomEquipeEntry.Text;

            if (!string.IsNullOrEmpty(nomEquipe))
            {
                // Appeler la méthode AjouterEquipe du ViewModel avec le nom de l'équipe
                viewModel.AjouterEquipeCommand.Execute(nomEquipe);

                DisplayAlert("Succès", "L'équipe a été ajoutée avec succès", "OK");
            }
            else
            {
                // Afficher un message d'erreur si le nom de l'équipe est vide
                DisplayAlert("Erreur", "Veuillez saisir le nom de l'équipe", "OK");
            }
        }
    }
}