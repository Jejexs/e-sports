using System;
using System.Collections.Generic;
using EScoreMAUI.Entity;
using EScoreMAUI.Entity.Statistiques;

namespace EScoreMAUI.Entity
{
    public class Partie
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Jeu { get; set; }
        public List<Equipe> Equipes { get; set; } // Liste des équipes participantes
        public int Score { get; set; }
        public StatistiquesPartie Statistiques { get; set; } // Statistiques spécifiques de la partie

        // Propriétés supplémentaires
        public string Lieu { get; set; } // Lieu de la partie

        public Partie(int id, DateTime date, string jeu, int score)
        {
            Id = id;
            Date = date;
            Jeu = jeu;
            Score = score;
        }
    }
}