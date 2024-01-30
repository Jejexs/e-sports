using EScoreMAUI.Entity.Statistiques;

namespace EScoreMAUI;

public class Equipes
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public List<Joueurs> Joueurs { get; set; } = new List<Joueurs>();
    public StatistiquesEquipe Statistiques { get; set; } = new StatistiquesEquipe();
    
    public Equipes(int id, string nom)
    {
        Id = id;
        Nom = nom;
    }

}