using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using EScoreMAUI.Entity;
using EScoreMAUI;
using EScoreMAUI.ViewModels;

namespace EScoreMAUI.Pages
{
    public partial class SaisieDesEquipesPage : ContentPage
    {
        public SaisieDesEquipesPage()
        {
            InitializeComponent();
        }

        private void OnAjouterEquipeClicked(object sender, EventArgs e)
        {
            // Récupérer le nom de l'équipe à partir de l'Entry
            string nomEquipe = NomEquipeEntry.Text;

            // Créer une nouvelle équipe avec le nom saisi
            Equipe nouvelleEquipe = new Equipe { Nom = nomEquipe };

            // Ajouter la nouvelle équipe à la liste globale d'équipes
            App.Equipes.Add(nouvelleEquipe);

            // Afficher un message de succès
            DisplayAlert("Succès", "Équipe ajoutée avec succès", "OK");
        }
    }
}