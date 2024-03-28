using System;
using EScoreMAUI.Entity.Statistiques;

namespace EScoreMAUI.Entity
{
    public class Partie
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Jeu { get; set; }
        public Equipe Equipe1 { get; set; }
        public Equipe Equipe2 { get; set; }
        public int Score { get; set; }
        public ResultatPartie Resultat { get; set; }
        public StatistiquesPartie Statistiques { get; set; }
        public string Lieu { get; set; }
        public int EquipeGagnanteId { get; set; }
        public int EquipePerdanteId { get; set; }
    }

    public enum ResultatPartie
    {
        Victoire,
        Defaite,
        MatchNul
    }
}