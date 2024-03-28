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
        public int Points { get; set; }

        public Equipe()
        {
        }

        public Equipe(int id, string nom) : this()
        {
            Id = id;
            Nom = nom;
        }
    }
}