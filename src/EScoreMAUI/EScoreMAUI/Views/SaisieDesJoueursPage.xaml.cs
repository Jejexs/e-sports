using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using System;
using EScoreMAUI.ViewModels;

namespace EScoreMAUI.Views
{
    public partial class SaisieDesJoueursPage : ContentPage
    {
        private readonly JoueursViewModel viewModel;

        public SaisieDesJoueursPage()
        {
            InitializeComponent();

            Console.WriteLine("Initialisation de la page de saisie des joueurs");

            viewModel = new JoueursViewModel();
            this.BindingContext = viewModel;
        }

        private void OnAjouterJoueurClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Clic sur le bouton Ajouter Joueur");

            string nomJoueur = NomJoueurEntry.Text;
            string prenomJoueur = PrenomJoueurEntry.Text;
            string pseudoJoueur = PseudoJoueurEntry.Text;
    
            Equipe equipeJoueur = (Equipe)EquipePicker.SelectedItem;

            if (equipeJoueur != null)
            {
                Console.WriteLine("Ajout d'un nouveau joueur : " + nomJoueur);
                
                Joueur nouveauJoueur = new Joueur
                {
                    Nom = nomJoueur,
                    Prenom = prenomJoueur,
                    Pseudo = pseudoJoueur,
                    Equipe = equipeJoueur
                };
        
                viewModel.AjouterJoueurCommand.Execute(nouveauJoueur);
                Console.WriteLine("Joueur ajouté avec succès : " + nomJoueur);
                
                DisplayAlert("Succès", "Joueur ajouté avec succès", "OK");
            }
            else
            {
                Console.WriteLine("Aucune équipe sélectionnée. Affichage d'une alerte.");
                DisplayAlert("Erreur", "Veuillez sélectionner une équipe", "OK");
            }
        }
    }
}