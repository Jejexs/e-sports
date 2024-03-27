using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using EScoreMAUI.Entity;
using Microsoft.Maui.Controls;

namespace EScoreMAUI.ViewModels
{
    public class EquipesViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Equipe> Equipes { get; set; } = App.Equipes;

        public ICommand AjouterEquipeCommand { get; private set; }
        public ICommand MettreAJourEquipeCommand { get; private set; }
        public ICommand SupprimerEquipeCommand { get; private set; }

        public EquipesViewModel()
        {
            AjouterEquipeCommand = new Command<string>(AjouterEquipe);
            MettreAJourEquipeCommand = new Command<Equipe>(MettreAJourEquipe);
            SupprimerEquipeCommand = new Command<Equipe>(SupprimerEquipe);
        }

        private void AjouterEquipe(string nomEquipe)
        {
            Console.WriteLine("Ajout d'une nouvelle équipe : " + nomEquipe);
            Equipe nouvelleEquipe = new Equipe { Nom = nomEquipe };
            Equipes.Add(nouvelleEquipe);
            Console.WriteLine("Équipe ajoutée : " + nomEquipe);
            OnPropertyChanged(nameof(Equipes));
        }
        
        private void MettreAJourEquipe(Equipe equipe)
        {
            var equipeExistant = Equipes?.FirstOrDefault(e => e?.Id == equipe?.Id);
            if (equipeExistant != null)
            {
                equipeExistant.Nom = equipe.Nom;
                OnPropertyChanged(nameof(Equipes));
            }
        }
        
        private void SupprimerEquipe(Equipe equipe)
        {
            if (equipe != null)
            {
                Equipes.Remove(equipe);
                OnPropertyChanged(nameof(Equipes));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}