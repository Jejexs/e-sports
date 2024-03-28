using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using EScoreMAUI.Entity;
using EScoreMAUI.Entity.Statistiques;
using Microsoft.Maui.Controls;

namespace EScoreMAUI.ViewModels
{
    public class StatistiquesViewModel : INotifyPropertyChanged
    {
        private Partie _partie;
        private Equipe _equipe1;
        private Equipe _equipe2;

        public List<Equipe> Equipes { get; set; }

        private int _points;
        private string _nomEquipeGagnante;
        private string _nomEquipePerdante;

        // Ajoutez les propriétés manquantes
        public string NomEquipeGagnante
        {
            get => _nomEquipeGagnante;
            set
            {
                if (_nomEquipeGagnante != value)
                {
                    _nomEquipeGagnante = value;
                    OnPropertyChanged(nameof(NomEquipeGagnante));
                }
            }
        }

        public string NomEquipePerdante
        {
            get => _nomEquipePerdante;
            set
            {
                if (_nomEquipePerdante != value)
                {
                    _nomEquipePerdante = value;
                    OnPropertyChanged(nameof(NomEquipePerdante));
                }
            }
        }

        public Partie Partie
        {
            get => _partie;
            set
            {
                if (_partie != value)
                {
                    _partie = value;
                    OnPropertyChanged(nameof(Partie));
                }
            }
        }

        public Equipe Equipe1
        {
            get => _equipe1;
            set
            {
                if (_equipe1 != value)
                {
                    _equipe1 = value;
                    OnPropertyChanged(nameof(Equipe1));
                }
            }
        }

        public Equipe Equipe2
        {
            get => _equipe2;
            set
            {
                if (_equipe2 != value)
                {
                    _equipe2 = value;
                    OnPropertyChanged(nameof(Equipe2));
                }
            }
        }

        public ICommand AjouterStatistiquesCommand { get; set; }

        public StatistiquesViewModel()
        {
            AjouterStatistiquesCommand = new Command(() => AjouterStatistiques(Equipe1, Equipe2));
        }

        private bool _statsAdded = false;

        public void AjouterStatistiques(Equipe equipeGagnante, Equipe equipePerdante)
        {
            if (!_statsAdded)
            {
                if (Partie.Statistiques == null)
                {
                    Partie.Statistiques = new StatistiquesPartie();
                }

                Partie.Statistiques.NombreMatchsJoues++;

                switch (Partie.Resultat)
                {
                    case ResultatPartie.Victoire:
                        Partie.Statistiques.NombreMatchsGagnes++;
                        break;
                    case ResultatPartie.Defaite:
                        Partie.Statistiques.NombreMatchsPerdus++;
                        break;
                    case ResultatPartie.MatchNul:
                        Partie.Statistiques.NombreMatchsNuls++;
                        break;
                }

                // Calcul du taux de victoire
                // Partie.Statistiques.TauxVictoire = (double)Partie.Statistiques.NombreMatchsGagnes / Partie.Statistiques.NombreMatchsJoues * 100;

                UpdateTeamStatistics(Partie);

                _statsAdded = true;
            }
        }


        private void UpdateTeamStatistics(Partie partie)
        {
            Equipe equipeGagnante = Equipes.FirstOrDefault(e => e.Id == partie.EquipeGagnanteId);
            Equipe equipePerdante = Equipes.FirstOrDefault(e => e.Id == partie.EquipePerdanteId);

            if (equipeGagnante != null)
            {
                equipeGagnante.Statistiques.Victoire++;
            }

            if (equipePerdante != null)
            {
                equipePerdante.Statistiques.Defaite++;
            }

            CalculateTeamPoints(partie);
        }

        private void CalculateTeamPoints(Partie partie)
        {
            switch (partie.Resultat)
            {
                case ResultatPartie.Victoire:
                    Equipe1.Points += 3;
                    break;
                case ResultatPartie.Defaite:
                    Equipe2.Points += 3;
                    break;
                case ResultatPartie.MatchNul:
                    Equipe1.Points += 1;
                    Equipe2.Points += 1;
                    break;
            }
        }

        public void AfficherInformationsPartie(Partie partie)
        {
            Console.WriteLine($"ID de la partie : {partie.Id}");
            Console.WriteLine($"Nom de l'équipe 1 : {Equipe1.Nom}");
            Console.WriteLine($"Nom de l'équipe 2 : {Equipe2.Nom}");
            Console.WriteLine($"Points de l'équipe 1 : {Equipe1.Points}");
            Console.WriteLine($"Points de l'équipe 2 : {Equipe2.Points}");
            Console.WriteLine($"Nom de l'équipe gagnante : {NomEquipeGagnante}");
            Console.WriteLine($"Nom de l'équipe perdante : {NomEquipePerdante}");
        }

        public StatistiquesViewModel(Partie partie, Equipe equipe1, Equipe equipe2)
        {
            Partie = partie;
            Equipe1 = equipe1;
            Equipe2 = equipe2;
            Equipes = new List<Equipe> { equipe1, equipe2 };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}