using EScoreMAUI.Entity;
using EScoreMAUI.ViewModels;
using Microsoft.Maui.Controls;
using System;

namespace EScoreMAUI.Pages
{
    public partial class SaisieDesJoueursPage : ContentPage
    {
        // Instance du ViewModel des joueurs
        private readonly JoueursViewModel joueursViewModel;

        public SaisieDesJoueursPage()
        {
            InitializeComponent();

            // Initialisation du ViewModel des joueurs
            joueursViewModel = new JoueursViewModel();

            // Définition du contexte de liaison
            BindingContext = joueursViewModel;

            // Assigner les équipes disponibles au Picker
            EquipePicker.ItemsSource = joueursViewModel.EquipesDisponibles;
        }

        // Gestionnaire d'événements pour le clic sur le bouton "Ajouter Joueur"
        private void OnAjouterJoueurClicked(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs de saisie
            string nom = NomEntry.Text;
            string prenom = PrenomEntry.Text;
            string pseudo = PseudoEntry.Text;
            // Récupérer l'équipe sélectionnée dans le Picker
            Equipe equipe = EquipePicker.SelectedItem as Equipe;

            // Créer un nouvel objet Joueur avec les valeurs saisies
            Joueur nouveauJoueur = new Joueur { Nom = nom, Prenom = prenom, Pseudo = pseudo, Equipe = equipe?.Nom };

            // Ajouter le nouveau joueur via le ViewModel
            joueursViewModel.AjouterJoueurCommand.Execute(nouveauJoueur);

            // Exemple : Afficher un message de succès
            DisplayAlert("Succès", "Joueur ajouté avec succès", "OK");
        }
    }
}