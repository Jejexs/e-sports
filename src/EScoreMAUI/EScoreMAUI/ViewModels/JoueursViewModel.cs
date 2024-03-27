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
        public ObservableCollection<Joueur> Joueurs { get;  set;} = App.Joueurs;

        // Collection des équipes disponibles
        public ObservableCollection<Equipe> EquipesDisponibles { get; private set; }

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

        public void AjouterJoueur(Joueur joueur)
        {
            // Vérifiez si la liste des joueurs est null, sinon créez une nouvelle collection
            if (Joueurs == null)
            {
                Joueurs = new ObservableCollection<Joueur>();
            }

            Joueurs.Add(joueur);
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
                Joueurs.Remove(joueur);
                OnPropertyChanged(nameof(Joueurs));
            }
        }

        // Charger les équipes disponibles depuis la source de données
        private void LoadEquipesDisponibles()
        {
            // Charger la vraie liste des équipes à partir de la classe App
            EquipesDisponibles = App.Equipes;
            OnPropertyChanged(nameof(EquipesDisponibles));
        }

        // Implémentation de INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
