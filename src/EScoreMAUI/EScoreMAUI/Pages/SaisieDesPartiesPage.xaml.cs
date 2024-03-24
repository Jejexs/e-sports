using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using System;
using System.Collections.Generic;

namespace EScoreMAUI.Pages
{
    public partial class SaisieDesPartiesPage : ContentPage
    {
        public SaisieDesPartiesPage()
        {
            InitializeComponent();
        }

        private void OnEnregistrerPartieClicked(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs de saisie
            DateTime date;
            if (!DateTime.TryParse(DateEntry.Text, out date))
            {
                // Gérer les erreurs de conversion de texte en date
                DisplayAlert("Erreur", "Date invalide", "OK");
                return;
            }

            string jeu = JeuEntry.Text;
            string equipe1 = Equipe1Entry.Text;
            string equipe2 = Equipe2Entry.Text;

            // Créer de nouvelles instances d'équipe avec les valeurs saisies
            Equipe nouvelleEquipe1 = new Equipe(0, equipe1);
            Equipe nouvelleEquipe2 = new Equipe(0, equipe2);

            // Créer un nouvel objet Partie avec les valeurs saisies
            Partie nouvellePartie = new Partie(0, date, jeu, 0)
            {
                Equipes = new List<Equipe> { nouvelleEquipe1, nouvelleEquipe2 }
            };

            // Ajouter la nouvelle partie à la liste des parties
            App.Parties.Add(nouvellePartie); // Utilisez App.Parties pour ajouter la partie

            // Exemple : Afficher un message de succès
            DisplayAlert("Succès", "Partie enregistrée avec succès", "OK");
        }
    }
}