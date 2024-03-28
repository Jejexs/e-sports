using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using EScoreMAUI.Entity;
using Microsoft.Maui.Controls;

namespace EScoreMAUI.ViewModels
{
    public class PartiesViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Partie> Parties { get; private set; } = App.Parties;
        
        public ObservableCollection<Equipe> EquipesDisponibles { get; private set; } = App.Equipes;

        // Ajout des propriétés Equipe1 et Equipe2 pour stocker les équipes sélectionnées
        private Equipe _equipe1;
        public Equipe Equipe1
        {
            get { return _equipe1; }
            set
            {
                if (_equipe1 != value)
                {
                    _equipe1 = value;
                    OnPropertyChanged(nameof(Equipe1));
                }
            }
        }

        private Equipe _equipe2;
        public Equipe Equipe2
        {
            get { return _equipe2; }
            set
            {
                if (_equipe2 != value)
                {
                    _equipe2 = value;
                    OnPropertyChanged(nameof(Equipe2));
                }
            }
        }

        public ICommand AjouterPartieCommand { get; private set; }
        public ICommand MettreAJourPartieCommand { get; private set; }
        public ICommand SupprimerPartieCommand { get; private set; }

        public PartiesViewModel()
        {
            AjouterPartieCommand = new Command<Partie>(AjouterPartie);
            MettreAJourPartieCommand = new Command<Partie>(MettreAJourPartie);
            SupprimerPartieCommand = new Command<Partie>(SupprimerPartie);
        }

// Dans PartiesViewModel.cs
        private void AjouterPartie(Partie partie)
        {
            if (Parties == null)
            {
                Parties = new ObservableCollection<Partie>();
            }

            partie.Id = IdGenerator.GeneratePartieId();
            Parties.Add(partie);
            OnPropertyChanged(nameof(Parties));
        }

        private void MettreAJourPartie(Partie partie)
        {
            var partieExistant = Parties?.FirstOrDefault(p => p?.Id == partie?.Id);
            if (partieExistant != null)
            {
                partieExistant.Date = partie.Date;
                partieExistant.Lieu = partie.Lieu;
                partieExistant.Jeu = partie.Jeu;
        
                // Mise à jour des équipes
                partieExistant.Equipe1 = partie.Equipe1;
                partieExistant.Equipe2 = partie.Equipe2;

                partieExistant.Score = partie.Score;
                partieExistant.Statistiques = partie.Statistiques;
                OnPropertyChanged(nameof(Parties));
            }
        }
        private void SupprimerPartie(Partie partie)
        {
            if (partie != null)
            {
                Parties.Remove(partie);
                OnPropertyChanged(nameof(Parties));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
