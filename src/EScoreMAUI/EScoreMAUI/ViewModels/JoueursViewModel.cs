using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using EScoreMAUI.Entity;
using Microsoft.Maui.Controls;

namespace EScoreMAUI.ViewModels
{
    public class JoueursViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Joueur> Joueurs { get; } = new ObservableCollection<Joueur>();

        private ObservableCollection<Equipe> _equipesDisponibles;
        public ObservableCollection<Equipe> EquipesDisponibles 
        {
            get { return _equipesDisponibles; }
            set 
            { 
                _equipesDisponibles = value; 
                OnPropertyChanged(nameof(EquipesDisponibles));
            }
        }

        public ICommand AjouterJoueurCommand { get; }
        public ICommand MettreAJourJoueurCommand { get; }
        public ICommand SupprimerJoueurCommand { get; }

        public JoueursViewModel()
        {
            AjouterJoueurCommand = new Command<Joueur>(AjouterJoueur);
            MettreAJourJoueurCommand = new Command<Joueur>(MettreAJourJoueur);
            SupprimerJoueurCommand = new Command<Joueur>(SupprimerJoueur);

            // Charger les équipes disponibles depuis la source de données
            LoadEquipesDisponibles();
        }

        private void AjouterJoueur(Joueur joueur)
        {
            Joueurs.Add(joueur);
            Console.WriteLine($"Joueur ajouté : {joueur.Nom} {joueur.Prenom} ({joueur.Pseudo})");
            OnPropertyChanged(nameof(Joueurs));
        }

        private void MettreAJourJoueur(Joueur joueur)
        {
            var joueurExistant = Joueurs.FirstOrDefault(j => j?.Id == joueur?.Id);
            if (joueurExistant != null)
            {
                joueurExistant.Nom = joueur.Nom;
                joueurExistant.Pseudo = joueur.Pseudo;
                joueurExistant.Equipe = joueur.Equipe;
                OnPropertyChanged(nameof(Joueurs));
            }
        }

        private void SupprimerJoueur(Joueur joueur)
        {
            if (joueur != null)
            {
                int index = Joueurs.IndexOf(joueur);
                if (index != -1)
                {
                    Joueurs.RemoveAt(index);
                    OnPropertyChanged(nameof(Joueurs));
                }
            }
        }

        // Charger les équipes disponibles depuis la source de données
        private void LoadEquipesDisponibles()
        {
            // Charger la vraie liste des équipes à partir de la classe App
            EquipesDisponibles = new ObservableCollection<Equipe>(App.Equipes);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
