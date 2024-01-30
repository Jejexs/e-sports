using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using EScoreMAUI.Entity;
using EScoreMAUI.Entity.Statistiques;

namespace EScoreMAUI.ViewModels;

public class JoueursViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Joueurs> Joueurs { get; set; } = new ObservableCollection<Joueurs>();

    public ICommand AjouterJoueurCommand { get; private set; }
    public ICommand MettreAJourJoueurCommand { get; private set; }
    public ICommand SupprimerJoueurCommand { get; private set; }

    public JoueursViewModel()
    {
        AjouterJoueurCommand = new Command<Joueurs>(AjouterJoueur);
        MettreAJourJoueurCommand = new Command<Joueurs>(MettreAJourJoueur);
        SupprimerJoueurCommand = new Command<Joueurs>(SupprimerJoueur);
    }

    private void AjouterJoueur(Joueurs joueur)
    {
        Joueurs.Add(joueur);
        OnPropertyChanged(nameof(Joueurs));
    }

    private void MettreAJourJoueur(Joueurs joueur)
    {
        var joueurExistant = Joueurs.FirstOrDefault(j => j.Id == joueur.Id);
        if (joueurExistant != null)
        {
            joueurExistant.Nom = joueur.Nom;
            joueurExistant.Pseudo = joueur.Pseudo;
            joueurExistant.Equipe = joueur.Equipe;
            // Mettre à jour les statistiques si nécessaire
            OnPropertyChanged(nameof(Joueurs));
        }
    }

    private void SupprimerJoueur(Joueurs joueur)
    {
        Joueurs.Remove(joueur);
        OnPropertyChanged(nameof(Joueurs));
    }

    public void MettreAJourStatistiquesJoueur(int joueurId, string jeu, StatistiquesJeu nouvellesStatistiques)
    {
        var joueur = Joueurs.FirstOrDefault(j => j.Id == joueurId);
        joueur?.Statistiques.MettreAJourStatistiquesJeu(jeu, nouvellesStatistiques);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}