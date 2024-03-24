using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using EScoreMAUI.Entity;
using EScoreMAUI;

namespace EScoreMAUI.Pages
{
    public partial class SaisieDesJoueursPage : ContentPage
    {
        public SaisieDesJoueursPage()
        {
            InitializeComponent();
        }

        private void OnAjouterJoueurClicked(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs de saisie
            string nom = NomEntry.Text;
            string prenom = PrenomEntry.Text;
            string pseudo = PseudoEntry.Text;
            string equipe = EquipeEntry.Text;

            // Créer un nouvel objet Joueur avec les valeurs saisies
            Joueur nouveauJoueur = new Joueur { Nom = nom, Prenom = prenom, Pseudo = pseudo, Equipe = equipe };

            // Ajouter le nouveau joueur à la liste des joueurs
            App.Joueurs.Add(nouveauJoueur); // Utilisez App.Joueurs pour ajouter le joueur

            // Exemple : Afficher un message de succès
            DisplayAlert("Succès", "Joueur ajouté avec succès", "OK");
        }
    }
}