using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using EScoreMAUI.ViewModels;
using System;

namespace EScoreMAUI.Views
{
    public partial class SaisieStatistiquesPage : ContentPage
    {
        private readonly StatistiquesViewModel viewModel;

        public SaisieStatistiquesPage(Partie partie, Equipe equipe1, Equipe equipe2)
        {
            InitializeComponent();
            
            if (equipe1 == null || equipe2 == null)
            {
                throw new ArgumentNullException("Les équipes ne peuvent pas être null.");
            }

            viewModel = new StatistiquesViewModel(partie, equipe1, equipe2);
            BindingContext = viewModel;

            AfficherInfos(partie.Id, equipe1, equipe2);
        }

        private void AfficherInfos(int partieId, Equipe equipe1, Equipe equipe2)
        {
            // Afficher les informations de la partie
            Console.WriteLine("Informations de la partie :");
            Console.WriteLine($"ID : {partieId}");
            // Afficher les informations de l'équipe 1
            Console.WriteLine("Informations de l'équipe 1 :");
            Console.WriteLine($"Nom : {equipe1.Nom}");
            Console.WriteLine($"ID : {equipe1.Id}");
            // Afficher les informations de l'équipe 2
            Console.WriteLine("Informations de l'équipe 2 :");
            Console.WriteLine($"Nom : {equipe2.Nom}");
            Console.WriteLine($"ID : {equipe2.Id}");
        }
        
        private void OnAddStats(object sender, EventArgs e)
        {
            if (PickerEquipeGagnante.SelectedItem != null && PickerEquipePerdante.SelectedItem != null)
            {
                Equipe equipeGagnante = (Equipe)PickerEquipeGagnante.SelectedItem;
                Equipe equipePerdante = (Equipe)PickerEquipePerdante.SelectedItem;

                viewModel.AjouterStatistiques(equipeGagnante, equipePerdante);
            }
        }
    }
}
