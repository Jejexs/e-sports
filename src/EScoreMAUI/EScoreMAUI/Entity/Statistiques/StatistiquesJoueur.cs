using System.Collections.Generic;
namespace EScoreMAUI.Entity.Statistiques;

// Entity des Statistiques de l'application où on retrouve les statistiques des joueurs

public class StatistiquesJoueur : Statistiques
{
    // Dictionnaire stockant les statistiques pour chaque jeu
    public Dictionary<string, StatistiquesJeu> StatistiquesParJeu { get; set; } = new Dictionary<string, StatistiquesJeu>();

    public void AjouterOuMettreAJourStatistiques(string jeu, StatistiquesJeu nouvellesStatistiques)
    {
        if (StatistiquesParJeu.ContainsKey(jeu))
        {
            // Mettre à jour les statistiques existantes pour ce jeu
            StatistiquesParJeu[jeu].MettreAJour(nouvellesStatistiques);
        }
        else
        {
            // Ajouter de nouvelles statistiques pour un nouveau jeu
            StatistiquesParJeu.Add(jeu, nouvellesStatistiques);
        }
    }
}

public class StatistiquesJeu
{
    public int Kills { get; set; }
    public int Morts { get; set; }
    public int Assistances { get; set; }

    public void MettreAJour(StatistiquesJeu nouvellesStatistiques)
    {
        // Logique pour mettre à jour les statistiques avec les nouvelles valeurs
        Kills += nouvellesStatistiques.Kills;
        Morts += nouvellesStatistiques.Morts;
        Assistances += nouvellesStatistiques.Assistances;
        // Mettez à jour d'autres statistiques selon le besoin
    }
}