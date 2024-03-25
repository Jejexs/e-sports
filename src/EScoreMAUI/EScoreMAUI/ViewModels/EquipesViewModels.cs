using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using EScoreMAUI.Entity;
using EScoreMAUI.Entity.Statistiques;

namespace EScoreMAUI.ViewModels
{
    public class EquipesViewModel : INotifyPropertyChanged
    {
        private Equipe _selectedEquipe;

        public Equipe SelectedEquipe
        {
            get => _selectedEquipe;
            set
            {
                if (_selectedEquipe != value)
                {
                    _selectedEquipe = value;
                    OnPropertyChanged(nameof(SelectedEquipe));
                }
            }
        }

        public ObservableCollection<Equipe> Equipes { get; set; } = new ObservableCollection<Equipe>();

        public ICommand AjouterEquipeCommand { get; private set; }
        public ICommand MettreAJourEquipeCommand { get; private set; }
        public ICommand SupprimerEquipeCommand { get; private set; }

        public EquipesViewModel()
        {
            AjouterEquipeCommand = new Command<Equipe>(AjouterEquipe);
            MettreAJourEquipeCommand = new Command<Equipe>(MettreAJourEquipe);
            SupprimerEquipeCommand = new Command<Equipe>(SupprimerEquipe);
        }

        private void AjouterEquipe(Equipe equipe)
        {
            Equipes.Add(equipe);
            OnPropertyChanged(nameof(Equipes));
        }

        private void MettreAJourEquipe(Equipe equipe)
        {
            var equipeExistant = Equipes.FirstOrDefault(j => j.Id == equipe.Id);
            if (equipeExistant != null)
            {
                equipeExistant.Nom = equipe.Nom;
                equipeExistant.Joueurs = equipe.Joueurs;
                equipeExistant.Statistiques = equipe.Statistiques;
                OnPropertyChanged(nameof(Equipes));
            }
        }

        private void SupprimerEquipe(Equipe equipe)
        {
            Equipes.Remove(equipe);
            OnPropertyChanged(nameof(Equipes));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
