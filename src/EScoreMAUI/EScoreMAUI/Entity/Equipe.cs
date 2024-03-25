using System.Collections.Generic;
using EScoreMAUI.Entity.Statistiques;

namespace EScoreMAUI.Entity
{
    // Entity des Equipes de l'application où on retrouve les informations des équipes
    public class Equipe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<Joueur> Joueurs { get; set; } = new List<Joueur>();
        public StatistiquesEquipe Statistiques { get; set; } = new StatistiquesEquipe();

        // Ajoutez un constructeur par défaut si nécessaire
        public Equipe()
        {
        }

        // Si vous prévoyez d'utiliser le constructeur avec des paramètres, assurez-vous de l'utiliser dans votre code
        public Equipe(int id, string nom) : this()
        {
            Id = id;
            Nom = nom;
        }
    }
}