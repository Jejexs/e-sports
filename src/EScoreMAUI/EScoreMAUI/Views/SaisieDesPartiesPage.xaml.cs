using Microsoft.Maui.Controls;
using EScoreMAUI.Entity;
using System;
using EScoreMAUI.ViewModels;
using System.Collections.Generic;

namespace EScoreMAUI.Views
{
    public partial class SaisieDesPartiesPage : ContentPage
    {
        private readonly PartiesViewModel viewModel;

        public SaisieDesPartiesPage()
        {
            InitializeComponent();

            viewModel = new PartiesViewModel();
            this.BindingContext = viewModel;
        }

        private void OnEnregistrerPartieClicked(object sender, EventArgs e)
        {
            DateTime date = DateEntry.Date;
            TimeSpan time = TimeEntry.Time;
            string lieu = LieuEntry.Text;
            string jeu = JeuEntry.Text;
            Equipe equipe1Selected = (Equipe)EquipePicker1.SelectedItem;
            Equipe equipe2Selected = (Equipe)EquipePicker2.SelectedItem;

            if (date == default || string.IsNullOrEmpty(lieu) || string.IsNullOrEmpty(jeu) || equipe1Selected == null || equipe2Selected == null)
            {
                DisplayAlert("Erreur", "Veuillez remplir tous les champs", "OK");
            }
            else if (equipe1Selected == equipe2Selected)
            {
                DisplayAlert("Erreur", "Les deux équipes doivent être différentes", "OK");
            }
            else
            {
                DateTime partieDate = date.Date + time;
                Partie nouvellePartie = new Partie
                {
                    Date = partieDate,
                    Lieu = lieu,
                    Jeu = jeu,
                    Equipe1 = equipe1Selected,
                    Equipe2 = equipe2Selected
                };

                viewModel.AjouterPartieCommand.Execute(nouvellePartie);
                DisplayAlert("Succès", "La partie a été enregistrée avec succès", "OK");
            }
        }
    }
}