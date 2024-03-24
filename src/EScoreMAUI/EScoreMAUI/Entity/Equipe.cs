using System;
using EScoreMAUI.Entity.Statistiques;

namespace EScoreMAUI.Entity;

// Entity des Equipes de l'application où on retrouve les informations des équipes
public class Equipe
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public List<Joueur> Joueurs { get; set; } = new List<Joueur>();
    public StatistiquesEquipe Statistiques { get; set; } = new StatistiquesEquipe();

    public Equipe(int id, string nom)
    {
        Id = id;
        Nom = nom;
    }
}