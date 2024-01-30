using EScoreMAUI.Entity.Statistiques;

namespace EScoreMAUI;

public class Parties
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Jeu { get; set; } // Nom du jeu
    public List<Equipes> Equipes { get; set; } = new List<Equipes>(); // Équipes participantes
    public string Score { get; set; } // Score final, peut être une chaîne pour gérer différents formats
    public StatistiquesPartie Statistiques { get; set; } // Statistiques spécifiques de la partie
    
    public Parties(int id, DateTime date, string jeu, string score)
    {
        Id = id;
        Date = date;
        Jeu = jeu;
        Score = score;
    }
}
