namespace EScoreMAUI.Entity.Statistiques;

// Entity des Statistiques de l'application où on retrouve les informations des statistiques de l'équipe

// Entity des Statistiques de l'application où on retrouve les informations des statistiques de l'équipe
public class StatistiquesEquipe
{
    public int Id { get; set; }
    public int Victoire { get; set; }
    public int Defaite { get; set; }
    public int Nul { get; set; }
    public int MatchJoue { get; set; }
    public int IdEquipe { get; set; }

    public StatistiquesEquipe(int id, int victoire, int defaite, int nul, int matchJoue, int idEquipe)
    {
        Id = id;
        Victoire = victoire;
        Defaite = defaite;
        Nul = nul;
        MatchJoue = matchJoue;
        IdEquipe = idEquipe;
    }

    public StatistiquesEquipe()
    {
    }
}