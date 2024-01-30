namespace EScoreMAUI.Entity.Statistiques;

public class StatistiquesEquipe
{
    public int id { get; set; }
    public int victoire { get; set; }
    public int defaite { get; set; }
    public int nul { get; set; }
    public int matchJoue { get; set; }
    public int idEquipe { get; set; }
    
    public StatistiquesEquipe(int id, int victoire, int defaite, int nul, int matchJoue, int idEquipe)
    {
        this.id = id;
        this.victoire = victoire;
        this.defaite = defaite;
        this.nul = nul;
        this.matchJoue = matchJoue;
        this.idEquipe = idEquipe;
    }

    public StatistiquesEquipe()
    {
    }
}