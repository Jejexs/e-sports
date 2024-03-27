using System;

namespace EScoreMAUI.Entity
{
    public class Joueur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pseudo { get; set; }
        public Equipe Equipe { get; set; } // Modifier le type pour correspondre à la classe Equipe

        public Joueur() // Ajouter un constructeur par défaut pour la sérialisation
        {

        }

        public Joueur(int id, string nom, string prenom, string pseudo, Equipe equipe) // Modifier le type de la paramètre equipe
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Pseudo = pseudo;
            Equipe = equipe;
        }
    }
}